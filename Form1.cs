using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyfareReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setConnectState(false);
            TestAndConnect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortRFID.IsOpen)
            {
                closePort(); // 確保串列埠被正確關閉
            }
        }

        string ConsoleText = string.Empty;

        const byte EEPROM_ERROR = 0x1 << 0; // 內部 EEPROM 寫入錯誤
        const byte CARD_OK = 0x1 << 1;      // 支援該卡片標準
        const byte RX_OK = 0x1 << 2;        // 卡片通訊 OK
        const byte RS232_ERROR = 0x1 << 3;  // 主機通訊埠錯誤
        const byte MF_TYPE = 0x1 << 4;      // 0: 1k 卡
                                            // 1: 4k 卡
        const byte UL_TYPE = 0x1 << 5;      // 0: 標準 1k/4k 卡
                                            // 1: ultralight 卡，兩個 UID
        const byte MFRC_ERROR = 0x1 << 5;   // 內部天線錯誤

        private byte[] hexStringToByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            byte[] returnedBytes = new byte[hexString.Length / 2];

            for (int i = 0; i < returnedBytes.Length; i++)

                returnedBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);

            return returnedBytes;
        }


        private String byteToHexString(byte[] buffer)
        {
            String hexString = "";

            for (int i = 0; i < buffer.Length; i++)
                hexString += buffer[i].ToString("X2"); //將資料先轉16進位

            return hexString;
        }

        string byteToHexAsciiStr(byte[] buffer)
        {
            string str = "";
            string hex = "";
            string ascii = "";
            int i = 0;

            for (; i < buffer.Length; i++)
            {
                // 將資料轉換為16進位，並保證每個字元佔兩格 (X2)
                hex += buffer[i].ToString("X2");
                // 每8個字元後加一個空格
                if ((i + 1) % 8 == 0 && (i + 1) % 16 != 0) hex += " ";
                // 檢查是否為可見字元，否則用 '.' 表示
                if (!char.IsControl((char)buffer[i]))
                    ascii += (char)buffer[i];
                else
                    ascii += '.';

                // 每16個字元後輸出一行
                if ((i + 1) % 16 == 0)
                {
                    str += "| " + hex + " | " + ascii + " |\n";
                    hex = "";
                    ascii = "";
                }
            }

            // 補齊最後不足16字元的一行
            if (i % 16 != 0)
            {
                // 填充空格以對齊
                while (i % 16 != 0)
                {
                    hex += "  "; // 每個字元佔三格（兩格數字 + 一格空白）
                    ascii += " ";
                    i++;
                }
                str += "| " + hex + " | " + ascii + " |\n";
            }

            return str;
        }

        void setConnectState(Boolean s)
        {
            if (s)
            {
                labelStatusIcon.Text = "●";
                labelStatusIcon.ForeColor = Color.FromArgb(64, 160, 43); // Color.Green;
                labelStatusText.Text = "讀卡機連線成功";

                comboCOM.Enabled = false;
                textCommand.Enabled = true;
                btnSendCommand.Enabled = true;

                btnConnect.Text = "斷線";

                // control
                textAmount.Enabled = true;
                btnCharge.Enabled = true;
                btnDeduction.Enabled = false;
            }
            else
            {
                labelStatusIcon.Text = "×";
                labelStatusIcon.ForeColor = Color.FromArgb(210, 15, 57); //Color.Red;
                labelStatusText.Text = "讀卡機連線失敗";

                comboCOM.Enabled = true;
                textCommand.Enabled = false;
                btnSendCommand.Enabled = false;

                textCardID.Text = "";
                labelIdStatus.Text = "-";
                labelIdStatus.ForeColor = Color.Gainsboro;

                btnConnect.Text = "連線";

                // control
                textBalance.Text = "---";
                textAmount.Enabled = false;
                textAmount.Text = "0";
                btnCharge.Enabled = false;
                btnDeduction.Enabled = false;
            }
        }

        int openPort(string comName)
        {
            if (serialPortRFID.IsOpen) return 1;
            Console.WriteLine("[+] Port opening.");
            serialPortRFID.PortName = comName;
            try
            {
                serialPortRFID.Open();
                setConnectState(true);
            }
            catch (Exception err)
            {
                Console.WriteLine("[-] " + err.Message);
                textResponse.AppendText("[-] " + err.Message + "\r\n");
                setConnectState(false);
                return 0;
            }
            return 1;
        }

        void closePort()
        {
            if (!serialPortRFID.IsOpen) return;
            Console.WriteLine("[-] Port closing.");
            try
            {
                serialPortRFID.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("[-] " + err.Message);
                textResponse.AppendText("[-] " + err.Message + "\r\n");
                return;
            }
            setConnectState(false);
        }

        bool TestAndConnect()
        {
            // test which com to connect
            for (int i = 0; i < 20; i++)
            {
                openPort("COM" + i);
                if (serialPortRFID.IsOpen)
                {
                    setConnectState(true);
                    comboCOM.Items.Add("COM" + i);
                    comboCOM.Text = "COM" + i;
                    textResponse.AppendText("[+] " + comboCOM.Text + " successfully opened.\r\n");
                    return true;
                }
            }
            return false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPortRFID.IsOpen)
            {
                closePort();
                return;
            }

            if (comboCOM.Text == "")
            {
                TestAndConnect();
                return;
            }

            // 無法連線
            if (openPort(comboCOM.Text) == 0)
            {
                MessageBox.Show("無法與 " + comboCOM.Text + " 連線", "連線錯誤", MessageBoxButtons.OK, MessageBoxIcon.None);
                setConnectState(false);
                return;
            }

            if (serialPortRFID.IsOpen)
            {
                textResponse.AppendText("[+] " + comboCOM.Text + " successfully opened.\r\n");
                setConnectState(true);
                if(!comboCOM.Items.Contains(comboCOM.Text)) comboCOM.Items.Add(comboCOM.Text);
            }
        }

        // 將 TextCommand 的命令送出，並將回傳資料寫入 Console
        void sendConsoleCmdRecv()
        {
            if (textCommand.Text == "") return;
            textResponse.AppendText("[+] data writing: 0x" + textCommand.Text + "\r\n");
            System.Console.WriteLine("[+] data writing: 0x" + textCommand.Text);
            byte[] data = sendCommand(textCommand.Text);
            string res = byteToHexString(data);
            updateStatusCode(data[0]);
            textResponse.AppendText("[+] status code: 0x" + data[0].ToString("X2") + "\r\n");
            textResponse.AppendText("[+] data received: 0x" + res.Substring(2, res.Length - 2) + "\r\n");
            textResponse.AppendText("[+] data hex and ascii dump:\r\n");
            textResponse.AppendText(byteToHexAsciiStr(hexStringToByte(res.Substring(2, res.Length - 2))) + "\r\n");
            textCommand.Text = "";
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            sendConsoleCmdRecv();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPortRFID.IsOpen)
            {
                setConnectState(false);
                labelCardStatusHint.Text = "卡片讀取失敗";
                return;
            }

            byte[] bufferR = sendCommand("55");
            if (bufferR[0] == 0x86)
            {
                // Card ID Status
                string res = byteToHexString(bufferR);
                textCardID.Text = res.Substring(2, 8);

                labelIdStatus.Text = "●";
                labelIdStatus.ForeColor = Color.FromArgb(64, 160, 43);
                
                labelCardStatusHint.Text = "卡片讀取成功";
                labelCardStatusHint.ForeColor = Color.FromArgb(64, 160, 43);

                byte[] data = queryData(1);
                int balance = 0;
                for (int i = 0; i < 4; i++) {
                    balance += data[1 + i] << (i * 4);
                }
                textBalance.Text = balance.ToString();
            }
            else
            {
                // Card ID Status
                labelIdStatus.Text = "×";
                labelIdStatus.ForeColor = Color.FromArgb(210, 15, 57);
                textCardID.Text = "None";
                
                labelCardStatusHint.Text = "卡片讀取失敗";
                labelCardStatusHint.ForeColor = Color.FromArgb(210, 15, 57);
            }
        }

        void setStatusBit(System.Windows.Forms.TextBox t, int b) {
            bool prev = t.Text.Equals("1");
            if (b != 0)
            {
                t.Text = "1";
                t.BackColor = Color.FromArgb(166, 209, 137); // green
            }
            else
            {
                t.Text = "0";
                if (prev) t.BackColor = Color.FromArgb(243, 139, 168);
                else t.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        void updateStatusCode(byte code)
        {
            Console.WriteLine("Status code: 0x{0:X}", code);
            setStatusBit(statusBit0 ,code & EEPROM_ERROR);
            setStatusBit(statusBit1, code & CARD_OK);
            setStatusBit(statusBit2, code & RX_OK);
            setStatusBit(statusBit3, code & RS232_ERROR);
            setStatusBit(statusBit4, code & MF_TYPE);
            setStatusBit(statusBit5, code & UL_TYPE);
            setStatusBit(statusBit6, code & MFRC_ERROR);
            setStatusBit(statusBit7, code & (1 << 7));
        }

        byte[] readByte(int size)
        {
            byte[] bufferR = new byte[size];

            try
            {
                serialPortRFID.DiscardInBuffer();
                serialPortRFID.ReadTimeout = 1000;
                System.Threading.Thread.Sleep(100);
                serialPortRFID.Read(bufferR, 0, bufferR.Length);
            }
            catch (Exception err)
            {
                textResponse.AppendText("[-] " + err.Message + "\r\n");
            }
            return bufferR;
        }

        void writeByte(byte[] bufferW)
        {
            if (!checkConnection()) return;
            try
            {
                serialPortRFID.Write(bufferW, 0, bufferW.Length);
            }
            catch (Exception err)
            {
                textResponse.AppendText("[-] " + err.Message + "\r\n");
            }
        }

        bool checkConnection()
        {
            bool state = serialPortRFID.IsOpen;
            setConnectState(state);
            return state;
        }

        void charge(int amount) {
            byte[] cmd = hexStringToByte("49010001" + amount.ToString("X2"));
            writeByte(cmd);
        }

        byte[] queryData(int block)
        {
            string cmd = "52" + block.ToString("X2") + "00";
            byte[] data = hexStringToByte(cmd);
            writeByte(data);
            return readByte(17);
        }

        byte[] sendCommand(string c)
        {
            byte[] bufferW = hexStringToByte(c);
            writeByte(bufferW);

            byte[] bufferR = readByte(17);
            return bufferR;
        }

        private void textCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // 阻止按鍵的預設行為

                sendConsoleCmdRecv();
            }

            if (e.Control && e.KeyCode == Keys.L)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // 阻止按鍵的預設行為

                textResponse.Clear();
            }
        }

        private void btnDumpCard_Click(object sender, EventArgs e)
        {
            for (int i = 63; i >= 0; i--) {
                byte[] access = new byte[4];
                int keyA, keyB;
                byte[] data = queryData(i);
                byte statusCode = data[0];
                data = data.Skip(1).Take(16).ToArray();

                // control block
                if (i % 4 == 3) {
                    byte A = (byte)((data[7] & 0xF0) >> 4);
                    byte B = (byte)(data[8] & 0x0F);
                    byte C = (byte)((data[8] & 0xF0) >> 4);
                    Console.WriteLine("[*] A=" + A.ToString("X2") + ", B=" + B.ToString("X2") + ", C=" + C.ToString("X2"));
                    for (int j = 0; j < 4; j++) {
                        access[j] = (byte)(((A & (0x01 << j)) >> j) |
                            (((B & (0x01 << j)) >> j) << 1) |
                            (((C & (0x01 << j)) >> j) << 2));
                        Console.WriteLine("[*] access=" + access[j].ToString());
                    }
                }

                // print hex and ascii
                string hex = "", ascii = "";
                for (int j = 0; j < 16; j ++) {
                    hex += data[j].ToString("X2") + " ";
                    if ((j + 1) != 0 && (j + 1) % 8 == 0) hex += " ";
                    if (char.IsControl((char)data[j])) ascii += ".";
                    else ascii += (char)data[j];
                }

                string accessBits = "[ " +
                    ((access[i % 4] & 1) != 0 ? "1" : "0") + " " +
                    ((access[i % 4] & (1 << 1)) != 0 ? "1" : "0") + " " +
                    ((access[i % 4] & (1 << 2)) != 0 ? "1" : "0") + " ]";
                Console.WriteLine("[+] {0} access bit= {1} {2}", i%3, access[i%4], accessBits);

                textResponse.AppendText("[+] 0x" + i.ToString("X2") + "  " + hex + " |" + ascii + "|  " + accessBits + "\r\n");
            }
        }
    }
}

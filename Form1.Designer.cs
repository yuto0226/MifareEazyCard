namespace MyfareReader
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.textCommand = new System.Windows.Forms.TextBox();
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.textResponse = new System.Windows.Forms.TextBox();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.groupConsole = new System.Windows.Forms.GroupBox();
            this.groupSetting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.labelCardStatusHint = new System.Windows.Forms.Label();
            this.labelIdStatus = new System.Windows.Forms.Label();
            this.textCardID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBit0 = new System.Windows.Forms.TextBox();
            this.statusBit1 = new System.Windows.Forms.TextBox();
            this.statusBit2 = new System.Windows.Forms.TextBox();
            this.statusBit3 = new System.Windows.Forms.TextBox();
            this.statusBit4 = new System.Windows.Forms.TextBox();
            this.statusBit5 = new System.Windows.Forms.TextBox();
            this.statusBit6 = new System.Windows.Forms.TextBox();
            this.statusBit7 = new System.Windows.Forms.TextBox();
            this.labelStatusIcon = new System.Windows.Forms.Label();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDumpCard = new System.Windows.Forms.Button();
            this.btnDeduction = new System.Windows.Forms.Button();
            this.btnCharge = new System.Windows.Forms.Button();
            this.textBalance = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuItemRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearAmount = new System.Windows.Forms.Button();
            this.groupConsole.SuspendLayout();
            this.groupSetting.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommand.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCommand.Location = new System.Drawing.Point(587, 279);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(85, 34);
            this.btnSendCommand.TabIndex = 3;
            this.btnSendCommand.TabStop = false;
            this.btnSendCommand.Text = "送出";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // textCommand
            // 
            this.textCommand.AcceptsReturn = true;
            this.textCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCommand.Font = new System.Drawing.Font("JetBrainsMono NF Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCommand.Location = new System.Drawing.Point(6, 279);
            this.textCommand.Name = "textCommand";
            this.textCommand.Size = new System.Drawing.Size(575, 34);
            this.textCommand.TabIndex = 2;
            this.textCommand.Text = "530000";
            this.textCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCommand_KeyDown);
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.serialPortRFID.StopBits = System.IO.Ports.StopBits.Two;
            // 
            // textResponse
            // 
            this.textResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResponse.Font = new System.Drawing.Font("JetBrainsMono NF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResponse.Location = new System.Drawing.Point(6, 26);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.ReadOnly = true;
            this.textResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResponse.Size = new System.Drawing.Size(660, 247);
            this.textResponse.TabIndex = 99;
            this.textResponse.TabStop = false;
            // 
            // comboCOM
            // 
            this.comboCOM.Font = new System.Drawing.Font("JetBrainsMono NF", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Items.AddRange(new object[] {
            ""});
            this.comboCOM.Location = new System.Drawing.Point(76, 26);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(216, 30);
            this.comboCOM.TabIndex = 0;
            this.comboCOM.TabStop = false;
            // 
            // groupConsole
            // 
            this.groupConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConsole.Controls.Add(this.textCommand);
            this.groupConsole.Controls.Add(this.textResponse);
            this.groupConsole.Controls.Add(this.btnSendCommand);
            this.groupConsole.Font = new System.Drawing.Font("JetBrainsMono NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConsole.Location = new System.Drawing.Point(12, 272);
            this.groupConsole.Name = "groupConsole";
            this.groupConsole.Size = new System.Drawing.Size(672, 319);
            this.groupConsole.TabIndex = 4;
            this.groupConsole.TabStop = false;
            this.groupConsole.Text = "Console";
            // 
            // groupSetting
            // 
            this.groupSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSetting.Controls.Add(this.label1);
            this.groupSetting.Controls.Add(this.comboCOM);
            this.groupSetting.Font = new System.Drawing.Font("JetBrainsMono NF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSetting.Location = new System.Drawing.Point(690, 442);
            this.groupSetting.Name = "groupSetting";
            this.groupSetting.Size = new System.Drawing.Size(298, 69);
            this.groupSetting.TabIndex = 5;
            this.groupSetting.TabStop = false;
            this.groupSetting.Text = "Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "通訊埠";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConnect.Location = new System.Drawing.Point(690, 517);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(298, 74);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.TabStop = false;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupStatus
            // 
            this.groupStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStatus.Controls.Add(this.labelCardStatusHint);
            this.groupStatus.Controls.Add(this.labelIdStatus);
            this.groupStatus.Controls.Add(this.textCardID);
            this.groupStatus.Controls.Add(this.label3);
            this.groupStatus.Controls.Add(this.label2);
            this.groupStatus.Controls.Add(this.statusBit0);
            this.groupStatus.Controls.Add(this.statusBit1);
            this.groupStatus.Controls.Add(this.statusBit2);
            this.groupStatus.Controls.Add(this.statusBit3);
            this.groupStatus.Controls.Add(this.statusBit4);
            this.groupStatus.Controls.Add(this.statusBit5);
            this.groupStatus.Controls.Add(this.statusBit6);
            this.groupStatus.Controls.Add(this.statusBit7);
            this.groupStatus.Controls.Add(this.labelStatusIcon);
            this.groupStatus.Controls.Add(this.labelStatusText);
            this.groupStatus.Font = new System.Drawing.Font("JetBrainsMono NF Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStatus.Location = new System.Drawing.Point(690, 35);
            this.groupStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(298, 401);
            this.groupStatus.TabIndex = 6;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // labelCardStatusHint
            // 
            this.labelCardStatusHint.AutoSize = true;
            this.labelCardStatusHint.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardStatusHint.Location = new System.Drawing.Point(6, 140);
            this.labelCardStatusHint.Margin = new System.Windows.Forms.Padding(3, 14, 3, 4);
            this.labelCardStatusHint.Name = "labelCardStatusHint";
            this.labelCardStatusHint.Size = new System.Drawing.Size(100, 22);
            this.labelCardStatusHint.TabIndex = 18;
            this.labelCardStatusHint.Text = "卡片讀取失敗";
            // 
            // labelIdStatus
            // 
            this.labelIdStatus.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelIdStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIdStatus.Location = new System.Drawing.Point(241, 100);
            this.labelIdStatus.Name = "labelIdStatus";
            this.labelIdStatus.Size = new System.Drawing.Size(48, 38);
            this.labelIdStatus.TabIndex = 15;
            this.labelIdStatus.Text = "-";
            this.labelIdStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCardID
            // 
            this.textCardID.Font = new System.Drawing.Font("JetBrainsMono NF", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCardID.Location = new System.Drawing.Point(6, 100);
            this.textCardID.MaxLength = 20;
            this.textCardID.Name = "textCardID";
            this.textCardID.ReadOnly = true;
            this.textCardID.Size = new System.Drawing.Size(229, 38);
            this.textCardID.TabIndex = 14;
            this.textCardID.TabStop = false;
            this.textCardID.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 14, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Card ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 14, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status Code";
            // 
            // statusBit0
            // 
            this.statusBit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit0.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit0.Location = new System.Drawing.Point(223, 206);
            this.statusBit0.MaxLength = 1;
            this.statusBit0.Name = "statusBit0";
            this.statusBit0.ReadOnly = true;
            this.statusBit0.Size = new System.Drawing.Size(25, 25);
            this.statusBit0.TabIndex = 10;
            this.statusBit0.TabStop = false;
            this.statusBit0.Text = "0";
            this.statusBit0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit1
            // 
            this.statusBit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit1.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit1.Location = new System.Drawing.Point(192, 206);
            this.statusBit1.MaxLength = 1;
            this.statusBit1.Name = "statusBit1";
            this.statusBit1.ReadOnly = true;
            this.statusBit1.Size = new System.Drawing.Size(25, 25);
            this.statusBit1.TabIndex = 9;
            this.statusBit1.TabStop = false;
            this.statusBit1.Text = "0";
            this.statusBit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit2
            // 
            this.statusBit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit2.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit2.Location = new System.Drawing.Point(161, 206);
            this.statusBit2.MaxLength = 1;
            this.statusBit2.Name = "statusBit2";
            this.statusBit2.ReadOnly = true;
            this.statusBit2.Size = new System.Drawing.Size(25, 25);
            this.statusBit2.TabIndex = 8;
            this.statusBit2.TabStop = false;
            this.statusBit2.Text = "0";
            this.statusBit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit3
            // 
            this.statusBit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit3.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit3.Location = new System.Drawing.Point(130, 206);
            this.statusBit3.MaxLength = 1;
            this.statusBit3.Name = "statusBit3";
            this.statusBit3.ReadOnly = true;
            this.statusBit3.Size = new System.Drawing.Size(25, 25);
            this.statusBit3.TabIndex = 7;
            this.statusBit3.TabStop = false;
            this.statusBit3.Text = "0";
            this.statusBit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit4
            // 
            this.statusBit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit4.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit4.Location = new System.Drawing.Point(99, 206);
            this.statusBit4.MaxLength = 1;
            this.statusBit4.Name = "statusBit4";
            this.statusBit4.ReadOnly = true;
            this.statusBit4.Size = new System.Drawing.Size(25, 25);
            this.statusBit4.TabIndex = 6;
            this.statusBit4.TabStop = false;
            this.statusBit4.Text = "0";
            this.statusBit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit5
            // 
            this.statusBit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit5.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit5.Location = new System.Drawing.Point(68, 206);
            this.statusBit5.MaxLength = 1;
            this.statusBit5.Name = "statusBit5";
            this.statusBit5.ReadOnly = true;
            this.statusBit5.Size = new System.Drawing.Size(25, 25);
            this.statusBit5.TabIndex = 5;
            this.statusBit5.TabStop = false;
            this.statusBit5.Text = "0";
            this.statusBit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit6
            // 
            this.statusBit6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit6.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit6.Location = new System.Drawing.Point(37, 206);
            this.statusBit6.MaxLength = 1;
            this.statusBit6.Name = "statusBit6";
            this.statusBit6.ReadOnly = true;
            this.statusBit6.Size = new System.Drawing.Size(25, 25);
            this.statusBit6.TabIndex = 4;
            this.statusBit6.TabStop = false;
            this.statusBit6.Text = "0";
            this.statusBit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBit7
            // 
            this.statusBit7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusBit7.Font = new System.Drawing.Font("JetBrainsMono NF", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBit7.Location = new System.Drawing.Point(6, 206);
            this.statusBit7.MaxLength = 1;
            this.statusBit7.Name = "statusBit7";
            this.statusBit7.ReadOnly = true;
            this.statusBit7.Size = new System.Drawing.Size(25, 25);
            this.statusBit7.TabIndex = 3;
            this.statusBit7.TabStop = false;
            this.statusBit7.Text = "0";
            this.statusBit7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatusIcon
            // 
            this.labelStatusIcon.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelStatusIcon.Location = new System.Drawing.Point(241, 24);
            this.labelStatusIcon.Margin = new System.Windows.Forms.Padding(3, 4, 12, 0);
            this.labelStatusIcon.Name = "labelStatusIcon";
            this.labelStatusIcon.Size = new System.Drawing.Size(48, 38);
            this.labelStatusIcon.TabIndex = 1;
            this.labelStatusIcon.Text = "●";
            this.labelStatusIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatusText.Location = new System.Drawing.Point(6, 27);
            this.labelStatusText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(107, 33);
            this.labelStatusText.TabIndex = 0;
            this.labelStatusText.Text = "連線失敗";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClearAmount);
            this.groupBox1.Controls.Add(this.btnDumpCard);
            this.groupBox1.Controls.Add(this.btnDeduction);
            this.groupBox1.Controls.Add(this.btnCharge);
            this.groupBox1.Controls.Add(this.textBalance);
            this.groupBox1.Controls.Add(this.labelBalance);
            this.groupBox1.Controls.Add(this.textAmount);
            this.groupBox1.Controls.Add(this.labelAmount);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 231);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // btnDumpCard
            // 
            this.btnDumpCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDumpCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDumpCard.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDumpCard.Location = new System.Drawing.Point(463, 168);
            this.btnDumpCard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnDumpCard.Name = "btnDumpCard";
            this.btnDumpCard.Size = new System.Drawing.Size(203, 54);
            this.btnDumpCard.TabIndex = 6;
            this.btnDumpCard.TabStop = false;
            this.btnDumpCard.Text = "Dump Data";
            this.btnDumpCard.UseVisualStyleBackColor = true;
            this.btnDumpCard.Click += new System.EventHandler(this.btnDumpCard_Click);
            // 
            // btnDeduction
            // 
            this.btnDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeduction.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDeduction.Location = new System.Drawing.Point(532, 92);
            this.btnDeduction.Name = "btnDeduction";
            this.btnDeduction.Size = new System.Drawing.Size(134, 54);
            this.btnDeduction.TabIndex = 5;
            this.btnDeduction.TabStop = false;
            this.btnDeduction.Text = "扣款";
            this.btnDeduction.UseVisualStyleBackColor = true;
            this.btnDeduction.Click += new System.EventHandler(this.btnDeduction_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCharge.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCharge.Location = new System.Drawing.Point(532, 30);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(134, 54);
            this.btnCharge.TabIndex = 4;
            this.btnCharge.TabStop = false;
            this.btnCharge.Text = "儲值";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // textBalance
            // 
            this.textBalance.AutoSize = true;
            this.textBalance.Font = new System.Drawing.Font("JetBrainsMono NF", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBalance.Location = new System.Drawing.Point(88, 29);
            this.textBalance.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(263, 53);
            this.textBalance.TabIndex = 3;
            this.textBalance.Text = "1000000000";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Noto Sans TC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelBalance.Location = new System.Drawing.Point(6, 39);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(74, 41);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "餘額";
            // 
            // textAmount
            // 
            this.textAmount.Font = new System.Drawing.Font("JetBrainsMono NF", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmount.Location = new System.Drawing.Point(95, 88);
            this.textAmount.MaxLength = 10;
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(254, 60);
            this.textAmount.TabIndex = 1;
            this.textAmount.TabStop = false;
            this.textAmount.Text = "1000000000";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Noto Sans TC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAmount.Location = new System.Drawing.Point(6, 101);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(74, 41);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "金額";
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuMain.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1000, 30);
            this.menuMain.TabIndex = 8;
            this.menuMain.Text = "選單";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存新檔ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRepo});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusMain.Location = new System.Drawing.Point(0, 593);
            this.statusMain.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1000, 28);
            this.statusMain.TabIndex = 9;
            this.statusMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripStatusLabel1.Text = "進度條";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 20);
            // 
            // menuItemRepo
            // 
            this.menuItemRepo.Name = "menuItemRepo";
            this.menuItemRepo.Size = new System.Drawing.Size(224, 26);
            this.menuItemRepo.Text = "repo";
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.結束ToolStripMenuItem.Text = "結束";
            // 
            // btnClearAmount
            // 
            this.btnClearAmount.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClearAmount.Location = new System.Drawing.Point(355, 92);
            this.btnClearAmount.Name = "btnClearAmount";
            this.btnClearAmount.Size = new System.Drawing.Size(171, 54);
            this.btnClearAmount.TabIndex = 7;
            this.btnClearAmount.TabStop = false;
            this.btnClearAmount.Text = "清除金額";
            this.btnClearAmount.UseVisualStyleBackColor = true;
            this.btnClearAmount.Click += new System.EventHandler(this.btnClearAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 621);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupConsole);
            this.Controls.Add(this.groupSetting);
            this.Controls.Add(this.menuMain);
            this.MinimumSize = new System.Drawing.Size(1018, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupConsole.ResumeLayout(false);
            this.groupConsole.PerformLayout();
            this.groupSetting.ResumeLayout(false);
            this.groupSetting.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox textCommand;
        private System.IO.Ports.SerialPort serialPortRFID;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.ComboBox comboCOM;
        private System.Windows.Forms.GroupBox groupConsole;
        private System.Windows.Forms.GroupBox groupSetting;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label labelStatusIcon;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox statusBit7;
        private System.Windows.Forms.TextBox statusBit6;
        private System.Windows.Forms.TextBox statusBit1;
        private System.Windows.Forms.TextBox statusBit2;
        private System.Windows.Forms.TextBox statusBit3;
        private System.Windows.Forms.TextBox statusBit4;
        private System.Windows.Forms.TextBox statusBit5;
        private System.Windows.Forms.TextBox statusBit0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCardID;
        private System.Windows.Forms.Label labelIdStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelCardStatusHint;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label textBalance;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button btnDeduction;
        private System.Windows.Forms.Button btnDumpCard;
        private System.Windows.Forms.ToolStripMenuItem menuItemRepo;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.Button btnClearAmount;
    }
}


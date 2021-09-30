namespace telnet25
{
    partial class Telnet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.ehloButton = new System.Windows.Forms.Button();
            this.mailFromButton = new System.Windows.Forms.Button();
            this.authButton = new System.Windows.Forms.Button();
            this.rcptToButton = new System.Windows.Forms.Button();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.BodyTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.strSubject = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.enableDeliveryReceiptCheckBox = new System.Windows.Forms.CheckBox();
            this.enableReadReceiptCheckBox = new System.Windows.Forms.CheckBox();
            this.enableAdditionalHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.enableReplyToCheckBox = new System.Windows.Forms.CheckBox();
            this.enableSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.enableCcCheckBox = new System.Windows.Forms.CheckBox();
            this.strHeaderValue = new System.Windows.Forms.Label();
            this.strHeaderName = new System.Windows.Forms.Label();
            this.headerValueBox = new System.Windows.Forms.TextBox();
            this.headerNameBox = new System.Windows.Forms.TextBox();
            this.strReturnPath = new System.Windows.Forms.Label();
            this.strSize = new System.Windows.Forms.Label();
            this.returnPathBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.enableClearPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.enableBasicAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.enableHELOCheckBox = new System.Windows.Forms.CheckBox();
            this.connectorPort = new System.Windows.Forms.Label();
            this.connectorIp = new System.Windows.Forms.Label();
            this.connectorPortBox = new System.Windows.Forms.TextBox();
            this.connectorIpBox = new System.Windows.Forms.TextBox();
            this.strEhloDomain = new System.Windows.Forms.Label();
            this.strCc = new System.Windows.Forms.Label();
            this.strPassword = new System.Windows.Forms.Label();
            this.strUserName = new System.Windows.Forms.Label();
            this.strRcptTo = new System.Windows.Forms.Label();
            this.strMailFrom = new System.Windows.Forms.Label();
            this.ehloDomainBox = new System.Windows.Forms.TextBox();
            this.ccBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.rcptToBox = new System.Windows.Forms.TextBox();
            this.mailFromBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.waitingForResponseString = new System.Windows.Forms.Label();
            this.stepByStepCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(39, 40);
            this.connectButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(163, 42);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "SEND";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(249, 44);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(834, 400);
            this.outputTextBox.TabIndex = 8;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // ehloButton
            // 
            this.ehloButton.Enabled = false;
            this.ehloButton.Location = new System.Drawing.Point(39, 114);
            this.ehloButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ehloButton.Name = "ehloButton";
            this.ehloButton.Size = new System.Drawing.Size(163, 42);
            this.ehloButton.TabIndex = 2;
            this.ehloButton.Text = "EHLO";
            this.ehloButton.UseVisualStyleBackColor = true;
            this.ehloButton.Click += new System.EventHandler(this.ehloButton_Click);
            // 
            // mailFromButton
            // 
            this.mailFromButton.Enabled = false;
            this.mailFromButton.Location = new System.Drawing.Point(39, 258);
            this.mailFromButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mailFromButton.Name = "mailFromButton";
            this.mailFromButton.Size = new System.Drawing.Size(163, 42);
            this.mailFromButton.TabIndex = 4;
            this.mailFromButton.Text = "MAIL FROM";
            this.mailFromButton.UseVisualStyleBackColor = true;
            this.mailFromButton.Click += new System.EventHandler(this.mailFromButton_Click);
            // 
            // authButton
            // 
            this.authButton.Enabled = false;
            this.authButton.Location = new System.Drawing.Point(39, 188);
            this.authButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(163, 42);
            this.authButton.TabIndex = 3;
            this.authButton.Text = "AUTH LOGIN";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // rcptToButton
            // 
            this.rcptToButton.Enabled = false;
            this.rcptToButton.Location = new System.Drawing.Point(39, 330);
            this.rcptToButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rcptToButton.Name = "rcptToButton";
            this.rcptToButton.Size = new System.Drawing.Size(163, 42);
            this.rcptToButton.TabIndex = 5;
            this.rcptToButton.Text = "RCPT TO";
            this.rcptToButton.UseVisualStyleBackColor = true;
            this.rcptToButton.Click += new System.EventHandler(this.rcptToButton_Click);
            // 
            // sendDataButton
            // 
            this.sendDataButton.Enabled = false;
            this.sendDataButton.Location = new System.Drawing.Point(39, 404);
            this.sendDataButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(163, 42);
            this.sendDataButton.TabIndex = 6;
            this.sendDataButton.Text = "Send DATA";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.Location = new System.Drawing.Point(39, 460);
            this.BodyTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BodyTextBox.Multiline = true;
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BodyTextBox.Size = new System.Drawing.Size(1044, 616);
            this.BodyTextBox.TabIndex = 7;
            this.BodyTextBox.Text = "Enter BODY here...";
            this.BodyTextBox.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 1138);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.strSubject);
            this.tabPage1.Controls.Add(this.subjectBox);
            this.tabPage1.Controls.Add(this.enableDeliveryReceiptCheckBox);
            this.tabPage1.Controls.Add(this.enableReadReceiptCheckBox);
            this.tabPage1.Controls.Add(this.enableAdditionalHeaderCheckBox);
            this.tabPage1.Controls.Add(this.enableReplyToCheckBox);
            this.tabPage1.Controls.Add(this.enableSizeCheckBox);
            this.tabPage1.Controls.Add(this.enableCcCheckBox);
            this.tabPage1.Controls.Add(this.strHeaderValue);
            this.tabPage1.Controls.Add(this.strHeaderName);
            this.tabPage1.Controls.Add(this.headerValueBox);
            this.tabPage1.Controls.Add(this.headerNameBox);
            this.tabPage1.Controls.Add(this.strReturnPath);
            this.tabPage1.Controls.Add(this.strSize);
            this.tabPage1.Controls.Add(this.returnPathBox);
            this.tabPage1.Controls.Add(this.sizeBox);
            this.tabPage1.Controls.Add(this.enableClearPasswordCheckBox);
            this.tabPage1.Controls.Add(this.enableBasicAuthCheckBox);
            this.tabPage1.Controls.Add(this.enableHELOCheckBox);
            this.tabPage1.Controls.Add(this.connectorPort);
            this.tabPage1.Controls.Add(this.connectorIp);
            this.tabPage1.Controls.Add(this.connectorPortBox);
            this.tabPage1.Controls.Add(this.connectorIpBox);
            this.tabPage1.Controls.Add(this.strEhloDomain);
            this.tabPage1.Controls.Add(this.strCc);
            this.tabPage1.Controls.Add(this.strPassword);
            this.tabPage1.Controls.Add(this.strUserName);
            this.tabPage1.Controls.Add(this.strRcptTo);
            this.tabPage1.Controls.Add(this.strMailFrom);
            this.tabPage1.Controls.Add(this.ehloDomainBox);
            this.tabPage1.Controls.Add(this.ccBox);
            this.tabPage1.Controls.Add(this.passwordBox);
            this.tabPage1.Controls.Add(this.usernameBox);
            this.tabPage1.Controls.Add(this.rcptToBox);
            this.tabPage1.Controls.Add(this.mailFromBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage1.Size = new System.Drawing.Size(1102, 1091);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Telnet Properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // strSubject
            // 
            this.strSubject.AutoSize = true;
            this.strSubject.Location = new System.Drawing.Point(43, 380);
            this.strSubject.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strSubject.Name = "strSubject";
            this.strSubject.Size = new System.Drawing.Size(83, 24);
            this.strSubject.TabIndex = 27;
            this.strSubject.Text = "Subject:";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(340, 368);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(305, 36);
            this.subjectBox.TabIndex = 6;
            this.subjectBox.Text = "Test mail from Basic SMTP Telnet Client";
            // 
            // enableDeliveryReceiptCheckBox
            // 
            this.enableDeliveryReceiptCheckBox.AutoSize = true;
            this.enableDeliveryReceiptCheckBox.Enabled = false;
            this.enableDeliveryReceiptCheckBox.Location = new System.Drawing.Point(340, 796);
            this.enableDeliveryReceiptCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableDeliveryReceiptCheckBox.Name = "enableDeliveryReceiptCheckBox";
            this.enableDeliveryReceiptCheckBox.Size = new System.Drawing.Size(194, 28);
            this.enableDeliveryReceiptCheckBox.TabIndex = 17;
            this.enableDeliveryReceiptCheckBox.Text = "Delivery Receipt";
            this.enableDeliveryReceiptCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableReadReceiptCheckBox
            // 
            this.enableReadReceiptCheckBox.AutoSize = true;
            this.enableReadReceiptCheckBox.Location = new System.Drawing.Point(50, 796);
            this.enableReadReceiptCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableReadReceiptCheckBox.Name = "enableReadReceiptCheckBox";
            this.enableReadReceiptCheckBox.Size = new System.Drawing.Size(162, 28);
            this.enableReadReceiptCheckBox.TabIndex = 16;
            this.enableReadReceiptCheckBox.Text = "Read Receipt";
            this.enableReadReceiptCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableAdditionalHeaderCheckBox
            // 
            this.enableAdditionalHeaderCheckBox.AutoSize = true;
            this.enableAdditionalHeaderCheckBox.Location = new System.Drawing.Point(667, 636);
            this.enableAdditionalHeaderCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableAdditionalHeaderCheckBox.Name = "enableAdditionalHeaderCheckBox";
            this.enableAdditionalHeaderCheckBox.Size = new System.Drawing.Size(300, 28);
            this.enableAdditionalHeaderCheckBox.TabIndex = 14;
            this.enableAdditionalHeaderCheckBox.Text = "Define Additional HEADER";
            this.enableAdditionalHeaderCheckBox.UseVisualStyleBackColor = true;
            this.enableAdditionalHeaderCheckBox.CheckedChanged += new System.EventHandler(this.enableAdditionalHeaderCheckBox_CheckedChanged);
            // 
            // enableReplyToCheckBox
            // 
            this.enableReplyToCheckBox.AutoSize = true;
            this.enableReplyToCheckBox.Location = new System.Drawing.Point(667, 572);
            this.enableReplyToCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableReplyToCheckBox.Name = "enableReplyToCheckBox";
            this.enableReplyToCheckBox.Size = new System.Drawing.Size(367, 28);
            this.enableReplyToCheckBox.TabIndex = 12;
            this.enableReplyToCheckBox.Text = "Define Alternative Reply-To Email ";
            this.enableReplyToCheckBox.UseVisualStyleBackColor = true;
            this.enableReplyToCheckBox.CheckedChanged += new System.EventHandler(this.enableReplyToCheckBox_CheckedChanged);
            // 
            // enableSizeCheckBox
            // 
            this.enableSizeCheckBox.AutoSize = true;
            this.enableSizeCheckBox.Location = new System.Drawing.Point(667, 508);
            this.enableSizeCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableSizeCheckBox.Name = "enableSizeCheckBox";
            this.enableSizeCheckBox.Size = new System.Drawing.Size(362, 28);
            this.enableSizeCheckBox.TabIndex = 10;
            this.enableSizeCheckBox.Text = "Define Message SIZE in KiloBytes";
            this.enableSizeCheckBox.UseVisualStyleBackColor = true;
            this.enableSizeCheckBox.CheckedChanged += new System.EventHandler(this.enableSizeCheckBox_CheckedChanged);
            // 
            // enableCcCheckBox
            // 
            this.enableCcCheckBox.AutoSize = true;
            this.enableCcCheckBox.Location = new System.Drawing.Point(667, 442);
            this.enableCcCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableCcCheckBox.Name = "enableCcCheckBox";
            this.enableCcCheckBox.Size = new System.Drawing.Size(140, 28);
            this.enableCcCheckBox.TabIndex = 8;
            this.enableCcCheckBox.Text = "Enable CC";
            this.enableCcCheckBox.UseVisualStyleBackColor = true;
            this.enableCcCheckBox.CheckedChanged += new System.EventHandler(this.enableCcCheckBox_CheckedChanged);
            // 
            // strHeaderValue
            // 
            this.strHeaderValue.AutoSize = true;
            this.strHeaderValue.Location = new System.Drawing.Point(43, 712);
            this.strHeaderValue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strHeaderValue.Name = "strHeaderValue";
            this.strHeaderValue.Size = new System.Drawing.Size(166, 24);
            this.strHeaderValue.TabIndex = 32;
            this.strHeaderValue.Text = "HEADER Value:";
            // 
            // strHeaderName
            // 
            this.strHeaderName.AutoSize = true;
            this.strHeaderName.Location = new System.Drawing.Point(43, 646);
            this.strHeaderName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strHeaderName.Name = "strHeaderName";
            this.strHeaderName.Size = new System.Drawing.Size(167, 24);
            this.strHeaderName.TabIndex = 31;
            this.strHeaderName.Text = "HEADER Name:";
            // 
            // headerValueBox
            // 
            this.headerValueBox.Location = new System.Drawing.Point(340, 700);
            this.headerValueBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.headerValueBox.Name = "headerValueBox";
            this.headerValueBox.ReadOnly = true;
            this.headerValueBox.Size = new System.Drawing.Size(305, 36);
            this.headerValueBox.TabIndex = 15;
            // 
            // headerNameBox
            // 
            this.headerNameBox.Location = new System.Drawing.Point(340, 634);
            this.headerNameBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.headerNameBox.Name = "headerNameBox";
            this.headerNameBox.ReadOnly = true;
            this.headerNameBox.Size = new System.Drawing.Size(305, 36);
            this.headerNameBox.TabIndex = 13;
            // 
            // strReturnPath
            // 
            this.strReturnPath.AutoSize = true;
            this.strReturnPath.Location = new System.Drawing.Point(43, 582);
            this.strReturnPath.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strReturnPath.Name = "strReturnPath";
            this.strReturnPath.Size = new System.Drawing.Size(123, 24);
            this.strReturnPath.TabIndex = 30;
            this.strReturnPath.Text = "Return Path:";
            // 
            // strSize
            // 
            this.strSize.AutoSize = true;
            this.strSize.Location = new System.Drawing.Point(43, 516);
            this.strSize.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strSize.Name = "strSize";
            this.strSize.Size = new System.Drawing.Size(65, 24);
            this.strSize.TabIndex = 29;
            this.strSize.Text = "SIZE:";
            // 
            // returnPathBox
            // 
            this.returnPathBox.Location = new System.Drawing.Point(340, 568);
            this.returnPathBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.returnPathBox.Name = "returnPathBox";
            this.returnPathBox.ReadOnly = true;
            this.returnPathBox.Size = new System.Drawing.Size(305, 36);
            this.returnPathBox.TabIndex = 11;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(340, 504);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.ReadOnly = true;
            this.sizeBox.Size = new System.Drawing.Size(305, 36);
            this.sizeBox.TabIndex = 9;
            // 
            // enableClearPasswordCheckBox
            // 
            this.enableClearPasswordCheckBox.AutoSize = true;
            this.enableClearPasswordCheckBox.Enabled = false;
            this.enableClearPasswordCheckBox.Location = new System.Drawing.Point(667, 986);
            this.enableClearPasswordCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableClearPasswordCheckBox.Name = "enableClearPasswordCheckBox";
            this.enableClearPasswordCheckBox.Size = new System.Drawing.Size(138, 28);
            this.enableClearPasswordCheckBox.TabIndex = 21;
            this.enableClearPasswordCheckBox.Text = "Clear Text";
            this.enableClearPasswordCheckBox.UseVisualStyleBackColor = true;
            this.enableClearPasswordCheckBox.CheckedChanged += new System.EventHandler(this.enableClearPasswordCheckBox_CheckedChanged);
            // 
            // enableBasicAuthCheckBox
            // 
            this.enableBasicAuthCheckBox.AutoSize = true;
            this.enableBasicAuthCheckBox.Location = new System.Drawing.Point(667, 912);
            this.enableBasicAuthCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableBasicAuthCheckBox.Name = "enableBasicAuthCheckBox";
            this.enableBasicAuthCheckBox.Size = new System.Drawing.Size(354, 28);
            this.enableBasicAuthCheckBox.TabIndex = 20;
            this.enableBasicAuthCheckBox.Text = "Connect with Basic Authentication";
            this.enableBasicAuthCheckBox.UseVisualStyleBackColor = true;
            this.enableBasicAuthCheckBox.CheckedChanged += new System.EventHandler(this.enableBasicAuthCheckBox_CheckedChanged);
            // 
            // enableHELOCheckBox
            // 
            this.enableHELOCheckBox.AutoSize = true;
            this.enableHELOCheckBox.Location = new System.Drawing.Point(667, 176);
            this.enableHELOCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.enableHELOCheckBox.Name = "enableHELOCheckBox";
            this.enableHELOCheckBox.Size = new System.Drawing.Size(313, 28);
            this.enableHELOCheckBox.TabIndex = 3;
            this.enableHELOCheckBox.Text = "Send HELO instead of EHLO";
            this.enableHELOCheckBox.UseVisualStyleBackColor = true;
            this.enableHELOCheckBox.CheckedChanged += new System.EventHandler(this.enableHELOCheckBox_CheckedChanged);
            // 
            // connectorPort
            // 
            this.connectorPort.AutoSize = true;
            this.connectorPort.Location = new System.Drawing.Point(661, 72);
            this.connectorPort.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.connectorPort.Name = "connectorPort";
            this.connectorPort.Size = new System.Drawing.Size(96, 24);
            this.connectorPort.TabIndex = 23;
            this.connectorPort.Text = "TCP Port";
            // 
            // connectorIp
            // 
            this.connectorIp.AutoSize = true;
            this.connectorIp.Location = new System.Drawing.Point(43, 72);
            this.connectorIp.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.connectorIp.Name = "connectorIp";
            this.connectorIp.Size = new System.Drawing.Size(208, 24);
            this.connectorIp.TabIndex = 22;
            this.connectorIp.Text = "Receive Connector IP";
            // 
            // connectorPortBox
            // 
            this.connectorPortBox.Location = new System.Drawing.Point(802, 66);
            this.connectorPortBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.connectorPortBox.Name = "connectorPortBox";
            this.connectorPortBox.Size = new System.Drawing.Size(84, 36);
            this.connectorPortBox.TabIndex = 1;
            this.connectorPortBox.Text = "25";
            this.connectorPortBox.TextChanged += new System.EventHandler(this.connectorPortBox_TextChanged);
            // 
            // connectorIpBox
            // 
            this.connectorIpBox.Location = new System.Drawing.Point(340, 66);
            this.connectorIpBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.connectorIpBox.Name = "connectorIpBox";
            this.connectorIpBox.Size = new System.Drawing.Size(305, 36);
            this.connectorIpBox.TabIndex = 0;
            this.connectorIpBox.Text = "localhost";
            this.connectorIpBox.TextChanged += new System.EventHandler(this.connectorIpBox_TextChanged);
            // 
            // strEhloDomain
            // 
            this.strEhloDomain.AutoSize = true;
            this.strEhloDomain.Location = new System.Drawing.Point(43, 170);
            this.strEhloDomain.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strEhloDomain.Name = "strEhloDomain";
            this.strEhloDomain.Size = new System.Drawing.Size(154, 24);
            this.strEhloDomain.TabIndex = 24;
            this.strEhloDomain.Text = "EHLO Domain:";
            // 
            // strCc
            // 
            this.strCc.AutoSize = true;
            this.strCc.Location = new System.Drawing.Point(43, 450);
            this.strCc.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strCc.Name = "strCc";
            this.strCc.Size = new System.Drawing.Size(46, 24);
            this.strCc.TabIndex = 28;
            this.strCc.Text = "CC:";
            // 
            // strPassword
            // 
            this.strPassword.AutoSize = true;
            this.strPassword.Location = new System.Drawing.Point(43, 996);
            this.strPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strPassword.Name = "strPassword";
            this.strPassword.Size = new System.Drawing.Size(103, 24);
            this.strPassword.TabIndex = 34;
            this.strPassword.Text = "Password:";
            // 
            // strUserName
            // 
            this.strUserName.AutoSize = true;
            this.strUserName.Location = new System.Drawing.Point(43, 920);
            this.strUserName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strUserName.Name = "strUserName";
            this.strUserName.Size = new System.Drawing.Size(119, 24);
            this.strUserName.TabIndex = 33;
            this.strUserName.Text = "User Name:";
            // 
            // strRcptTo
            // 
            this.strRcptTo.AutoSize = true;
            this.strRcptTo.Location = new System.Drawing.Point(43, 306);
            this.strRcptTo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strRcptTo.Name = "strRcptTo";
            this.strRcptTo.Size = new System.Drawing.Size(132, 24);
            this.strRcptTo.TabIndex = 26;
            this.strRcptTo.Text = "Recipient To:";
            // 
            // strMailFrom
            // 
            this.strMailFrom.AutoSize = true;
            this.strMailFrom.Location = new System.Drawing.Point(43, 248);
            this.strMailFrom.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.strMailFrom.Name = "strMailFrom";
            this.strMailFrom.Size = new System.Drawing.Size(114, 24);
            this.strMailFrom.TabIndex = 25;
            this.strMailFrom.Text = "Mail From:";
            // 
            // ehloDomainBox
            // 
            this.ehloDomainBox.Location = new System.Drawing.Point(340, 170);
            this.ehloDomainBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ehloDomainBox.Name = "ehloDomainBox";
            this.ehloDomainBox.Size = new System.Drawing.Size(305, 36);
            this.ehloDomainBox.TabIndex = 2;
            this.ehloDomainBox.Text = "localhost";
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(340, 438);
            this.ccBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ccBox.Name = "ccBox";
            this.ccBox.ReadOnly = true;
            this.ccBox.Size = new System.Drawing.Size(305, 36);
            this.ccBox.TabIndex = 7;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(340, 982);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(305, 36);
            this.passwordBox.TabIndex = 19;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(340, 906);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(305, 36);
            this.usernameBox.TabIndex = 18;
            // 
            // rcptToBox
            // 
            this.rcptToBox.Location = new System.Drawing.Point(340, 300);
            this.rcptToBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rcptToBox.Name = "rcptToBox";
            this.rcptToBox.Size = new System.Drawing.Size(305, 36);
            this.rcptToBox.TabIndex = 5;
            this.rcptToBox.Text = "othermail@example.com";
            // 
            // mailFromBox
            // 
            this.mailFromBox.Location = new System.Drawing.Point(340, 234);
            this.mailFromBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mailFromBox.Name = "mailFromBox";
            this.mailFromBox.Size = new System.Drawing.Size(305, 36);
            this.mailFromBox.TabIndex = 4;
            this.mailFromBox.Text = "yourmail@example.com";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.waitingForResponseString);
            this.tabPage2.Controls.Add(this.stepByStepCheckBox);
            this.tabPage2.Controls.Add(this.ehloButton);
            this.tabPage2.Controls.Add(this.BodyTextBox);
            this.tabPage2.Controls.Add(this.connectButton);
            this.tabPage2.Controls.Add(this.outputTextBox);
            this.tabPage2.Controls.Add(this.sendDataButton);
            this.tabPage2.Controls.Add(this.mailFromButton);
            this.tabPage2.Controls.Add(this.rcptToButton);
            this.tabPage2.Controls.Add(this.authButton);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabPage2.Size = new System.Drawing.Size(1102, 1091);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Telnet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // waitingForResponseString
            // 
            this.waitingForResponseString.AutoSize = true;
            this.waitingForResponseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.waitingForResponseString.ForeColor = System.Drawing.Color.Red;
            this.waitingForResponseString.Location = new System.Drawing.Point(839, 12);
            this.waitingForResponseString.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.waitingForResponseString.Name = "waitingForResponseString";
            this.waitingForResponseString.Size = new System.Drawing.Size(238, 26);
            this.waitingForResponseString.TabIndex = 9;
            this.waitingForResponseString.Text = "Waiting for Response...";
            this.waitingForResponseString.Visible = false;
            // 
            // stepByStepCheckBox
            // 
            this.stepByStepCheckBox.AutoSize = true;
            this.stepByStepCheckBox.Location = new System.Drawing.Point(249, 12);
            this.stepByStepCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stepByStepCheckBox.Name = "stepByStepCheckBox";
            this.stepByStepCheckBox.Size = new System.Drawing.Size(303, 28);
            this.stepByStepCheckBox.TabIndex = 0;
            this.stepByStepCheckBox.Text = "Enable Step by Step Sending";
            this.stepByStepCheckBox.UseVisualStyleBackColor = true;
            this.stepByStepCheckBox.CheckedChanged += new System.EventHandler(this.stepByStepCheckBox_CheckedChanged);
            // 
            // Telnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 1170);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Telnet";
            this.Text = "SMTP Connection to";
            this.Load += new System.EventHandler(this.Telnet_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button ehloButton;
        private System.Windows.Forms.Button mailFromButton;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button rcptToButton;
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.TextBox BodyTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox mailFromBox;
        private System.Windows.Forms.Label strEhloDomain;
        private System.Windows.Forms.Label strCc;
        private System.Windows.Forms.Label strPassword;
        private System.Windows.Forms.Label strUserName;
        private System.Windows.Forms.Label strRcptTo;
        private System.Windows.Forms.Label strMailFrom;
        private System.Windows.Forms.TextBox ehloDomainBox;
        private System.Windows.Forms.TextBox ccBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox rcptToBox;
        private System.Windows.Forms.Label connectorPort;
        private System.Windows.Forms.Label connectorIp;
        public System.Windows.Forms.TextBox connectorPortBox;
        public System.Windows.Forms.TextBox connectorIpBox;
        private System.Windows.Forms.CheckBox enableBasicAuthCheckBox;
        private System.Windows.Forms.CheckBox enableHELOCheckBox;
        private System.Windows.Forms.Label strReturnPath;
        private System.Windows.Forms.Label strSize;
        private System.Windows.Forms.TextBox returnPathBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.CheckBox enableClearPasswordCheckBox;
        private System.Windows.Forms.CheckBox enableAdditionalHeaderCheckBox;
        private System.Windows.Forms.CheckBox enableReplyToCheckBox;
        private System.Windows.Forms.CheckBox enableSizeCheckBox;
        private System.Windows.Forms.CheckBox enableCcCheckBox;
        private System.Windows.Forms.Label strHeaderValue;
        private System.Windows.Forms.Label strHeaderName;
        private System.Windows.Forms.TextBox headerValueBox;
        private System.Windows.Forms.TextBox headerNameBox;
        private System.Windows.Forms.CheckBox enableDeliveryReceiptCheckBox;
        private System.Windows.Forms.CheckBox enableReadReceiptCheckBox;
        private System.Windows.Forms.Label strSubject;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.CheckBox stepByStepCheckBox;
        private System.Windows.Forms.Label waitingForResponseString;
    }
}


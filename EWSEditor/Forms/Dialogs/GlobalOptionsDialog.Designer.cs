﻿namespace EWSEditor.Forms
{
    partial class OptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            this.OkButton = new System.Windows.Forms.Button();
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBypassProxyForLocalAddress = new System.Windows.Forms.CheckBox();
            this.rdoSpecifyProxySettings = new System.Windows.Forms.RadioButton();
            this.rdoDontOverrideProxySettings = new System.Windows.Forms.RadioButton();
            this.chkOverrideProxyCredentials = new System.Windows.Forms.CheckBox();
            this.txtProxyServerDomain = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtProxyServerPassword = new System.Windows.Forms.TextBox();
            this.txtProxyServerUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtProxyServerPort = new System.Windows.Forms.TextBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.txtProxyServerName = new System.Windows.Forms.TextBox();
            this.lblProxyServer = new System.Windows.Forms.Label();
            this.MiscSettingsGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboSelectedTimeZoneContextId = new System.Windows.Forms.ComboBox();
            this.chkAddTimeZoneContext = new System.Windows.Forms.CheckBox();
            this.cmboUserAgent = new System.Windows.Forms.ComboBox();
            this.chkOverrideTimezone = new System.Windows.Forms.CheckBox();
            this.PreAuthenticate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkOverrideTimeout = new System.Windows.Forms.CheckBox();
            this.cmboSelectedTimeZoneId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.EnableScpLookups = new System.Windows.Forms.CheckBox();
            this.UserAgentLabel = new System.Windows.Forms.Label();
            this.EnableSslDetailCheck = new System.Windows.Forms.CheckBox();
            this.DumpFolderText = new System.Windows.Forms.TextBox();
            this.AllowRedirectsCheck = new System.Windows.Forms.CheckBox();
            this.FindItemText = new System.Windows.Forms.TextBox();
            this.OverrideSslCheck = new System.Windows.Forms.CheckBox();
            this.FindFolderText = new System.Windows.Forms.TextBox();
            this.CalendarViewText = new System.Windows.Forms.TextBox();
            this.DumpFolderLabel = new System.Windows.Forms.Label();
            this.FindItemLabel = new System.Windows.Forms.Label();
            this.FindFolderLabel = new System.Windows.Forms.Label();
            this.CalendarViewLabel = new System.Windows.Forms.Label();
            this.LoggingGroup = new System.Windows.Forms.GroupBox();
            this.LogFilePathText = new System.Windows.Forms.TextBox();
            this.LogFilePathLabel = new System.Windows.Forms.Label();
            this.SaveLogFileCheck = new System.Windows.Forms.CheckBox();
            this.grpAdditionalHeaders = new System.Windows.Forms.GroupBox();
            this.txtAdditionalHeaderValue3 = new System.Windows.Forms.TextBox();
            this.txtAdditionalHeader3 = new System.Windows.Forms.TextBox();
            this.txtAdditionalHeaderValue2 = new System.Windows.Forms.TextBox();
            this.chkAdditionalHeader3 = new System.Windows.Forms.CheckBox();
            this.txtAdditionalHeader2 = new System.Windows.Forms.TextBox();
            this.chkAdditionalHeader2 = new System.Windows.Forms.CheckBox();
            this.txtAdditionalHeaderValue1 = new System.Windows.Forms.TextBox();
            this.txtAdditionalHeader1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAdditionalHeader1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.MiscSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            this.LoggingGroup.SuspendLayout();
            this.grpAdditionalHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(869, 650);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(112, 35);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Location = new System.Drawing.Point(989, 649);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(112, 35);
            this.MyCancelButton.TabIndex = 5;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.MyCancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBypassProxyForLocalAddress);
            this.groupBox1.Controls.Add(this.rdoSpecifyProxySettings);
            this.groupBox1.Controls.Add(this.rdoDontOverrideProxySettings);
            this.groupBox1.Controls.Add(this.chkOverrideProxyCredentials);
            this.groupBox1.Controls.Add(this.txtProxyServerDomain);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblDomain);
            this.groupBox1.Controls.Add(this.txtProxyServerPassword);
            this.groupBox1.Controls.Add(this.txtProxyServerUserName);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtProxyServerPort);
            this.groupBox1.Controls.Add(this.lblProxyPort);
            this.groupBox1.Controls.Add(this.txtProxyServerName);
            this.groupBox1.Controls.Add(this.lblProxyServer);
            this.groupBox1.Location = new System.Drawing.Point(668, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(458, 387);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set WebProxy Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkBypassProxyForLocalAddress
            // 
            this.chkBypassProxyForLocalAddress.Location = new System.Drawing.Point(31, 196);
            this.chkBypassProxyForLocalAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBypassProxyForLocalAddress.Name = "chkBypassProxyForLocalAddress";
            this.chkBypassProxyForLocalAddress.Size = new System.Drawing.Size(402, 29);
            this.chkBypassProxyForLocalAddress.TabIndex = 6;
            this.chkBypassProxyForLocalAddress.Text = "BypassProxy For Local Address";
            this.chkBypassProxyForLocalAddress.UseVisualStyleBackColor = true;
            // 
            // rdoSpecifyProxySettings
            // 
            this.rdoSpecifyProxySettings.AutoSize = true;
            this.rdoSpecifyProxySettings.Location = new System.Drawing.Point(8, 77);
            this.rdoSpecifyProxySettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSpecifyProxySettings.Name = "rdoSpecifyProxySettings";
            this.rdoSpecifyProxySettings.Size = new System.Drawing.Size(191, 24);
            this.rdoSpecifyProxySettings.TabIndex = 1;
            this.rdoSpecifyProxySettings.Text = "Specify Proxy Settings";
            this.rdoSpecifyProxySettings.UseVisualStyleBackColor = true;
            this.rdoSpecifyProxySettings.CheckedChanged += new System.EventHandler(this.rdoSpecifyProxySettings_CheckedChanged);
            // 
            // rdoDontOverrideProxySettings
            // 
            this.rdoDontOverrideProxySettings.AutoSize = true;
            this.rdoDontOverrideProxySettings.Checked = true;
            this.rdoDontOverrideProxySettings.Location = new System.Drawing.Point(9, 43);
            this.rdoDontOverrideProxySettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoDontOverrideProxySettings.Name = "rdoDontOverrideProxySettings";
            this.rdoDontOverrideProxySettings.Size = new System.Drawing.Size(240, 24);
            this.rdoDontOverrideProxySettings.TabIndex = 0;
            this.rdoDontOverrideProxySettings.TabStop = true;
            this.rdoDontOverrideProxySettings.Text = "Don\'t Override Proxy Settings";
            this.rdoDontOverrideProxySettings.UseVisualStyleBackColor = true;
            this.rdoDontOverrideProxySettings.CheckedChanged += new System.EventHandler(this.rdoDontOverrideProxySettings_CheckedChanged);
            // 
            // chkOverrideProxyCredentials
            // 
            this.chkOverrideProxyCredentials.Location = new System.Drawing.Point(31, 244);
            this.chkOverrideProxyCredentials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOverrideProxyCredentials.Name = "chkOverrideProxyCredentials";
            this.chkOverrideProxyCredentials.Size = new System.Drawing.Size(402, 29);
            this.chkOverrideProxyCredentials.TabIndex = 7;
            this.chkOverrideProxyCredentials.Text = "Override Proxy Server Credentials";
            this.chkOverrideProxyCredentials.UseVisualStyleBackColor = true;
            this.chkOverrideProxyCredentials.CheckedChanged += new System.EventHandler(this.chkOverrideProxyCredentials_CheckedChanged);
            // 
            // txtProxyServerDomain
            // 
            this.txtProxyServerDomain.Enabled = false;
            this.txtProxyServerDomain.Location = new System.Drawing.Point(175, 352);
            this.txtProxyServerDomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProxyServerDomain.Name = "txtProxyServerDomain";
            this.txtProxyServerDomain.Size = new System.Drawing.Size(258, 26);
            this.txtProxyServerDomain.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(68, 322);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(68, 361);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(68, 20);
            this.lblDomain.TabIndex = 12;
            this.lblDomain.Text = "Domain:";
            // 
            // txtProxyServerPassword
            // 
            this.txtProxyServerPassword.Enabled = false;
            this.txtProxyServerPassword.Location = new System.Drawing.Point(175, 316);
            this.txtProxyServerPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProxyServerPassword.Name = "txtProxyServerPassword";
            this.txtProxyServerPassword.PasswordChar = '•';
            this.txtProxyServerPassword.Size = new System.Drawing.Size(258, 26);
            this.txtProxyServerPassword.TabIndex = 11;
            // 
            // txtProxyServerUserName
            // 
            this.txtProxyServerUserName.Enabled = false;
            this.txtProxyServerUserName.Location = new System.Drawing.Point(175, 282);
            this.txtProxyServerUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProxyServerUserName.Name = "txtProxyServerUserName";
            this.txtProxyServerUserName.Size = new System.Drawing.Size(258, 26);
            this.txtProxyServerUserName.TabIndex = 9;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(68, 282);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 20);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "User:";
            // 
            // txtProxyServerPort
            // 
            this.txtProxyServerPort.Location = new System.Drawing.Point(175, 153);
            this.txtProxyServerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProxyServerPort.Name = "txtProxyServerPort";
            this.txtProxyServerPort.Size = new System.Drawing.Size(258, 26);
            this.txtProxyServerPort.TabIndex = 5;
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.Location = new System.Drawing.Point(32, 153);
            this.lblProxyPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(116, 26);
            this.lblProxyPort.TabIndex = 4;
            this.lblProxyPort.Text = "Proxy Port:";
            // 
            // txtProxyServerName
            // 
            this.txtProxyServerName.Location = new System.Drawing.Point(175, 110);
            this.txtProxyServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProxyServerName.Name = "txtProxyServerName";
            this.txtProxyServerName.Size = new System.Drawing.Size(258, 26);
            this.txtProxyServerName.TabIndex = 3;
            this.txtProxyServerName.TextChanged += new System.EventHandler(this.txtProxyServerName_TextChanged);
            // 
            // lblProxyServer
            // 
            this.lblProxyServer.Location = new System.Drawing.Point(32, 110);
            this.lblProxyServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyServer.Name = "lblProxyServer";
            this.lblProxyServer.Size = new System.Drawing.Size(116, 26);
            this.lblProxyServer.TabIndex = 2;
            this.lblProxyServer.Text = "Proxy Server:";
            // 
            // MiscSettingsGroup
            // 
            this.MiscSettingsGroup.Controls.Add(this.textBox1);
            this.MiscSettingsGroup.Controls.Add(this.label2);
            this.MiscSettingsGroup.Controls.Add(this.cmboSelectedTimeZoneContextId);
            this.MiscSettingsGroup.Controls.Add(this.chkAddTimeZoneContext);
            this.MiscSettingsGroup.Controls.Add(this.cmboUserAgent);
            this.MiscSettingsGroup.Controls.Add(this.chkOverrideTimezone);
            this.MiscSettingsGroup.Controls.Add(this.PreAuthenticate);
            this.MiscSettingsGroup.Controls.Add(this.label1);
            this.MiscSettingsGroup.Controls.Add(this.chkOverrideTimeout);
            this.MiscSettingsGroup.Controls.Add(this.cmboSelectedTimeZoneId);
            this.MiscSettingsGroup.Controls.Add(this.label9);
            this.MiscSettingsGroup.Controls.Add(this.numericUpDownTimeout);
            this.MiscSettingsGroup.Controls.Add(this.EnableScpLookups);
            this.MiscSettingsGroup.Controls.Add(this.UserAgentLabel);
            this.MiscSettingsGroup.Controls.Add(this.EnableSslDetailCheck);
            this.MiscSettingsGroup.Controls.Add(this.DumpFolderText);
            this.MiscSettingsGroup.Controls.Add(this.AllowRedirectsCheck);
            this.MiscSettingsGroup.Controls.Add(this.FindItemText);
            this.MiscSettingsGroup.Controls.Add(this.OverrideSslCheck);
            this.MiscSettingsGroup.Controls.Add(this.FindFolderText);
            this.MiscSettingsGroup.Controls.Add(this.CalendarViewText);
            this.MiscSettingsGroup.Controls.Add(this.DumpFolderLabel);
            this.MiscSettingsGroup.Controls.Add(this.FindItemLabel);
            this.MiscSettingsGroup.Controls.Add(this.FindFolderLabel);
            this.MiscSettingsGroup.Controls.Add(this.CalendarViewLabel);
            this.MiscSettingsGroup.Location = new System.Drawing.Point(20, 14);
            this.MiscSettingsGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiscSettingsGroup.Name = "MiscSettingsGroup";
            this.MiscSettingsGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiscSettingsGroup.Size = new System.Drawing.Size(640, 580);
            this.MiscSettingsGroup.TabIndex = 0;
            this.MiscSettingsGroup.TabStop = false;
            this.MiscSettingsGroup.Text = "Miscellaneous";
            this.MiscSettingsGroup.Enter += new System.EventHandler(this.MiscSettingsGroup_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(46, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(587, 64);
            this.textBox1.TabIndex = 82;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 550);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "TimeZone:";
            // 
            // cmboSelectedTimeZoneContextId
            // 
            this.cmboSelectedTimeZoneContextId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSelectedTimeZoneContextId.Enabled = false;
            this.cmboSelectedTimeZoneContextId.FormattingEnabled = true;
            this.cmboSelectedTimeZoneContextId.Location = new System.Drawing.Point(147, 547);
            this.cmboSelectedTimeZoneContextId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboSelectedTimeZoneContextId.Name = "cmboSelectedTimeZoneContextId";
            this.cmboSelectedTimeZoneContextId.Size = new System.Drawing.Size(458, 28);
            this.cmboSelectedTimeZoneContextId.TabIndex = 80;
            this.cmboSelectedTimeZoneContextId.SelectedIndexChanged += new System.EventHandler(this.cmboSelectedTimeZoneContextId_SelectedIndexChanged);
            // 
            // chkAddTimeZoneContext
            // 
            this.chkAddTimeZoneContext.Location = new System.Drawing.Point(8, 517);
            this.chkAddTimeZoneContext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAddTimeZoneContext.Name = "chkAddTimeZoneContext";
            this.chkAddTimeZoneContext.Size = new System.Drawing.Size(627, 32);
            this.chkAddTimeZoneContext.TabIndex = 78;
            this.chkAddTimeZoneContext.Text = "Add TimeZoneContext (not added by default past Exchange2007_SP1).";
            this.chkAddTimeZoneContext.UseVisualStyleBackColor = true;
            this.chkAddTimeZoneContext.CheckedChanged += new System.EventHandler(this.chkAddTimeZoneContext_CheckedChanged);
            // 
            // cmboUserAgent
            // 
            this.cmboUserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboUserAgent.FormattingEnabled = true;
            this.cmboUserAgent.Location = new System.Drawing.Point(166, 25);
            this.cmboUserAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboUserAgent.Name = "cmboUserAgent";
            this.cmboUserAgent.Size = new System.Drawing.Size(461, 28);
            this.cmboUserAgent.TabIndex = 10;
            // 
            // chkOverrideTimezone
            // 
            this.chkOverrideTimezone.Location = new System.Drawing.Point(16, 456);
            this.chkOverrideTimezone.Margin = new System.Windows.Forms.Padding(0);
            this.chkOverrideTimezone.Name = "chkOverrideTimezone";
            this.chkOverrideTimezone.Size = new System.Drawing.Size(528, 26);
            this.chkOverrideTimezone.TabIndex = 17;
            this.chkOverrideTimezone.Text = "Use specified timezone:";
            this.chkOverrideTimezone.UseVisualStyleBackColor = true;
            this.chkOverrideTimezone.CheckedChanged += new System.EventHandler(this.chkOverrideTimezone_CheckedChanged);
            // 
            // PreAuthenticate
            // 
            this.PreAuthenticate.AutoSize = true;
            this.PreAuthenticate.Location = new System.Drawing.Point(16, 266);
            this.PreAuthenticate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreAuthenticate.Name = "PreAuthenticate";
            this.PreAuthenticate.Size = new System.Drawing.Size(265, 24);
            this.PreAuthenticate.TabIndex = 6;
            this.PreAuthenticate.Text = "Pre-Authenticate HTTP requests";
            this.PreAuthenticate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "TimeZone:";
            // 
            // chkOverrideTimeout
            // 
            this.chkOverrideTimeout.Location = new System.Drawing.Point(16, 295);
            this.chkOverrideTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOverrideTimeout.Name = "chkOverrideTimeout";
            this.chkOverrideTimeout.Size = new System.Drawing.Size(186, 27);
            this.chkOverrideTimeout.TabIndex = 7;
            this.chkOverrideTimeout.Text = "Override timeout:";
            this.chkOverrideTimeout.UseVisualStyleBackColor = true;
            // 
            // cmboSelectedTimeZoneId
            // 
            this.cmboSelectedTimeZoneId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSelectedTimeZoneId.Enabled = false;
            this.cmboSelectedTimeZoneId.FormattingEnabled = true;
            this.cmboSelectedTimeZoneId.Location = new System.Drawing.Point(147, 487);
            this.cmboSelectedTimeZoneId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboSelectedTimeZoneId.Name = "cmboSelectedTimeZoneId";
            this.cmboSelectedTimeZoneId.Size = new System.Drawing.Size(458, 28);
            this.cmboSelectedTimeZoneId.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 295);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Timeout milliseconds :";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Location = new System.Drawing.Point(380, 289);
            this.numericUpDownTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownTimeout.TabIndex = 8;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // EnableScpLookups
            // 
            this.EnableScpLookups.Location = new System.Drawing.Point(18, 157);
            this.EnableScpLookups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableScpLookups.Name = "EnableScpLookups";
            this.EnableScpLookups.Size = new System.Drawing.Size(622, 30);
            this.EnableScpLookups.TabIndex = 5;
            this.EnableScpLookups.Text = "Enable SCP Lookups (In-network Autodiscover)";
            this.EnableScpLookups.UseVisualStyleBackColor = true;
            this.EnableScpLookups.CheckedChanged += new System.EventHandler(this.EnableScpLookups_CheckedChanged);
            // 
            // UserAgentLabel
            // 
            this.UserAgentLabel.Location = new System.Drawing.Point(16, 28);
            this.UserAgentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserAgentLabel.Name = "UserAgentLabel";
            this.UserAgentLabel.Size = new System.Drawing.Size(142, 25);
            this.UserAgentLabel.TabIndex = 0;
            this.UserAgentLabel.Text = "UserAgent Value:";
            // 
            // EnableSslDetailCheck
            // 
            this.EnableSslDetailCheck.Location = new System.Drawing.Point(19, 91);
            this.EnableSslDetailCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableSslDetailCheck.Name = "EnableSslDetailCheck";
            this.EnableSslDetailCheck.Size = new System.Drawing.Size(346, 37);
            this.EnableSslDetailCheck.TabIndex = 3;
            this.EnableSslDetailCheck.Text = "Enable detailed SSL certificate log output";
            this.EnableSslDetailCheck.UseVisualStyleBackColor = true;
            // 
            // DumpFolderText
            // 
            this.DumpFolderText.Location = new System.Drawing.Point(215, 422);
            this.DumpFolderText.Margin = new System.Windows.Forms.Padding(0);
            this.DumpFolderText.Name = "DumpFolderText";
            this.DumpFolderText.Size = new System.Drawing.Size(148, 26);
            this.DumpFolderText.TabIndex = 16;
            this.DumpFolderText.TextChanged += new System.EventHandler(this.DumpFolderText_TextChanged);
            // 
            // AllowRedirectsCheck
            // 
            this.AllowRedirectsCheck.Location = new System.Drawing.Point(19, 124);
            this.AllowRedirectsCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllowRedirectsCheck.Name = "AllowRedirectsCheck";
            this.AllowRedirectsCheck.Size = new System.Drawing.Size(346, 34);
            this.AllowRedirectsCheck.TabIndex = 4;
            this.AllowRedirectsCheck.Text = "Allow Autodiscover redirects";
            this.AllowRedirectsCheck.UseVisualStyleBackColor = true;
            // 
            // FindItemText
            // 
            this.FindItemText.Location = new System.Drawing.Point(214, 386);
            this.FindItemText.Margin = new System.Windows.Forms.Padding(0);
            this.FindItemText.Name = "FindItemText";
            this.FindItemText.Size = new System.Drawing.Size(148, 26);
            this.FindItemText.TabIndex = 14;
            this.FindItemText.TextChanged += new System.EventHandler(this.FindItemText_TextChanged);
            // 
            // OverrideSslCheck
            // 
            this.OverrideSslCheck.Location = new System.Drawing.Point(17, 61);
            this.OverrideSslCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OverrideSslCheck.Name = "OverrideSslCheck";
            this.OverrideSslCheck.Size = new System.Drawing.Size(346, 37);
            this.OverrideSslCheck.TabIndex = 2;
            this.OverrideSslCheck.Text = "Override SSL certificate verification ";
            this.OverrideSslCheck.UseVisualStyleBackColor = true;
            this.OverrideSslCheck.CheckedChanged += new System.EventHandler(this.OverrideSslCheck_CheckedChanged);
            // 
            // FindFolderText
            // 
            this.FindFolderText.Location = new System.Drawing.Point(214, 356);
            this.FindFolderText.Margin = new System.Windows.Forms.Padding(0);
            this.FindFolderText.Name = "FindFolderText";
            this.FindFolderText.Size = new System.Drawing.Size(148, 26);
            this.FindFolderText.TabIndex = 12;
            this.FindFolderText.TextChanged += new System.EventHandler(this.FindFolderText_TextChanged);
            // 
            // CalendarViewText
            // 
            this.CalendarViewText.Location = new System.Drawing.Point(214, 325);
            this.CalendarViewText.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarViewText.Name = "CalendarViewText";
            this.CalendarViewText.Size = new System.Drawing.Size(148, 26);
            this.CalendarViewText.TabIndex = 10;
            this.CalendarViewText.TextChanged += new System.EventHandler(this.CalendarViewText_TextChanged);
            // 
            // DumpFolderLabel
            // 
            this.DumpFolderLabel.Location = new System.Drawing.Point(12, 425);
            this.DumpFolderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DumpFolderLabel.Name = "DumpFolderLabel";
            this.DumpFolderLabel.Size = new System.Drawing.Size(192, 26);
            this.DumpFolderLabel.TabIndex = 15;
            this.DumpFolderLabel.Text = "Dump Folder View Size:";
            this.DumpFolderLabel.Click += new System.EventHandler(this.DumpFolderLabel_Click);
            // 
            // FindItemLabel
            // 
            this.FindItemLabel.Location = new System.Drawing.Point(13, 396);
            this.FindItemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FindItemLabel.Name = "FindItemLabel";
            this.FindItemLabel.Size = new System.Drawing.Size(192, 26);
            this.FindItemLabel.TabIndex = 13;
            this.FindItemLabel.Text = "FindItem View Size:";
            this.FindItemLabel.Click += new System.EventHandler(this.FindItemLabel_Click);
            // 
            // FindFolderLabel
            // 
            this.FindFolderLabel.Location = new System.Drawing.Point(13, 365);
            this.FindFolderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FindFolderLabel.Name = "FindFolderLabel";
            this.FindFolderLabel.Size = new System.Drawing.Size(192, 26);
            this.FindFolderLabel.TabIndex = 11;
            this.FindFolderLabel.Text = "FindFolder View Size:";
            this.FindFolderLabel.Click += new System.EventHandler(this.FindFolderLabel_Click);
            // 
            // CalendarViewLabel
            // 
            this.CalendarViewLabel.Location = new System.Drawing.Point(13, 330);
            this.CalendarViewLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarViewLabel.Name = "CalendarViewLabel";
            this.CalendarViewLabel.Size = new System.Drawing.Size(192, 22);
            this.CalendarViewLabel.TabIndex = 9;
            this.CalendarViewLabel.Text = "CalendarView Size:";
            this.CalendarViewLabel.Click += new System.EventHandler(this.CalendarViewLabel_Click);
            // 
            // LoggingGroup
            // 
            this.LoggingGroup.Controls.Add(this.LogFilePathText);
            this.LoggingGroup.Controls.Add(this.LogFilePathLabel);
            this.LoggingGroup.Controls.Add(this.SaveLogFileCheck);
            this.LoggingGroup.Location = new System.Drawing.Point(20, 599);
            this.LoggingGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoggingGroup.Name = "LoggingGroup";
            this.LoggingGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoggingGroup.Size = new System.Drawing.Size(640, 90);
            this.LoggingGroup.TabIndex = 1;
            this.LoggingGroup.TabStop = false;
            this.LoggingGroup.Text = "Logging...";
            // 
            // LogFilePathText
            // 
            this.LogFilePathText.Location = new System.Drawing.Point(147, 57);
            this.LogFilePathText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogFilePathText.Name = "LogFilePathText";
            this.LogFilePathText.Size = new System.Drawing.Size(461, 26);
            this.LogFilePathText.TabIndex = 2;
            // 
            // LogFilePathLabel
            // 
            this.LogFilePathLabel.Location = new System.Drawing.Point(43, 60);
            this.LogFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogFilePathLabel.Name = "LogFilePathLabel";
            this.LogFilePathLabel.Size = new System.Drawing.Size(102, 26);
            this.LogFilePathLabel.TabIndex = 1;
            this.LogFilePathLabel.Text = "Log file path:";
            // 
            // SaveLogFileCheck
            // 
            this.SaveLogFileCheck.Location = new System.Drawing.Point(16, 21);
            this.SaveLogFileCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveLogFileCheck.Name = "SaveLogFileCheck";
            this.SaveLogFileCheck.Size = new System.Drawing.Size(242, 37);
            this.SaveLogFileCheck.TabIndex = 0;
            this.SaveLogFileCheck.Text = "Save logging output to a file";
            this.SaveLogFileCheck.UseVisualStyleBackColor = true;
            this.SaveLogFileCheck.CheckedChanged += new System.EventHandler(this.SaveLogFileCheck_CheckedChanged);
            // 
            // grpAdditionalHeaders
            // 
            this.grpAdditionalHeaders.Controls.Add(this.txtAdditionalHeaderValue3);
            this.grpAdditionalHeaders.Controls.Add(this.txtAdditionalHeader3);
            this.grpAdditionalHeaders.Controls.Add(this.txtAdditionalHeaderValue2);
            this.grpAdditionalHeaders.Controls.Add(this.chkAdditionalHeader3);
            this.grpAdditionalHeaders.Controls.Add(this.txtAdditionalHeader2);
            this.grpAdditionalHeaders.Controls.Add(this.chkAdditionalHeader2);
            this.grpAdditionalHeaders.Controls.Add(this.txtAdditionalHeaderValue1);
            this.grpAdditionalHeaders.Controls.Add(this.txtAdditionalHeader1);
            this.grpAdditionalHeaders.Controls.Add(this.label4);
            this.grpAdditionalHeaders.Controls.Add(this.label3);
            this.grpAdditionalHeaders.Controls.Add(this.chkAdditionalHeader1);
            this.grpAdditionalHeaders.Location = new System.Drawing.Point(668, 415);
            this.grpAdditionalHeaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAdditionalHeaders.Name = "grpAdditionalHeaders";
            this.grpAdditionalHeaders.Padding = new System.Windows.Forms.Padding(0);
            this.grpAdditionalHeaders.Size = new System.Drawing.Size(458, 180);
            this.grpAdditionalHeaders.TabIndex = 3;
            this.grpAdditionalHeaders.TabStop = false;
            this.grpAdditionalHeaders.Text = "Additional Headers";
            // 
            // txtAdditionalHeaderValue3
            // 
            this.txtAdditionalHeaderValue3.Enabled = false;
            this.txtAdditionalHeaderValue3.Location = new System.Drawing.Point(259, 137);
            this.txtAdditionalHeaderValue3.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdditionalHeaderValue3.Name = "txtAdditionalHeaderValue3";
            this.txtAdditionalHeaderValue3.Size = new System.Drawing.Size(182, 26);
            this.txtAdditionalHeaderValue3.TabIndex = 10;
            // 
            // txtAdditionalHeader3
            // 
            this.txtAdditionalHeader3.Enabled = false;
            this.txtAdditionalHeader3.Location = new System.Drawing.Point(39, 137);
            this.txtAdditionalHeader3.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdditionalHeader3.Name = "txtAdditionalHeader3";
            this.txtAdditionalHeader3.Size = new System.Drawing.Size(212, 26);
            this.txtAdditionalHeader3.TabIndex = 9;
            // 
            // txtAdditionalHeaderValue2
            // 
            this.txtAdditionalHeaderValue2.Enabled = false;
            this.txtAdditionalHeaderValue2.Location = new System.Drawing.Point(259, 97);
            this.txtAdditionalHeaderValue2.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdditionalHeaderValue2.Name = "txtAdditionalHeaderValue2";
            this.txtAdditionalHeaderValue2.Size = new System.Drawing.Size(182, 26);
            this.txtAdditionalHeaderValue2.TabIndex = 7;
            // 
            // chkAdditionalHeader3
            // 
            this.chkAdditionalHeader3.Location = new System.Drawing.Point(9, 133);
            this.chkAdditionalHeader3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAdditionalHeader3.Name = "chkAdditionalHeader3";
            this.chkAdditionalHeader3.Size = new System.Drawing.Size(21, 37);
            this.chkAdditionalHeader3.TabIndex = 8;
            this.chkAdditionalHeader3.UseVisualStyleBackColor = true;
            this.chkAdditionalHeader3.CheckedChanged += new System.EventHandler(this.chkAdditionalHeader3_CheckedChanged);
            // 
            // txtAdditionalHeader2
            // 
            this.txtAdditionalHeader2.Enabled = false;
            this.txtAdditionalHeader2.Location = new System.Drawing.Point(39, 97);
            this.txtAdditionalHeader2.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdditionalHeader2.Name = "txtAdditionalHeader2";
            this.txtAdditionalHeader2.Size = new System.Drawing.Size(212, 26);
            this.txtAdditionalHeader2.TabIndex = 6;
            // 
            // chkAdditionalHeader2
            // 
            this.chkAdditionalHeader2.Location = new System.Drawing.Point(10, 93);
            this.chkAdditionalHeader2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAdditionalHeader2.Name = "chkAdditionalHeader2";
            this.chkAdditionalHeader2.Size = new System.Drawing.Size(21, 37);
            this.chkAdditionalHeader2.TabIndex = 5;
            this.chkAdditionalHeader2.UseVisualStyleBackColor = true;
            this.chkAdditionalHeader2.CheckedChanged += new System.EventHandler(this.chkAdditionalHeader2_CheckedChanged);
            // 
            // txtAdditionalHeaderValue1
            // 
            this.txtAdditionalHeaderValue1.Enabled = false;
            this.txtAdditionalHeaderValue1.Location = new System.Drawing.Point(259, 58);
            this.txtAdditionalHeaderValue1.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdditionalHeaderValue1.Name = "txtAdditionalHeaderValue1";
            this.txtAdditionalHeaderValue1.Size = new System.Drawing.Size(182, 26);
            this.txtAdditionalHeaderValue1.TabIndex = 4;
            // 
            // txtAdditionalHeader1
            // 
            this.txtAdditionalHeader1.Enabled = false;
            this.txtAdditionalHeader1.Location = new System.Drawing.Point(39, 62);
            this.txtAdditionalHeader1.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdditionalHeader1.Name = "txtAdditionalHeader1";
            this.txtAdditionalHeader1.Size = new System.Drawing.Size(212, 26);
            this.txtAdditionalHeader1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Header";
            // 
            // chkAdditionalHeader1
            // 
            this.chkAdditionalHeader1.Location = new System.Drawing.Point(9, 58);
            this.chkAdditionalHeader1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAdditionalHeader1.Name = "chkAdditionalHeader1";
            this.chkAdditionalHeader1.Size = new System.Drawing.Size(21, 37);
            this.chkAdditionalHeader1.TabIndex = 2;
            this.chkAdditionalHeader1.UseVisualStyleBackColor = true;
            this.chkAdditionalHeader1.CheckedChanged += new System.EventHandler(this.chkAdditionalHeader1_CheckedChanged);
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.MyCancelButton;
            this.ClientSize = new System.Drawing.Size(1132, 698);
            this.Controls.Add(this.grpAdditionalHeaders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MyCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MiscSettingsGroup);
            this.Controls.Add(this.LoggingGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MiscSettingsGroup.ResumeLayout(false);
            this.MiscSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            this.LoggingGroup.ResumeLayout(false);
            this.LoggingGroup.PerformLayout();
            this.grpAdditionalHeaders.ResumeLayout(false);
            this.grpAdditionalHeaders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MiscSettingsGroup;
        private System.Windows.Forms.Label FindFolderLabel;
        private System.Windows.Forms.Label CalendarViewLabel;
        private System.Windows.Forms.Label FindItemLabel;
        private System.Windows.Forms.Label DumpFolderLabel;
        private System.Windows.Forms.TextBox DumpFolderText;
        private System.Windows.Forms.TextBox FindItemText;
        private System.Windows.Forms.TextBox FindFolderText;
        private System.Windows.Forms.TextBox CalendarViewText;
        private System.Windows.Forms.CheckBox OverrideSslCheck;
        private System.Windows.Forms.CheckBox AllowRedirectsCheck;
        private System.Windows.Forms.Button MyCancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.CheckBox EnableSslDetailCheck;
        private System.Windows.Forms.CheckBox SaveLogFileCheck;
        private System.Windows.Forms.Label LogFilePathLabel;
        private System.Windows.Forms.TextBox LogFilePathText;
        private System.Windows.Forms.GroupBox LoggingGroup;
        private System.Windows.Forms.Label UserAgentLabel;
        private System.Windows.Forms.CheckBox EnableScpLookups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.CheckBox chkOverrideTimeout;
        private System.Windows.Forms.CheckBox PreAuthenticate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboSelectedTimeZoneId;
        private System.Windows.Forms.CheckBox chkOverrideTimezone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProxyServerPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.TextBox txtProxyServerName;
        private System.Windows.Forms.Label lblProxyServer;
        private System.Windows.Forms.TextBox txtProxyServerDomain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtProxyServerPassword;
        private System.Windows.Forms.TextBox txtProxyServerUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox chkOverrideProxyCredentials;
        private System.Windows.Forms.RadioButton rdoSpecifyProxySettings;
        private System.Windows.Forms.RadioButton rdoDontOverrideProxySettings;
        private System.Windows.Forms.CheckBox chkBypassProxyForLocalAddress;
        private System.Windows.Forms.ComboBox cmboUserAgent;
        private System.Windows.Forms.CheckBox chkAddTimeZoneContext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboSelectedTimeZoneContextId;
        private System.Windows.Forms.GroupBox grpAdditionalHeaders;
        private System.Windows.Forms.TextBox txtAdditionalHeaderValue3;
        private System.Windows.Forms.TextBox txtAdditionalHeader3;
        private System.Windows.Forms.TextBox txtAdditionalHeaderValue2;
        private System.Windows.Forms.CheckBox chkAdditionalHeader3;
        private System.Windows.Forms.TextBox txtAdditionalHeader2;
        private System.Windows.Forms.CheckBox chkAdditionalHeader2;
        private System.Windows.Forms.TextBox txtAdditionalHeaderValue1;
        private System.Windows.Forms.TextBox txtAdditionalHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAdditionalHeader1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
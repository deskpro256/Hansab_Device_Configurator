namespace Hansab_slave_configurator
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Tab_control = new System.Windows.Forms.TabControl();
            this.Main_tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConfigDisableButton = new System.Windows.Forms.Button();
            this.ConfigEnableButton = new System.Windows.Forms.Button();
            this.Restart_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Device_list_label = new System.Windows.Forms.Label();
            this.ConDiscon_label = new System.Windows.Forms.Label();
            this.progressLED2 = new System.Windows.Forms.ProgressBar();
            this.Ping_button = new System.Windows.Forms.Button();
            this.PingProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConnectedDeviceList = new System.Windows.Forms.TreeView();
            this.progressLED = new System.Windows.Forms.ProgressBar();
            this.SerialPortBox = new System.Windows.Forms.GroupBox();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.Apply_button = new System.Windows.Forms.Button();
            this.COM_ports_box = new System.Windows.Forms.ComboBox();
            this.Disonnect_button = new System.Windows.Forms.Button();
            this.Connect_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Plugged_label = new System.Windows.Forms.Label();
            this.SystemStatus_label = new System.Windows.Forms.Label();
            this.config_tab = new System.Windows.Forms.TabPage();
            this.Current_cfg_label = new System.Windows.Forms.Label();
            this.Current_cfg_box = new System.Windows.Forms.RichTextBox();
            this.Load_new_config_box = new System.Windows.Forms.GroupBox();
            this.SendConfigButton = new System.Windows.Forms.Button();
            this.NewConfig_button = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.serial_tab = new System.Windows.Forms.TabPage();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Serial_data_label = new System.Windows.Forms.Label();
            this.Serialport_text_box = new System.Windows.Forms.RichTextBox();
            this.error_tab = new System.Windows.Forms.TabPage();
            this.ClearErrorsButton = new System.Windows.Forms.Button();
            this.GetErrors_button = new System.Windows.Forms.Button();
            this.Errors_label = new System.Windows.Forms.Label();
            this.current_errors = new System.Windows.Forms.RichTextBox();
            this.error_help_label = new System.Windows.Forms.Label();
            this.Error_help_box = new System.Windows.Forms.RichTextBox();
            this.help_tab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Floor4SendCount = new System.Windows.Forms.NumericUpDown();
            this.Floor3SendCount = new System.Windows.Forms.NumericUpDown();
            this.Floor2SendCount = new System.Windows.Forms.NumericUpDown();
            this.Floor1SendCount = new System.Windows.Forms.NumericUpDown();
            this.FloorCountSendButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.hansab_logo = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.NewUserText = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ChangeUserLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Serial_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequestCount_button = new System.Windows.Forms.Button();
            this.Tab_control.SuspendLayout();
            this.Main_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SerialPortBox.SuspendLayout();
            this.config_tab.SuspendLayout();
            this.Load_new_config_box.SuspendLayout();
            this.serial_tab.SuspendLayout();
            this.error_tab.SuspendLayout();
            this.help_tab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor4SendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor3SendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor2SendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor1SendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hansab_logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_control
            // 
            this.Tab_control.Controls.Add(this.Main_tab);
            this.Tab_control.Controls.Add(this.config_tab);
            this.Tab_control.Controls.Add(this.serial_tab);
            this.Tab_control.Controls.Add(this.error_tab);
            this.Tab_control.Controls.Add(this.help_tab);
            this.Tab_control.Location = new System.Drawing.Point(177, 12);
            this.Tab_control.Name = "Tab_control";
            this.Tab_control.SelectedIndex = 0;
            this.Tab_control.Size = new System.Drawing.Size(488, 537);
            this.Tab_control.TabIndex = 0;
            // 
            // Main_tab
            // 
            this.Main_tab.Controls.Add(this.groupBox2);
            this.Main_tab.Controls.Add(this.Device_list_label);
            this.Main_tab.Controls.Add(this.ConDiscon_label);
            this.Main_tab.Controls.Add(this.progressLED2);
            this.Main_tab.Controls.Add(this.Ping_button);
            this.Main_tab.Controls.Add(this.PingProgressBar);
            this.Main_tab.Controls.Add(this.ConnectedDeviceList);
            this.Main_tab.Controls.Add(this.progressLED);
            this.Main_tab.Controls.Add(this.SerialPortBox);
            this.Main_tab.Controls.Add(this.Plugged_label);
            this.Main_tab.Controls.Add(this.SystemStatus_label);
            this.Main_tab.Location = new System.Drawing.Point(4, 22);
            this.Main_tab.Name = "Main_tab";
            this.Main_tab.Size = new System.Drawing.Size(480, 511);
            this.Main_tab.TabIndex = 4;
            this.Main_tab.Text = "Main";
            this.Main_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConfigDisableButton);
            this.groupBox2.Controls.Add(this.ConfigEnableButton);
            this.groupBox2.Controls.Add(this.Restart_button);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(27, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 127);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration Options";
            // 
            // ConfigDisableButton
            // 
            this.ConfigDisableButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.ConfigDisableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfigDisableButton.Location = new System.Drawing.Point(118, 28);
            this.ConfigDisableButton.Name = "ConfigDisableButton";
            this.ConfigDisableButton.Size = new System.Drawing.Size(75, 23);
            this.ConfigDisableButton.TabIndex = 11;
            this.ConfigDisableButton.Text = "ConfigDis";
            this.ConfigDisableButton.UseVisualStyleBackColor = false;
            this.ConfigDisableButton.Click += new System.EventHandler(this.ConfigDisableButton_Click);
            // 
            // ConfigEnableButton
            // 
            this.ConfigEnableButton.Location = new System.Drawing.Point(37, 28);
            this.ConfigEnableButton.Name = "ConfigEnableButton";
            this.ConfigEnableButton.Size = new System.Drawing.Size(75, 23);
            this.ConfigEnableButton.TabIndex = 10;
            this.ConfigEnableButton.Text = "ConfigEn";
            this.ConfigEnableButton.UseVisualStyleBackColor = false;
            this.ConfigEnableButton.Click += new System.EventHandler(this.ConfigEnableButton_Click);
            // 
            // Restart_button
            // 
            this.Restart_button.Enabled = false;
            this.Restart_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Restart_button.Location = new System.Drawing.Point(74, 85);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(75, 23);
            this.Restart_button.TabIndex = 4;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(60, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "System Restart";
            // 
            // Device_list_label
            // 
            this.Device_list_label.AutoSize = true;
            this.Device_list_label.Location = new System.Drawing.Point(283, 40);
            this.Device_list_label.Name = "Device_list_label";
            this.Device_list_label.Size = new System.Drawing.Size(59, 13);
            this.Device_list_label.TabIndex = 23;
            this.Device_list_label.Text = "Device list:";
            // 
            // ConDiscon_label
            // 
            this.ConDiscon_label.AutoSize = true;
            this.ConDiscon_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ConDiscon_label.Location = new System.Drawing.Point(183, 27);
            this.ConDiscon_label.Name = "ConDiscon_label";
            this.ConDiscon_label.Size = new System.Drawing.Size(73, 13);
            this.ConDiscon_label.TabIndex = 22;
            this.ConDiscon_label.Text = "Disconnected";
            // 
            // progressLED2
            // 
            this.progressLED2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressLED2.Location = new System.Drawing.Point(153, 28);
            this.progressLED2.Name = "progressLED2";
            this.progressLED2.Size = new System.Drawing.Size(24, 12);
            this.progressLED2.TabIndex = 21;
            // 
            // Ping_button
            // 
            this.Ping_button.Location = new System.Drawing.Point(285, 8);
            this.Ping_button.Name = "Ping_button";
            this.Ping_button.Size = new System.Drawing.Size(81, 23);
            this.Ping_button.TabIndex = 15;
            this.Ping_button.Text = "Ping devices";
            this.Ping_button.UseVisualStyleBackColor = true;
            this.Ping_button.Click += new System.EventHandler(this.Ping_button_Click);
            // 
            // PingProgressBar
            // 
            this.PingProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PingProgressBar.Location = new System.Drawing.Point(371, 10);
            this.PingProgressBar.MarqueeAnimationSpeed = 200;
            this.PingProgressBar.Name = "PingProgressBar";
            this.PingProgressBar.Size = new System.Drawing.Size(75, 20);
            this.PingProgressBar.TabIndex = 20;
            // 
            // ConnectedDeviceList
            // 
            this.ConnectedDeviceList.CheckBoxes = true;
            this.ConnectedDeviceList.HideSelection = false;
            this.ConnectedDeviceList.Location = new System.Drawing.Point(286, 61);
            this.ConnectedDeviceList.Name = "ConnectedDeviceList";
            this.ConnectedDeviceList.Size = new System.Drawing.Size(163, 285);
            this.ConnectedDeviceList.TabIndex = 19;
            // 
            // progressLED
            // 
            this.progressLED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressLED.Location = new System.Drawing.Point(153, 15);
            this.progressLED.Name = "progressLED";
            this.progressLED.Size = new System.Drawing.Size(24, 12);
            this.progressLED.TabIndex = 6;
            // 
            // SerialPortBox
            // 
            this.SerialPortBox.Controls.Add(this.Refresh_button);
            this.SerialPortBox.Controls.Add(this.Apply_button);
            this.SerialPortBox.Controls.Add(this.COM_ports_box);
            this.SerialPortBox.Controls.Add(this.Disonnect_button);
            this.SerialPortBox.Controls.Add(this.Connect_button);
            this.SerialPortBox.Controls.Add(this.label9);
            this.SerialPortBox.Location = new System.Drawing.Point(27, 65);
            this.SerialPortBox.Name = "SerialPortBox";
            this.SerialPortBox.Size = new System.Drawing.Size(229, 147);
            this.SerialPortBox.TabIndex = 5;
            this.SerialPortBox.TabStop = false;
            this.SerialPortBox.Text = "Connection Settings";
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(86, 26);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(58, 23);
            this.Refresh_button.TabIndex = 14;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // Apply_button
            // 
            this.Apply_button.Location = new System.Drawing.Point(159, 63);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(42, 24);
            this.Apply_button.TabIndex = 13;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = true;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // COM_ports_box
            // 
            this.COM_ports_box.FormattingEnabled = true;
            this.COM_ports_box.Location = new System.Drawing.Point(74, 65);
            this.COM_ports_box.Name = "COM_ports_box";
            this.COM_ports_box.Size = new System.Drawing.Size(79, 21);
            this.COM_ports_box.TabIndex = 5;
            this.COM_ports_box.SelectedIndexChanged += new System.EventHandler(this.COM_ports_box_SelectedIndexChanged);
            // 
            // Disonnect_button
            // 
            this.Disonnect_button.Location = new System.Drawing.Point(118, 102);
            this.Disonnect_button.Name = "Disonnect_button";
            this.Disonnect_button.Size = new System.Drawing.Size(75, 23);
            this.Disonnect_button.TabIndex = 2;
            this.Disonnect_button.Text = "Disconnect";
            this.Disonnect_button.UseVisualStyleBackColor = true;
            this.Disonnect_button.Click += new System.EventHandler(this.Disonnect_button_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(37, 102);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(75, 23);
            this.Connect_button.TabIndex = 1;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Port Name:";
            // 
            // Plugged_label
            // 
            this.Plugged_label.AutoSize = true;
            this.Plugged_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Plugged_label.Location = new System.Drawing.Point(183, 14);
            this.Plugged_label.Name = "Plugged_label";
            this.Plugged_label.Size = new System.Drawing.Size(78, 13);
            this.Plugged_label.TabIndex = 2;
            this.Plugged_label.Text = "Not Plugged In";
            // 
            // SystemStatus_label
            // 
            this.SystemStatus_label.AutoSize = true;
            this.SystemStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SystemStatus_label.Location = new System.Drawing.Point(23, 14);
            this.SystemStatus_label.Name = "SystemStatus_label";
            this.SystemStatus_label.Size = new System.Drawing.Size(128, 24);
            this.SystemStatus_label.TabIndex = 1;
            this.SystemStatus_label.Text = "System status:";
            // 
            // config_tab
            // 
            this.config_tab.Controls.Add(this.Current_cfg_label);
            this.config_tab.Controls.Add(this.Current_cfg_box);
            this.config_tab.Controls.Add(this.Load_new_config_box);
            this.config_tab.Location = new System.Drawing.Point(4, 22);
            this.config_tab.Name = "config_tab";
            this.config_tab.Padding = new System.Windows.Forms.Padding(3);
            this.config_tab.Size = new System.Drawing.Size(480, 511);
            this.config_tab.TabIndex = 0;
            this.config_tab.Text = "Configuration";
            this.config_tab.UseVisualStyleBackColor = true;
            // 
            // Current_cfg_label
            // 
            this.Current_cfg_label.AutoSize = true;
            this.Current_cfg_label.Location = new System.Drawing.Point(20, 98);
            this.Current_cfg_label.Name = "Current_cfg_label";
            this.Current_cfg_label.Size = new System.Drawing.Size(108, 13);
            this.Current_cfg_label.TabIndex = 4;
            this.Current_cfg_label.Text = "Current configuration:";
            // 
            // Current_cfg_box
            // 
            this.Current_cfg_box.Location = new System.Drawing.Point(17, 114);
            this.Current_cfg_box.Name = "Current_cfg_box";
            this.Current_cfg_box.ReadOnly = true;
            this.Current_cfg_box.Size = new System.Drawing.Size(444, 376);
            this.Current_cfg_box.TabIndex = 3;
            this.Current_cfg_box.Text = "Load a configuration file to view it here";
            // 
            // Load_new_config_box
            // 
            this.Load_new_config_box.Controls.Add(this.SendConfigButton);
            this.Load_new_config_box.Controls.Add(this.NewConfig_button);
            this.Load_new_config_box.Controls.Add(this.Load_button);
            this.Load_new_config_box.Location = new System.Drawing.Point(17, 12);
            this.Load_new_config_box.Name = "Load_new_config_box";
            this.Load_new_config_box.Size = new System.Drawing.Size(253, 60);
            this.Load_new_config_box.TabIndex = 2;
            this.Load_new_config_box.TabStop = false;
            this.Load_new_config_box.Text = "Load/New Configuration file";
            // 
            // SendConfigButton
            // 
            this.SendConfigButton.Location = new System.Drawing.Point(168, 24);
            this.SendConfigButton.Name = "SendConfigButton";
            this.SendConfigButton.Size = new System.Drawing.Size(75, 23);
            this.SendConfigButton.TabIndex = 3;
            this.SendConfigButton.Text = "Send";
            this.SendConfigButton.UseVisualStyleBackColor = true;
            this.SendConfigButton.Click += new System.EventHandler(this.SendConfigButton_Click);
            // 
            // NewConfig_button
            // 
            this.NewConfig_button.Location = new System.Drawing.Point(87, 24);
            this.NewConfig_button.Name = "NewConfig_button";
            this.NewConfig_button.Size = new System.Drawing.Size(75, 23);
            this.NewConfig_button.TabIndex = 2;
            this.NewConfig_button.Text = "New";
            this.NewConfig_button.UseVisualStyleBackColor = true;
            this.NewConfig_button.Click += new System.EventHandler(this.NewConfig_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(6, 24);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(75, 23);
            this.Load_button.TabIndex = 0;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // serial_tab
            // 
            this.serial_tab.Controls.Add(this.ClearButton);
            this.serial_tab.Controls.Add(this.Serial_data_label);
            this.serial_tab.Controls.Add(this.Serialport_text_box);
            this.serial_tab.Location = new System.Drawing.Point(4, 22);
            this.serial_tab.Name = "serial_tab";
            this.serial_tab.Padding = new System.Windows.Forms.Padding(3);
            this.serial_tab.Size = new System.Drawing.Size(480, 511);
            this.serial_tab.TabIndex = 1;
            this.serial_tab.Text = "Log";
            this.serial_tab.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(375, 482);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Serial_data_label
            // 
            this.Serial_data_label.AutoSize = true;
            this.Serial_data_label.Location = new System.Drawing.Point(24, 19);
            this.Serial_data_label.Name = "Serial_data_label";
            this.Serial_data_label.Size = new System.Drawing.Size(62, 13);
            this.Serial_data_label.TabIndex = 4;
            this.Serial_data_label.Text = "Serial Data:";
            // 
            // Serialport_text_box
            // 
            this.Serialport_text_box.Location = new System.Drawing.Point(27, 35);
            this.Serialport_text_box.Name = "Serialport_text_box";
            this.Serialport_text_box.ReadOnly = true;
            this.Serialport_text_box.Size = new System.Drawing.Size(423, 441);
            this.Serialport_text_box.TabIndex = 3;
            this.Serialport_text_box.Text = "";
            // 
            // error_tab
            // 
            this.error_tab.Controls.Add(this.ClearErrorsButton);
            this.error_tab.Controls.Add(this.GetErrors_button);
            this.error_tab.Controls.Add(this.Errors_label);
            this.error_tab.Controls.Add(this.current_errors);
            this.error_tab.Controls.Add(this.error_help_label);
            this.error_tab.Controls.Add(this.Error_help_box);
            this.error_tab.Location = new System.Drawing.Point(4, 22);
            this.error_tab.Name = "error_tab";
            this.error_tab.Padding = new System.Windows.Forms.Padding(3);
            this.error_tab.Size = new System.Drawing.Size(480, 511);
            this.error_tab.TabIndex = 2;
            this.error_tab.Text = "Errors";
            this.error_tab.UseVisualStyleBackColor = true;
            // 
            // ClearErrorsButton
            // 
            this.ClearErrorsButton.Location = new System.Drawing.Point(233, 10);
            this.ClearErrorsButton.Name = "ClearErrorsButton";
            this.ClearErrorsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearErrorsButton.TabIndex = 5;
            this.ClearErrorsButton.Text = "Clear Errors";
            this.ClearErrorsButton.UseVisualStyleBackColor = true;
            this.ClearErrorsButton.Click += new System.EventHandler(this.ClearErrorsButton_Click);
            // 
            // GetErrors_button
            // 
            this.GetErrors_button.Location = new System.Drawing.Point(130, 10);
            this.GetErrors_button.Name = "GetErrors_button";
            this.GetErrors_button.Size = new System.Drawing.Size(75, 23);
            this.GetErrors_button.TabIndex = 4;
            this.GetErrors_button.Text = "Get Errors";
            this.GetErrors_button.UseVisualStyleBackColor = true;
            this.GetErrors_button.Click += new System.EventHandler(this.GetErrors_button_Click);
            // 
            // Errors_label
            // 
            this.Errors_label.AutoSize = true;
            this.Errors_label.Location = new System.Drawing.Point(12, 17);
            this.Errors_label.Name = "Errors_label";
            this.Errors_label.Size = new System.Drawing.Size(73, 13);
            this.Errors_label.TabIndex = 3;
            this.Errors_label.Text = "Current errors:";
            // 
            // current_errors
            // 
            this.current_errors.Enabled = false;
            this.current_errors.Location = new System.Drawing.Point(15, 38);
            this.current_errors.Name = "current_errors";
            this.current_errors.Size = new System.Drawing.Size(450, 286);
            this.current_errors.TabIndex = 2;
            this.current_errors.Text = "None! All good! :)";
            // 
            // error_help_label
            // 
            this.error_help_label.AutoSize = true;
            this.error_help_label.Location = new System.Drawing.Point(12, 332);
            this.error_help_label.Name = "error_help_label";
            this.error_help_label.Size = new System.Drawing.Size(95, 13);
            this.error_help_label.TabIndex = 1;
            this.error_help_label.Text = "List of Error codes:";
            // 
            // Error_help_box
            // 
            this.Error_help_box.Enabled = false;
            this.Error_help_box.Location = new System.Drawing.Point(15, 363);
            this.Error_help_box.Name = "Error_help_box";
            this.Error_help_box.Size = new System.Drawing.Size(450, 136);
            this.Error_help_box.TabIndex = 0;
            this.Error_help_box.Text = resources.GetString("Error_help_box.Text");
            // 
            // help_tab
            // 
            this.help_tab.Controls.Add(this.richTextBox1);
            this.help_tab.Location = new System.Drawing.Point(4, 22);
            this.help_tab.Name = "help_tab";
            this.help_tab.Padding = new System.Windows.Forms.Padding(3);
            this.help_tab.Size = new System.Drawing.Size(480, 511);
            this.help_tab.TabIndex = 3;
            this.help_tab.Text = "Help";
            this.help_tab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(6, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(468, 485);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Floor4SendCount);
            this.groupBox3.Controls.Add(this.Floor3SendCount);
            this.groupBox3.Controls.Add(this.Floor2SendCount);
            this.groupBox3.Controls.Add(this.Floor1SendCount);
            this.groupBox3.Controls.Add(this.FloorCountSendButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 176);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send count to display";
            // 
            // Floor4SendCount
            // 
            this.Floor4SendCount.Location = new System.Drawing.Point(72, 108);
            this.Floor4SendCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Floor4SendCount.Name = "Floor4SendCount";
            this.Floor4SendCount.Size = new System.Drawing.Size(68, 20);
            this.Floor4SendCount.TabIndex = 28;
            this.Floor4SendCount.ValueChanged += new System.EventHandler(this.Floor4SendCount_ValueChanged);
            // 
            // Floor3SendCount
            // 
            this.Floor3SendCount.Location = new System.Drawing.Point(72, 82);
            this.Floor3SendCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Floor3SendCount.Name = "Floor3SendCount";
            this.Floor3SendCount.Size = new System.Drawing.Size(68, 20);
            this.Floor3SendCount.TabIndex = 27;
            this.Floor3SendCount.ValueChanged += new System.EventHandler(this.Floor3SendCount_ValueChanged);
            // 
            // Floor2SendCount
            // 
            this.Floor2SendCount.Location = new System.Drawing.Point(72, 56);
            this.Floor2SendCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Floor2SendCount.Name = "Floor2SendCount";
            this.Floor2SendCount.Size = new System.Drawing.Size(68, 20);
            this.Floor2SendCount.TabIndex = 26;
            this.Floor2SendCount.ValueChanged += new System.EventHandler(this.Floor2SendCount_ValueChanged);
            // 
            // Floor1SendCount
            // 
            this.Floor1SendCount.Location = new System.Drawing.Point(72, 30);
            this.Floor1SendCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Floor1SendCount.Name = "Floor1SendCount";
            this.Floor1SendCount.Size = new System.Drawing.Size(68, 20);
            this.Floor1SendCount.TabIndex = 25;
            this.Floor1SendCount.ValueChanged += new System.EventHandler(this.Floor1SendCount_ValueChanged);
            // 
            // FloorCountSendButton
            // 
            this.FloorCountSendButton.Location = new System.Drawing.Point(54, 140);
            this.FloorCountSendButton.Name = "FloorCountSendButton";
            this.FloorCountSendButton.Size = new System.Drawing.Size(52, 23);
            this.FloorCountSendButton.TabIndex = 8;
            this.FloorCountSendButton.Text = "SEND!";
            this.FloorCountSendButton.UseVisualStyleBackColor = true;
            this.FloorCountSendButton.Click += new System.EventHandler(this.FloorCountSendButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Floor 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Floor 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Floor 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floor 1";
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UserType.ForeColor = System.Drawing.Color.Crimson;
            this.UserType.Location = new System.Drawing.Point(28, 9);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(128, 42);
            this.UserType.TabIndex = 1;
            this.UserType.Text = "Admin";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // hansab_logo
            // 
            this.hansab_logo.Image = ((System.Drawing.Image)(resources.GetObject("hansab_logo.Image")));
            this.hansab_logo.Location = new System.Drawing.Point(8, 474);
            this.hansab_logo.Name = "hansab_logo";
            this.hansab_logo.Size = new System.Drawing.Size(163, 50);
            this.hansab_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hansab_logo.TabIndex = 2;
            this.hansab_logo.TabStop = false;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.DefaultExt = "dat";
            this.OpenFileDialog1.FileName = "Configuration_file.dat";
            this.OpenFileDialog1.Filter = "\"Data files (*.dat)|*.dat|All files (*.*)|*.*\"";
            this.OpenFileDialog1.Title = "\"Open data file\"";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Version 1.0.0";
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(44, 68);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(75, 23);
            this.NewUserButton.TabIndex = 4;
            this.NewUserButton.Text = "Add";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // NewUserText
            // 
            this.NewUserText.AutoSize = true;
            this.NewUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NewUserText.Location = new System.Drawing.Point(43, 52);
            this.NewUserText.Name = "NewUserText";
            this.NewUserText.Size = new System.Drawing.Size(76, 13);
            this.NewUserText.TabIndex = 5;
            this.NewUserText.Text = "Add New User";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(46, 123);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(73, 23);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ChangeUserLabel
            // 
            this.ChangeUserLabel.AutoSize = true;
            this.ChangeUserLabel.Location = new System.Drawing.Point(50, 105);
            this.ChangeUserLabel.Name = "ChangeUserLabel";
            this.ChangeUserLabel.Size = new System.Drawing.Size(69, 13);
            this.ChangeUserLabel.TabIndex = 7;
            this.ChangeUserLabel.Text = "Change User";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UsernameLabel.Location = new System.Drawing.Point(35, 14);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(95, 24);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "username";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Serial_timer
            // 
            this.Serial_timer.Enabled = true;
            this.Serial_timer.Interval = 10;
            this.Serial_timer.Tick += new System.EventHandler(this.Serial_timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewUserButton);
            this.groupBox1.Controls.Add(this.UsernameLabel);
            this.groupBox1.Controls.Add(this.NewUserText);
            this.groupBox1.Controls.Add(this.ChangeUserLabel);
            this.groupBox1.Controls.Add(this.LogOutButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 167);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // RequestCount_button
            // 
            this.RequestCount_button.Location = new System.Drawing.Point(29, 246);
            this.RequestCount_button.Name = "RequestCount_button";
            this.RequestCount_button.Size = new System.Drawing.Size(127, 23);
            this.RequestCount_button.TabIndex = 28;
            this.RequestCount_button.Text = "Request count";
            this.RequestCount_button.UseVisualStyleBackColor = true;
            this.RequestCount_button.Click += new System.EventHandler(this.RequestCount_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RequestCount_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hansab_logo);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.Tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hansab configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tab_control.ResumeLayout(false);
            this.Main_tab.ResumeLayout(false);
            this.Main_tab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SerialPortBox.ResumeLayout(false);
            this.SerialPortBox.PerformLayout();
            this.config_tab.ResumeLayout(false);
            this.config_tab.PerformLayout();
            this.Load_new_config_box.ResumeLayout(false);
            this.serial_tab.ResumeLayout(false);
            this.serial_tab.PerformLayout();
            this.error_tab.ResumeLayout(false);
            this.error_tab.PerformLayout();
            this.help_tab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor4SendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor3SendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor2SendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Floor1SendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hansab_logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_control;
        private System.Windows.Forms.TabPage config_tab;
        private System.Windows.Forms.TabPage serial_tab;
        private System.Windows.Forms.Label UserType;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage error_tab;
        private System.Windows.Forms.TabPage help_tab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Errors_label;
        private System.Windows.Forms.RichTextBox current_errors;
        private System.Windows.Forms.Label error_help_label;
        private System.Windows.Forms.RichTextBox Error_help_box;
        private System.Windows.Forms.RichTextBox Serialport_text_box;
        private System.Windows.Forms.Label Serial_data_label;
        private System.Windows.Forms.TabPage Main_tab;
        private System.Windows.Forms.GroupBox Load_new_config_box;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.PictureBox hansab_logo;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Label Current_cfg_label;
        private System.Windows.Forms.RichTextBox Current_cfg_box;
        private System.Windows.Forms.Button NewConfig_button;
        private System.Windows.Forms.Label Plugged_label;
        private System.Windows.Forms.Label SystemStatus_label;
        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox SerialPortBox;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Button Apply_button;
        private System.Windows.Forms.ComboBox COM_ports_box;
        private System.Windows.Forms.Button Disonnect_button;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Label NewUserText;
        private System.Windows.Forms.ProgressBar progressLED;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label ChangeUserLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ConfigEnableButton;
        private System.Windows.Forms.Button ConfigDisableButton;
        private System.Windows.Forms.Timer Serial_timer;
        private System.Windows.Forms.TreeView ConnectedDeviceList;
        private System.Windows.Forms.Button Ping_button;
        private System.Windows.Forms.Label ConDiscon_label;
        private System.Windows.Forms.ProgressBar progressLED2;
        private System.Windows.Forms.ProgressBar PingProgressBar;
        private System.Windows.Forms.Label Device_list_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RequestCount_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetErrors_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FloorCountSendButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Floor1SendCount;
        private System.Windows.Forms.NumericUpDown Floor4SendCount;
        private System.Windows.Forms.NumericUpDown Floor3SendCount;
        private System.Windows.Forms.NumericUpDown Floor2SendCount;
        private System.Windows.Forms.Button SendConfigButton;
        private System.Windows.Forms.Button ClearErrorsButton;
    }
}
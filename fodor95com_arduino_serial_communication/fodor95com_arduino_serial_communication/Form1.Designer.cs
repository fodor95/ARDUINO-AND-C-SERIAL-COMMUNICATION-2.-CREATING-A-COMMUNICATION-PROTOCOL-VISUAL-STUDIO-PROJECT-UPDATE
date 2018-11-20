namespace fodor95com_arduino_serial_communication
{
    partial class fodor95com_arduino_serial_connection
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
            this.scanButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.updateStartButton = new System.Windows.Forms.Button();
            this.updateStopButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.updateNowButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.updateDataTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.frameStats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.correctFramesLabel = new System.Windows.Forms.Label();
            this.errorFramesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(12, 46);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(114, 51);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 103);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(114, 51);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // updateStartButton
            // 
            this.updateStartButton.Location = new System.Drawing.Point(150, 46);
            this.updateStartButton.Name = "updateStartButton";
            this.updateStartButton.Size = new System.Drawing.Size(114, 51);
            this.updateStartButton.TabIndex = 2;
            this.updateStartButton.Text = "update start";
            this.updateStartButton.UseVisualStyleBackColor = true;
            this.updateStartButton.Click += new System.EventHandler(this.updateStartButton_Click);
            // 
            // updateStopButton
            // 
            this.updateStopButton.Location = new System.Drawing.Point(270, 46);
            this.updateStopButton.Name = "updateStopButton";
            this.updateStopButton.Size = new System.Drawing.Size(114, 51);
            this.updateStopButton.TabIndex = 3;
            this.updateStopButton.Text = "update stop";
            this.updateStopButton.UseVisualStyleBackColor = true;
            this.updateStopButton.Click += new System.EventHandler(this.updateStopButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(12, 160);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(114, 51);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // updateNowButton
            // 
            this.updateNowButton.Location = new System.Drawing.Point(150, 103);
            this.updateNowButton.Name = "updateNowButton";
            this.updateNowButton.Size = new System.Drawing.Size(114, 51);
            this.updateNowButton.TabIndex = 5;
            this.updateNowButton.Text = "update now";
            this.updateNowButton.UseVisualStyleBackColor = true;
            this.updateNowButton.Click += new System.EventHandler(this.updateNowButton_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(12, 12);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(114, 28);
            this.portComboBox.TabIndex = 6;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 26);
            this.textBox1.TabIndex = 7;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 345600;
            this.serialPort1.ReadBufferSize = 9096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // updateDataTimer
            // 
            this.updateDataTimer.Interval = 1;
            this.updateDataTimer.Tick += new System.EventHandler(this.updateDataTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data from Arduino";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 26);
            this.textBox2.TabIndex = 9;
            // 
            // frameStats
            // 
            this.frameStats.AutoSize = true;
            this.frameStats.Location = new System.Drawing.Point(12, 226);
            this.frameStats.Name = "frameStats";
            this.frameStats.Size = new System.Drawing.Size(121, 20);
            this.frameStats.TabIndex = 10;
            this.frameStats.Text = "Frame statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Correct:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Error:";
            // 
            // correctFramesLabel
            // 
            this.correctFramesLabel.AutoSize = true;
            this.correctFramesLabel.Location = new System.Drawing.Point(85, 254);
            this.correctFramesLabel.Name = "correctFramesLabel";
            this.correctFramesLabel.Size = new System.Drawing.Size(18, 20);
            this.correctFramesLabel.TabIndex = 13;
            this.correctFramesLabel.Text = "0";
            // 
            // errorFramesLabel
            // 
            this.errorFramesLabel.AutoSize = true;
            this.errorFramesLabel.Location = new System.Drawing.Point(85, 274);
            this.errorFramesLabel.Name = "errorFramesLabel";
            this.errorFramesLabel.Size = new System.Drawing.Size(18, 20);
            this.errorFramesLabel.TabIndex = 14;
            this.errorFramesLabel.Text = "0";
            // 
            // fodor95com_arduino_serial_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 348);
            this.Controls.Add(this.errorFramesLabel);
            this.Controls.Add(this.correctFramesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frameStats);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.updateNowButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.updateStopButton);
            this.Controls.Add(this.updateStartButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.scanButton);
            this.Name = "fodor95com_arduino_serial_connection";
            this.Text = "fodor95com_arduino_serial_connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button updateStartButton;
        private System.Windows.Forms.Button updateStopButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button updateNowButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer updateDataTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label frameStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label correctFramesLabel;
        private System.Windows.Forms.Label errorFramesLabel;
    }
}


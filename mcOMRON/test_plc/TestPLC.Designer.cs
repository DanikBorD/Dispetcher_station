namespace test_plc
{
	partial class TestPLC
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.left_panel = new System.Windows.Forms.Panel();
            this.groupDMs = new System.Windows.Forms.GroupBox();
            this.bt_clear_dms = new System.Windows.Forms.Button();
            this.bt_read_dms = new System.Windows.Forms.Button();
            this.dms_count = new System.Windows.Forms.TextBox();
            this.dms_position = new System.Windows.Forms.TextBox();
            this.groupDM = new System.Windows.Forms.GroupBox();
            this.bt_write_dm = new System.Windows.Forms.Button();
            this.bt_read_dm = new System.Windows.Forms.Button();
            this.dm_value = new System.Windows.Forms.TextBox();
            this.dm_position = new System.Windows.Forms.TextBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_connection_data_read = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.right_panel = new System.Windows.Forms.Panel();
            this.groupDialogText = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dialog = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.left_panel.SuspendLayout();
            this.groupDMs.SuspendLayout();
            this.groupDM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.groupDialogText.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(115, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Count:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 15);
            label6.TabIndex = 8;
            label6.Text = "Position:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "I.P.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(115, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Value:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(115, 29);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 15);
            label7.TabIndex = 10;
            label7.Text = "Value:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 29);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 15);
            label8.TabIndex = 8;
            label8.Text = "Position:";
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.groupDMs);
            this.left_panel.Controls.Add(this.groupDM);
            this.left_panel.Controls.Add(this.bt_exit);
            this.left_panel.Controls.Add(this.groupBox1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Padding = new System.Windows.Forms.Padding(5);
            this.left_panel.Size = new System.Drawing.Size(214, 482);
            this.left_panel.TabIndex = 15;
            // 
            // groupDMs
            // 
            this.groupDMs.Controls.Add(this.bt_clear_dms);
            this.groupDMs.Controls.Add(this.bt_read_dms);
            this.groupDMs.Controls.Add(this.dms_count);
            this.groupDMs.Controls.Add(label5);
            this.groupDMs.Controls.Add(this.dms_position);
            this.groupDMs.Controls.Add(label6);
            this.groupDMs.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDMs.Enabled = false;
            this.groupDMs.Location = new System.Drawing.Point(5, 299);
            this.groupDMs.Name = "groupDMs";
            this.groupDMs.Size = new System.Drawing.Size(204, 118);
            this.groupDMs.TabIndex = 17;
            this.groupDMs.TabStop = false;
            this.groupDMs.Text = "DM\'s";
            // 
            // bt_clear_dms
            // 
            this.bt_clear_dms.Location = new System.Drawing.Point(118, 79);
            this.bt_clear_dms.Name = "bt_clear_dms";
            this.bt_clear_dms.Size = new System.Drawing.Size(75, 23);
            this.bt_clear_dms.TabIndex = 16;
            this.bt_clear_dms.Text = "clear";
            this.bt_clear_dms.UseVisualStyleBackColor = true;
            this.bt_clear_dms.Click += new System.EventHandler(this.bt_clear_dms_Click);
            // 
            // bt_read_dms
            // 
            this.bt_read_dms.Location = new System.Drawing.Point(10, 79);
            this.bt_read_dms.Name = "bt_read_dms";
            this.bt_read_dms.Size = new System.Drawing.Size(75, 23);
            this.bt_read_dms.TabIndex = 15;
            this.bt_read_dms.Text = "read";
            this.bt_read_dms.UseVisualStyleBackColor = true;
            this.bt_read_dms.Click += new System.EventHandler(this.bt_read_dms_Click);
            // 
            // dms_count
            // 
            this.dms_count.Location = new System.Drawing.Point(118, 50);
            this.dms_count.Name = "dms_count";
            this.dms_count.Size = new System.Drawing.Size(75, 23);
            this.dms_count.TabIndex = 11;
            this.dms_count.Text = "0";
            // 
            // dms_position
            // 
            this.dms_position.Location = new System.Drawing.Point(10, 50);
            this.dms_position.Name = "dms_position";
            this.dms_position.Size = new System.Drawing.Size(75, 23);
            this.dms_position.TabIndex = 9;
            this.dms_position.Text = "0";
            // 
            // groupDM
            // 
            this.groupDM.Controls.Add(this.bt_write_dm);
            this.groupDM.Controls.Add(this.bt_read_dm);
            this.groupDM.Controls.Add(this.dm_value);
            this.groupDM.Controls.Add(label4);
            this.groupDM.Controls.Add(this.dm_position);
            this.groupDM.Controls.Add(label3);
            this.groupDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDM.Enabled = false;
            this.groupDM.Location = new System.Drawing.Point(5, 181);
            this.groupDM.Name = "groupDM";
            this.groupDM.Size = new System.Drawing.Size(204, 118);
            this.groupDM.TabIndex = 16;
            this.groupDM.TabStop = false;
            this.groupDM.Text = "DM";
            // 
            // bt_write_dm
            // 
            this.bt_write_dm.Location = new System.Drawing.Point(118, 76);
            this.bt_write_dm.Name = "bt_write_dm";
            this.bt_write_dm.Size = new System.Drawing.Size(75, 23);
            this.bt_write_dm.TabIndex = 16;
            this.bt_write_dm.Text = "write";
            this.bt_write_dm.UseVisualStyleBackColor = true;
            this.bt_write_dm.Click += new System.EventHandler(this.bt_write_dm_Click);
            // 
            // bt_read_dm
            // 
            this.bt_read_dm.Location = new System.Drawing.Point(10, 76);
            this.bt_read_dm.Name = "bt_read_dm";
            this.bt_read_dm.Size = new System.Drawing.Size(75, 23);
            this.bt_read_dm.TabIndex = 15;
            this.bt_read_dm.Text = "read";
            this.bt_read_dm.UseVisualStyleBackColor = true;
            this.bt_read_dm.Click += new System.EventHandler(this.bt_read_dm_Click);
            // 
            // dm_value
            // 
            this.dm_value.Location = new System.Drawing.Point(118, 47);
            this.dm_value.Name = "dm_value";
            this.dm_value.Size = new System.Drawing.Size(75, 23);
            this.dm_value.TabIndex = 11;
            this.dm_value.Text = "0";
            // 
            // dm_position
            // 
            this.dm_position.Location = new System.Drawing.Point(10, 47);
            this.dm_position.Name = "dm_position";
            this.dm_position.Size = new System.Drawing.Size(75, 23);
            this.dm_position.TabIndex = 9;
            this.dm_position.Text = "0";
            this.dm_position.TextChanged += new System.EventHandler(this.dm_position_TextChanged);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(15, 432);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 35);
            this.bt_exit.TabIndex = 15;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_connection_data_read);
            this.groupBox1.Controls.Add(this.bt_close);
            this.groupBox1.Controls.Add(this.bt_connect);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // bt_connection_data_read
            // 
            this.bt_connection_data_read.Enabled = false;
            this.bt_connection_data_read.Location = new System.Drawing.Point(10, 133);
            this.bt_connection_data_read.Name = "bt_connection_data_read";
            this.bt_connection_data_read.Size = new System.Drawing.Size(183, 23);
            this.bt_connection_data_read.TabIndex = 12;
            this.bt_connection_data_read.Text = "connection data read";
            this.bt_connection_data_read.UseVisualStyleBackColor = true;
            this.bt_connection_data_read.Click += new System.EventHandler(this.bt_connection_data_read_Click);
            // 
            // bt_close
            // 
            this.bt_close.Enabled = false;
            this.bt_close.Location = new System.Drawing.Point(118, 95);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 11;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(10, 95);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 23);
            this.bt_connect.TabIndex = 10;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(78, 55);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(55, 23);
            this.port.TabIndex = 9;
            this.port.Text = "9600";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(78, 26);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(115, 23);
            this.ip.TabIndex = 7;
            this.ip.Text = "0.0.0.0";
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.groupDialogText);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(214, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Padding = new System.Windows.Forms.Padding(5);
            this.right_panel.Size = new System.Drawing.Size(367, 482);
            this.right_panel.TabIndex = 16;
            // 
            // groupDialogText
            // 
            this.groupDialogText.Controls.Add(this.groupBox2);
            this.groupDialogText.Controls.Add(this.dialog);
            this.groupDialogText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDialogText.Location = new System.Drawing.Point(5, 5);
            this.groupDialogText.Name = "groupDialogText";
            this.groupDialogText.Padding = new System.Windows.Forms.Padding(10);
            this.groupDialogText.Size = new System.Drawing.Size(357, 472);
            this.groupDialogText.TabIndex = 15;
            this.groupDialogText.TabStop = false;
            this.groupDialogText.Text = "Dialog";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 118);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 23);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0";
            // 
            // dialog
            // 
            this.dialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialog.Location = new System.Drawing.Point(10, 26);
            this.dialog.Multiline = true;
            this.dialog.Name = "dialog";
            this.dialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dialog.Size = new System.Drawing.Size(337, 436);
            this.dialog.TabIndex = 0;
            // 
            // TestPLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 482);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.left_panel);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TestPLC";
            this.Text = "Test mc.OMRON class";
            this.left_panel.ResumeLayout(false);
            this.groupDMs.ResumeLayout(false);
            this.groupDMs.PerformLayout();
            this.groupDM.ResumeLayout(false);
            this.groupDM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.groupDialogText.ResumeLayout(false);
            this.groupDialogText.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel left_panel;
		private System.Windows.Forms.GroupBox groupDMs;
		private System.Windows.Forms.Button bt_clear_dms;
		private System.Windows.Forms.Button bt_read_dms;
		private System.Windows.Forms.TextBox dms_count;
		private System.Windows.Forms.TextBox dms_position;
		private System.Windows.Forms.GroupBox groupDM;
		private System.Windows.Forms.Button bt_write_dm;
		private System.Windows.Forms.Button bt_read_dm;
		private System.Windows.Forms.TextBox dm_position;
		private System.Windows.Forms.Button bt_exit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Button bt_connect;
		private System.Windows.Forms.TextBox port;
		private System.Windows.Forms.TextBox ip;
		private System.Windows.Forms.Panel right_panel;
		private System.Windows.Forms.GroupBox groupDialogText;
		private System.Windows.Forms.TextBox dialog;
		private System.Windows.Forms.Button bt_connection_data_read;
		private System.Windows.Forms.TextBox dm_value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
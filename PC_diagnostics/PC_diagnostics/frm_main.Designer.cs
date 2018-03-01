namespace PC_diagnostics
{
    partial class frm_main
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sys_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.lbl_mobo = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_hdd = new System.Windows.Forms.Label();
            this.lbl_video = new System.Windows.Forms.Label();
            this.lbl_psu = new System.Windows.Forms.Label();
            this.lbl_os = new System.Windows.Forms.Label();
            this.lbl_bak_id = new System.Windows.Forms.Label();
            this.lbl_bak_date = new System.Windows.Forms.Label();
            this.cmb_backup = new System.Windows.Forms.ComboBox();
            this.btn_add_pc = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_add_log = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Systems";
            // 
            // lbl_sys_count
            // 
            this.lbl_sys_count.AutoSize = true;
            this.lbl_sys_count.Location = new System.Drawing.Point(74, 28);
            this.lbl_sys_count.Name = "lbl_sys_count";
            this.lbl_sys_count.Size = new System.Drawing.Size(35, 13);
            this.lbl_sys_count.TabIndex = 2;
            this.lbl_sys_count.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_sys_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_backup);
            this.groupBox2.Controls.Add(this.lbl_bak_date);
            this.groupBox2.Controls.Add(this.lbl_bak_id);
            this.groupBox2.Controls.Add(this.lbl_os);
            this.groupBox2.Controls.Add(this.lbl_psu);
            this.groupBox2.Controls.Add(this.lbl_video);
            this.groupBox2.Controls.Add(this.lbl_hdd);
            this.groupBox2.Controls.Add(this.lbl_ram);
            this.groupBox2.Controls.Add(this.lbl_mobo);
            this.groupBox2.Controls.Add(this.lbl_cpu);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(35, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 368);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motherboard:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "RAM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HDD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Video Card:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "PSU:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "OS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Backup";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Backup ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Backup Date";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.Location = new System.Drawing.Point(122, 30);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(38, 13);
            this.lbl_cpu.TabIndex = 17;
            this.lbl_cpu.Text = "Owner";
            // 
            // lbl_mobo
            // 
            this.lbl_mobo.AutoSize = true;
            this.lbl_mobo.Location = new System.Drawing.Point(122, 64);
            this.lbl_mobo.Name = "lbl_mobo";
            this.lbl_mobo.Size = new System.Drawing.Size(38, 13);
            this.lbl_mobo.TabIndex = 18;
            this.lbl_mobo.Text = "Owner";
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(122, 95);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(38, 13);
            this.lbl_ram.TabIndex = 19;
            this.lbl_ram.Text = "Owner";
            // 
            // lbl_hdd
            // 
            this.lbl_hdd.AutoSize = true;
            this.lbl_hdd.Location = new System.Drawing.Point(122, 127);
            this.lbl_hdd.Name = "lbl_hdd";
            this.lbl_hdd.Size = new System.Drawing.Size(38, 13);
            this.lbl_hdd.TabIndex = 20;
            this.lbl_hdd.Text = "Owner";
            // 
            // lbl_video
            // 
            this.lbl_video.AutoSize = true;
            this.lbl_video.Location = new System.Drawing.Point(122, 160);
            this.lbl_video.Name = "lbl_video";
            this.lbl_video.Size = new System.Drawing.Size(38, 13);
            this.lbl_video.TabIndex = 21;
            this.lbl_video.Text = "Owner";
            // 
            // lbl_psu
            // 
            this.lbl_psu.AutoSize = true;
            this.lbl_psu.Location = new System.Drawing.Point(122, 196);
            this.lbl_psu.Name = "lbl_psu";
            this.lbl_psu.Size = new System.Drawing.Size(38, 13);
            this.lbl_psu.TabIndex = 22;
            this.lbl_psu.Text = "Owner";
            // 
            // lbl_os
            // 
            this.lbl_os.AutoSize = true;
            this.lbl_os.Location = new System.Drawing.Point(122, 229);
            this.lbl_os.Name = "lbl_os";
            this.lbl_os.Size = new System.Drawing.Size(38, 13);
            this.lbl_os.TabIndex = 23;
            this.lbl_os.Text = "Owner";
            // 
            // lbl_bak_id
            // 
            this.lbl_bak_id.AutoSize = true;
            this.lbl_bak_id.Location = new System.Drawing.Point(122, 296);
            this.lbl_bak_id.Name = "lbl_bak_id";
            this.lbl_bak_id.Size = new System.Drawing.Size(38, 13);
            this.lbl_bak_id.TabIndex = 24;
            this.lbl_bak_id.Text = "Owner";
            // 
            // lbl_bak_date
            // 
            this.lbl_bak_date.AutoSize = true;
            this.lbl_bak_date.Location = new System.Drawing.Point(122, 331);
            this.lbl_bak_date.Name = "lbl_bak_date";
            this.lbl_bak_date.Size = new System.Drawing.Size(38, 13);
            this.lbl_bak_date.TabIndex = 25;
            this.lbl_bak_date.Text = "Owner";
            // 
            // cmb_backup
            // 
            this.cmb_backup.FormattingEnabled = true;
            this.cmb_backup.Location = new System.Drawing.Point(125, 251);
            this.cmb_backup.Name = "cmb_backup";
            this.cmb_backup.Size = new System.Drawing.Size(55, 21);
            this.cmb_backup.TabIndex = 26;
            // 
            // btn_add_pc
            // 
            this.btn_add_pc.Location = new System.Drawing.Point(365, 35);
            this.btn_add_pc.Name = "btn_add_pc";
            this.btn_add_pc.Size = new System.Drawing.Size(111, 31);
            this.btn_add_pc.TabIndex = 7;
            this.btn_add_pc.Text = "Add New";
            this.btn_add_pc.UseVisualStyleBackColor = true;
            this.btn_add_pc.Click += new System.EventHandler(this.btn_add_pc_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(545, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 481);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "System Logs";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(899, 77);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(320, 213);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(896, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "New Log Entry";
            // 
            // btn_add_log
            // 
            this.btn_add_log.Location = new System.Drawing.Point(1014, 308);
            this.btn_add_log.Name = "btn_add_log";
            this.btn_add_log.Size = new System.Drawing.Size(111, 31);
            this.btn_add_log.TabIndex = 11;
            this.btn_add_log.Text = "Add Log";
            this.btn_add_log.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1183, 549);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 31);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(366, 86);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(111, 31);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(366, 134);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 31);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 592);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add_log);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_add_pc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_main";
            this.Text = "System Diagnostics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sys_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_backup;
        private System.Windows.Forms.Label lbl_bak_date;
        private System.Windows.Forms.Label lbl_bak_id;
        private System.Windows.Forms.Label lbl_os;
        private System.Windows.Forms.Label lbl_psu;
        private System.Windows.Forms.Label lbl_video;
        private System.Windows.Forms.Label lbl_hdd;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_mobo;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_add_pc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_add_log;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}
namespace UI_Tier
{
    partial class AddNewForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBoxRemind = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.plRemind = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBGroupMeeting = new System.Windows.Forms.CheckBox();
            this.chLstRepeatDays = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.plRemind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.chkBGroupMeeting);
            this.panel1.Controls.Add(this.chkBoxRemind);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.plRemind);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(110, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 483);
            this.panel1.TabIndex = 0;
            // 
            // chkBoxRemind
            // 
            this.chkBoxRemind.AutoSize = true;
            this.chkBoxRemind.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxRemind.Location = new System.Drawing.Point(21, 277);
            this.chkBoxRemind.Name = "chkBoxRemind";
            this.chkBoxRemind.Size = new System.Drawing.Size(108, 27);
            this.chkBoxRemind.TabIndex = 12;
            this.chkBoxRemind.Text = "Nhắc nhở";
            this.chkBoxRemind.UseVisualStyleBackColor = true;
            this.chkBoxRemind.CheckedChanged += new System.EventHandler(this.chkBoxRemind_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Pink;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(450, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(209, 185);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(294, 22);
            this.dtEnd.TabIndex = 11;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(209, 135);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(294, 22);
            this.dtStart.TabIndex = 10;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(209, 81);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(294, 22);
            this.txtLocation.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(209, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(294, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // plRemind
            // 
            this.plRemind.BackColor = System.Drawing.Color.MistyRose;
            this.plRemind.Controls.Add(this.label8);
            this.plRemind.Controls.Add(this.chLstRepeatDays);
            this.plRemind.Location = new System.Drawing.Point(135, 277);
            this.plRemind.Name = "plRemind";
            this.plRemind.Size = new System.Drawing.Size(310, 124);
            this.plRemind.TabIndex = 6;
            this.plRemind.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời gian kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiêu đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sự kiện mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkBGroupMeeting
            // 
            this.chkBGroupMeeting.AutoSize = true;
            this.chkBGroupMeeting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBGroupMeeting.Location = new System.Drawing.Point(21, 230);
            this.chkBGroupMeeting.Name = "chkBGroupMeeting";
            this.chkBGroupMeeting.Size = new System.Drawing.Size(149, 27);
            this.chkBGroupMeeting.TabIndex = 13;
            this.chkBGroupMeeting.Text = "GroupMeeting";
            this.chkBGroupMeeting.UseVisualStyleBackColor = true;
            // 
            // chLstRepeatDays
            // 
            this.chLstRepeatDays.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chLstRepeatDays.FormattingEnabled = true;
            this.chLstRepeatDays.Items.AddRange(new object[] {
            "10 phút",
            "30 phút",
            "1 giờ",
            "1 ngày ",
            "1 tuần"});
            this.chLstRepeatDays.Location = new System.Drawing.Point(82, 4);
            this.chLstRepeatDays.Name = "chLstRepeatDays";
            this.chLstRepeatDays.Size = new System.Drawing.Size(147, 84);
            this.chLstRepeatDays.TabIndex = 12;
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(859, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewForm";
            this.Text = "AddNewForm";
            this.Load += new System.EventHandler(this.AddNewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plRemind.ResumeLayout(false);
            this.plRemind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel plRemind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkBoxRemind;
        private System.Windows.Forms.CheckBox chkBGroupMeeting;
        private System.Windows.Forms.CheckedListBox chLstRepeatDays;
    }
}
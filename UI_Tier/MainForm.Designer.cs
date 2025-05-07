using System;

namespace UI_Tier
{
    partial class MainForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbMonth = new System.Windows.Forms.Label();
            this.tbLayoutCalender = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plListEvent = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbLayoutCalender.SuspendLayout();
            this.plListEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lbMonth);
            this.panel1.Controls.Add(this.tbLayoutCalender);
            this.panel1.Location = new System.Drawing.Point(30, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 407);
            this.panel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(569, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 38);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "+New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(129, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(51, 24);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<=";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(361, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 24);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "=>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.ForeColor = System.Drawing.Color.Red;
            this.lbMonth.Location = new System.Drawing.Point(200, 12);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(78, 23);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Tháng...";
            // 
            // tbLayoutCalender
            // 
            this.tbLayoutCalender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLayoutCalender.AutoScroll = true;
            this.tbLayoutCalender.ColumnCount = 7;
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbLayoutCalender.Controls.Add(this.label7, 6, 0);
            this.tbLayoutCalender.Controls.Add(this.label6, 5, 0);
            this.tbLayoutCalender.Controls.Add(this.label5, 4, 0);
            this.tbLayoutCalender.Controls.Add(this.label4, 3, 0);
            this.tbLayoutCalender.Controls.Add(this.label3, 2, 0);
            this.tbLayoutCalender.Controls.Add(this.label2, 1, 0);
            this.tbLayoutCalender.Controls.Add(this.label1, 0, 0);
            this.tbLayoutCalender.Location = new System.Drawing.Point(31, 50);
            this.tbLayoutCalender.Name = "tbLayoutCalender";
            this.tbLayoutCalender.RowCount = 6;
            this.tbLayoutCalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbLayoutCalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbLayoutCalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbLayoutCalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbLayoutCalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbLayoutCalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbLayoutCalender.Size = new System.Drawing.Size(692, 329);
            this.tbLayoutCalender.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 54);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sunday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 54);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saturday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 54);
            this.label5.TabIndex = 4;
            this.label5.Text = "Friday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thursday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wednesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuesday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plListEvent
            // 
            this.plListEvent.BackColor = System.Drawing.Color.SeaShell;
            this.plListEvent.Controls.Add(this.lbDate);
            this.plListEvent.Controls.Add(this.lstEvent);
            this.plListEvent.Controls.Add(this.label8);
            this.plListEvent.Location = new System.Drawing.Point(806, 42);
            this.plListEvent.Name = "plListEvent";
            this.plListEvent.Size = new System.Drawing.Size(442, 396);
            this.plListEvent.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(63, 28);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(54, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày";
            // 
            // lstEvent
            // 
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.ItemHeight = 16;
            this.lstEvent.Location = new System.Drawing.Point(22, 50);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(363, 276);
            this.lstEvent.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách sự kiện ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(35, 16);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(59, 23);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "label9";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SeaShell;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1136, 444);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1312, 489);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.plListEvent);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbLayoutCalender.ResumeLayout(false);
            this.tbLayoutCalender.PerformLayout();
            this.plListEvent.ResumeLayout(false);
            this.plListEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.TableLayoutPanel tbLayoutCalender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel plListEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstEvent;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLogout;
    }
}


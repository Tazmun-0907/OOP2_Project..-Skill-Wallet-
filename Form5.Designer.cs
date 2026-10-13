namespace Skill_Wallet
{
    partial class Form5
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
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblCourseQ = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblMeet = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.btnUploadVideo = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtMeetLink = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(551, 91);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(168, 28);
            this.lblInstructor.TabIndex = 0;
            this.lblInstructor.Text = "Hello Instructor!";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(28, 26);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(89, 20);
            this.lblCoins.TabIndex = 1;
            this.lblCoins.Text = "Coins: 120";
            // 
            // lblCourseQ
            // 
            this.lblCourseQ.AutoSize = true;
            this.lblCourseQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseQ.Location = new System.Drawing.Point(31, 193);
            this.lblCourseQ.Name = "lblCourseQ";
            this.lblCourseQ.Size = new System.Drawing.Size(289, 18);
            this.lblCourseQ.TabIndex = 2;
            this.lblCourseQ.Text = "Which course do you want to teach today?";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(34, 252);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(148, 18);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "Upload course video:";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(37, 330);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(145, 18);
            this.lblSchedule.TabIndex = 4;
            this.lblSchedule.Text = "Schedule Live Class:";
            // 
            // lblMeet
            // 
            this.lblMeet.AutoSize = true;
            this.lblMeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeet.Location = new System.Drawing.Point(40, 396);
            this.lblMeet.Name = "lblMeet";
            this.lblMeet.Size = new System.Drawing.Size(129, 18);
            this.lblMeet.TabIndex = 5;
            this.lblMeet.Text = "Google Meet Link:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(43, 467);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(46, 525);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 18);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time:";
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(348, 187);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(244, 24);
            this.cmbCourses.TabIndex = 8;
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.Location = new System.Drawing.Point(212, 233);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Size = new System.Drawing.Size(142, 37);
            this.btnUploadVideo.TabIndex = 9;
            this.btnUploadVideo.Text = "Upload Video";
            this.btnUploadVideo.UseVisualStyleBackColor = true;
            this.btnUploadVideo.Click += new System.EventHandler(this.btnUploadVideo_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(212, 323);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(142, 35);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "Schedule Class";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(98, 467);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 11;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(98, 522);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 22);
            this.dtpTime.TabIndex = 12;
            // 
            // txtMeetLink
            // 
            this.txtMeetLink.Location = new System.Drawing.Point(212, 392);
            this.txtMeetLink.Name = "txtMeetLink";
            this.txtMeetLink.Size = new System.Drawing.Size(336, 22);
            this.txtMeetLink.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(554, 592);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 65);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1290, 779);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMeetLink);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnUploadVideo);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMeet);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.lblCourseQ);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblInstructor);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblCourseQ;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblMeet;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Button btnUploadVideo;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtMeetLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBack;
    }
}
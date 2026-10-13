namespace Skill_Wallet
{
    partial class Dashboard
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
            this.lblHello = new System.Windows.Forms.Label();
            this.lblRoleText = new System.Windows.Forms.Label();
            this.btnInstructor = new System.Windows.Forms.Button();
            this.btnLearner = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnUniversity = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnCommunity = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnCoins = new System.Windows.Forms.Button();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(655, 98);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 63);
            this.lblHello.TabIndex = 0;
            // 
            // lblRoleText
            // 
            this.lblRoleText.AutoSize = true;
            this.lblRoleText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleText.Location = new System.Drawing.Point(191, 227);
            this.lblRoleText.Name = "lblRoleText";
            this.lblRoleText.Size = new System.Drawing.Size(176, 23);
            this.lblRoleText.TabIndex = 1;
            this.lblRoleText.Text = "Continuing today as:";
            // 
            // btnInstructor
            // 
            this.btnInstructor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructor.Location = new System.Drawing.Point(225, 290);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Size = new System.Drawing.Size(141, 114);
            this.btnInstructor.TabIndex = 2;
            this.btnInstructor.Text = "Instructor";
            this.btnInstructor.UseVisualStyleBackColor = true;
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // btnLearner
            // 
            this.btnLearner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearner.Location = new System.Drawing.Point(471, 290);
            this.btnLearner.Name = "btnLearner";
            this.btnLearner.Size = new System.Drawing.Size(141, 114);
            this.btnLearner.TabIndex = 3;
            this.btnLearner.Text = "Learner";
            this.btnLearner.UseVisualStyleBackColor = true;
            this.btnLearner.Click += new System.EventHandler(this.btnLearner_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(1153, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(125, 58);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfile.Controls.Add(this.btnLogout);
            this.pnlProfile.Controls.Add(this.btnUpdateProfile);
            this.pnlProfile.Controls.Add(this.btnUniversity);
            this.pnlProfile.Controls.Add(this.btnJobs);
            this.pnlProfile.Controls.Add(this.btnCommunity);
            this.pnlProfile.Controls.Add(this.btnCourses);
            this.pnlProfile.Controls.Add(this.btnCoins);
            this.pnlProfile.Controls.Add(this.lblProfileEmail);
            this.pnlProfile.Controls.Add(this.lblProfileName);
            this.pnlProfile.Location = new System.Drawing.Point(1064, 76);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(231, 347);
            this.pnlProfile.TabIndex = 5;
            this.pnlProfile.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(15, 304);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 38);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(15, 261);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateProfile.TabIndex = 7;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnUniversity
            // 
            this.btnUniversity.Location = new System.Drawing.Point(15, 220);
            this.btnUniversity.Name = "btnUniversity";
            this.btnUniversity.Size = new System.Drawing.Size(101, 35);
            this.btnUniversity.TabIndex = 6;
            this.btnUniversity.Text = "University";
            this.btnUniversity.UseVisualStyleBackColor = true;
            this.btnUniversity.Click += new System.EventHandler(this.btnUniversity_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(15, 180);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(101, 34);
            this.btnJobs.TabIndex = 5;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnCommunity
            // 
            this.btnCommunity.Location = new System.Drawing.Point(15, 142);
            this.btnCommunity.Name = "btnCommunity";
            this.btnCommunity.Size = new System.Drawing.Size(101, 32);
            this.btnCommunity.TabIndex = 4;
            this.btnCommunity.Text = "Community";
            this.btnCommunity.UseVisualStyleBackColor = true;
            this.btnCommunity.Click += new System.EventHandler(this.btnCommunity_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(15, 101);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(101, 35);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnCoins
            // 
            this.btnCoins.Location = new System.Drawing.Point(15, 71);
            this.btnCoins.Name = "btnCoins";
            this.btnCoins.Size = new System.Drawing.Size(101, 23);
            this.btnCoins.TabIndex = 2;
            this.btnCoins.Text = "Coins";
            this.btnCoins.UseVisualStyleBackColor = true;
            this.btnCoins.Click += new System.EventHandler(this.btnCoins_Click);
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Location = new System.Drawing.Point(15, 40);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(41, 16);
            this.lblProfileEmail.TabIndex = 1;
            this.lblProfileEmail.Text = "Email";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(12, 11);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(44, 16);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "Name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1307, 664);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLearner);
            this.Controls.Add(this.btnInstructor);
            this.Controls.Add(this.lblRoleText);
            this.Controls.Add(this.lblHello);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblRoleText;
        private System.Windows.Forms.Button btnInstructor;
        private System.Windows.Forms.Button btnLearner;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnUniversity;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnCommunity;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnCoins;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileName;
    }
}
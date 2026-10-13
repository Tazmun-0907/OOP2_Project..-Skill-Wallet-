namespace Skill_Wallet
{
    partial class Form8
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
            this.lblUniversityID = new System.Windows.Forms.Label();
            this.lblUniversityName = new System.Windows.Forms.Label();
            this.lblWaiver = new System.Windows.Forms.Label();
            this.cmbUniversityID = new System.Windows.Forms.ComboBox();
            this.txtUniversityName = new System.Windows.Forms.TextBox();
            this.txtWaiver = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUniversityID
            // 
            this.lblUniversityID.AutoSize = true;
            this.lblUniversityID.Location = new System.Drawing.Point(131, 119);
            this.lblUniversityID.Name = "lblUniversityID";
            this.lblUniversityID.Size = new System.Drawing.Size(82, 16);
            this.lblUniversityID.TabIndex = 0;
            this.lblUniversityID.Text = "University ID";
            // 
            // lblUniversityName
            // 
            this.lblUniversityName.AutoSize = true;
            this.lblUniversityName.Location = new System.Drawing.Point(131, 181);
            this.lblUniversityName.Name = "lblUniversityName";
            this.lblUniversityName.Size = new System.Drawing.Size(106, 16);
            this.lblUniversityName.TabIndex = 1;
            this.lblUniversityName.Text = "University Name";
            // 
            // lblWaiver
            // 
            this.lblWaiver.AutoSize = true;
            this.lblWaiver.Location = new System.Drawing.Point(131, 234);
            this.lblWaiver.Name = "lblWaiver";
            this.lblWaiver.Size = new System.Drawing.Size(50, 16);
            this.lblWaiver.TabIndex = 2;
            this.lblWaiver.Text = "Waiver";
            // 
            // cmbUniversityID
            // 
            this.cmbUniversityID.FormattingEnabled = true;
            this.cmbUniversityID.Location = new System.Drawing.Point(265, 110);
            this.cmbUniversityID.Name = "cmbUniversityID";
            this.cmbUniversityID.Size = new System.Drawing.Size(147, 24);
            this.cmbUniversityID.TabIndex = 3;
            this.cmbUniversityID.SelectedIndexChanged += new System.EventHandler(this.cmbUniversityID_SelectedIndexChanged);
            // 
            // txtUniversityName
            // 
            this.txtUniversityName.Location = new System.Drawing.Point(265, 181);
            this.txtUniversityName.Name = "txtUniversityName";
            this.txtUniversityName.ReadOnly = true;
            this.txtUniversityName.Size = new System.Drawing.Size(212, 22);
            this.txtUniversityName.TabIndex = 4;
            // 
            // txtWaiver
            // 
            this.txtWaiver.Location = new System.Drawing.Point(265, 234);
            this.txtWaiver.Name = "txtWaiver";
            this.txtWaiver.ReadOnly = true;
            this.txtWaiver.Size = new System.Drawing.Size(212, 22);
            this.txtWaiver.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(404, 524);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 88);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(906, 676);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtWaiver);
            this.Controls.Add(this.txtUniversityName);
            this.Controls.Add(this.cmbUniversityID);
            this.Controls.Add(this.lblWaiver);
            this.Controls.Add(this.lblUniversityName);
            this.Controls.Add(this.lblUniversityID);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUniversityID;
        private System.Windows.Forms.Label lblUniversityName;
        private System.Windows.Forms.Label lblWaiver;
        private System.Windows.Forms.ComboBox cmbUniversityID;
        private System.Windows.Forms.TextBox txtUniversityName;
        private System.Windows.Forms.TextBox txtWaiver;
        private System.Windows.Forms.Button btnBack;
    }
}
namespace Skill_Wallet
{
    partial class Form9
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
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblPostName = new System.Windows.Forms.Label();
            this.lblCoinRequired = new System.Windows.Forms.Label();
            this.lblCourseRequired = new System.Windows.Forms.Label();
            this.cmbJobID = new System.Windows.Forms.ComboBox();
            this.txtPostName = new System.Windows.Forms.TextBox();
            this.txtCoinRequired = new System.Windows.Forms.TextBox();
            this.txtCourseRequired = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(106, 157);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(46, 16);
            this.lblJobID.TabIndex = 0;
            this.lblJobID.Text = "Job ID";
            // 
            // lblPostName
            // 
            this.lblPostName.AutoSize = true;
            this.lblPostName.Location = new System.Drawing.Point(106, 215);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(74, 16);
            this.lblPostName.TabIndex = 1;
            this.lblPostName.Text = "Post Name";
            // 
            // lblCoinRequired
            // 
            this.lblCoinRequired.AutoSize = true;
            this.lblCoinRequired.Location = new System.Drawing.Point(106, 272);
            this.lblCoinRequired.Name = "lblCoinRequired";
            this.lblCoinRequired.Size = new System.Drawing.Size(93, 16);
            this.lblCoinRequired.TabIndex = 2;
            this.lblCoinRequired.Text = "Coin Required";
            // 
            // lblCourseRequired
            // 
            this.lblCourseRequired.AutoSize = true;
            this.lblCourseRequired.Location = new System.Drawing.Point(106, 343);
            this.lblCourseRequired.Name = "lblCourseRequired";
            this.lblCourseRequired.Size = new System.Drawing.Size(109, 16);
            this.lblCourseRequired.TabIndex = 3;
            this.lblCourseRequired.Text = "Course Required";
            // 
            // cmbJobID
            // 
            this.cmbJobID.FormattingEnabled = true;
            this.cmbJobID.Location = new System.Drawing.Point(229, 149);
            this.cmbJobID.Name = "cmbJobID";
            this.cmbJobID.Size = new System.Drawing.Size(220, 24);
            this.cmbJobID.TabIndex = 4;
            this.cmbJobID.SelectedIndexChanged += new System.EventHandler(this.cmbJobID_SelectedIndexChanged);
            // 
            // txtPostName
            // 
            this.txtPostName.Location = new System.Drawing.Point(229, 209);
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.ReadOnly = true;
            this.txtPostName.Size = new System.Drawing.Size(280, 22);
            this.txtPostName.TabIndex = 5;
            // 
            // txtCoinRequired
            // 
            this.txtCoinRequired.Location = new System.Drawing.Point(229, 272);
            this.txtCoinRequired.Name = "txtCoinRequired";
            this.txtCoinRequired.ReadOnly = true;
            this.txtCoinRequired.Size = new System.Drawing.Size(220, 22);
            this.txtCoinRequired.TabIndex = 6;
            // 
            // txtCourseRequired
            // 
            this.txtCourseRequired.Location = new System.Drawing.Point(229, 337);
            this.txtCourseRequired.Name = "txtCourseRequired";
            this.txtCourseRequired.ReadOnly = true;
            this.txtCourseRequired.Size = new System.Drawing.Size(280, 22);
            this.txtCourseRequired.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(361, 513);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 100);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(853, 669);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCourseRequired);
            this.Controls.Add(this.txtCoinRequired);
            this.Controls.Add(this.txtPostName);
            this.Controls.Add(this.cmbJobID);
            this.Controls.Add(this.lblCourseRequired);
            this.Controls.Add(this.lblCoinRequired);
            this.Controls.Add(this.lblPostName);
            this.Controls.Add(this.lblJobID);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblPostName;
        private System.Windows.Forms.Label lblCoinRequired;
        private System.Windows.Forms.Label lblCourseRequired;
        private System.Windows.Forms.ComboBox cmbJobID;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.TextBox txtCoinRequired;
        private System.Windows.Forms.TextBox txtCourseRequired;
        private System.Windows.Forms.Button btnBack;
    }
}
namespace Skill_Wallet
{
    partial class Form10
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
            this.lblCommunityID = new System.Windows.Forms.Label();
            this.lblCommunityTitle = new System.Windows.Forms.Label();
            this.txtCommunityID = new System.Windows.Forms.TextBox();
            this.txtCommunityTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExistingCommunity = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExistingCommunity);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtCommunityTitle);
            this.panel1.Controls.Add(this.txtCommunityID);
            this.panel1.Controls.Add(this.lblCommunityTitle);
            this.panel1.Controls.Add(this.lblCommunityID);
            this.panel1.Location = new System.Drawing.Point(404, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 331);
            this.panel1.TabIndex = 0;
            // 
            // lblCommunityID
            // 
            this.lblCommunityID.AutoSize = true;
            this.lblCommunityID.Location = new System.Drawing.Point(22, 105);
            this.lblCommunityID.Name = "lblCommunityID";
            this.lblCommunityID.Size = new System.Drawing.Size(89, 16);
            this.lblCommunityID.TabIndex = 0;
            this.lblCommunityID.Text = "Community ID";
            // 
            // lblCommunityTitle
            // 
            this.lblCommunityTitle.AutoSize = true;
            this.lblCommunityTitle.Location = new System.Drawing.Point(25, 181);
            this.lblCommunityTitle.Name = "lblCommunityTitle";
            this.lblCommunityTitle.Size = new System.Drawing.Size(102, 16);
            this.lblCommunityTitle.TabIndex = 1;
            this.lblCommunityTitle.Text = "Community Title";
            // 
            // txtCommunityID
            // 
            this.txtCommunityID.Location = new System.Drawing.Point(163, 98);
            this.txtCommunityID.Name = "txtCommunityID";
            this.txtCommunityID.Size = new System.Drawing.Size(349, 22);
            this.txtCommunityID.TabIndex = 2;
            // 
            // txtCommunityTitle
            // 
            this.txtCommunityTitle.Location = new System.Drawing.Point(163, 174);
            this.txtCommunityTitle.Name = "txtCommunityTitle";
            this.txtCommunityTitle.Size = new System.Drawing.Size(349, 22);
            this.txtCommunityTitle.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Create Community";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExistingCommunity
            // 
            this.btnExistingCommunity.Location = new System.Drawing.Point(298, 278);
            this.btnExistingCommunity.Name = "btnExistingCommunity";
            this.btnExistingCommunity.Size = new System.Drawing.Size(214, 23);
            this.btnExistingCommunity.TabIndex = 5;
            this.btnExistingCommunity.Text = "Existing Community";
            this.btnExistingCommunity.UseVisualStyleBackColor = true;
            this.btnExistingCommunity.Click += new System.EventHandler(this.btnExistingCommunity_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(404, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 75);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCommunityTitle;
        private System.Windows.Forms.TextBox txtCommunityID;
        private System.Windows.Forms.Label lblCommunityTitle;
        private System.Windows.Forms.Label lblCommunityID;
        private System.Windows.Forms.Button btnExistingCommunity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}
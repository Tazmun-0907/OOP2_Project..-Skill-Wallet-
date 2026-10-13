namespace Skill_Wallet
{
    partial class Form7
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
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.lblPrerequisite = new System.Windows.Forms.Label();
            this.lblCoinValue = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbInstructors = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPreRequisite = new System.Windows.Forms.TextBox();
            this.txtMaxCapacity = new System.Windows.Forms.TextBox();
            this.txtCoinsRequired = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(89, 109);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(57, 16);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Courses";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(89, 168);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(60, 16);
            this.lblInstructor.TabIndex = 1;
            this.lblInstructor.Text = "Instructor";
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Location = new System.Drawing.Point(89, 220);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(157, 16);
            this.lblCapacityValue.TabIndex = 2;
            this.lblCapacityValue.Text = "Max Capacity per Course";
            // 
            // lblPrerequisite
            // 
            this.lblPrerequisite.AutoSize = true;
            this.lblPrerequisite.Location = new System.Drawing.Point(89, 270);
            this.lblPrerequisite.Name = "lblPrerequisite";
            this.lblPrerequisite.Size = new System.Drawing.Size(89, 16);
            this.lblPrerequisite.TabIndex = 3;
            this.lblPrerequisite.Text = "Pre-Requisite";
            // 
            // lblCoinValue
            // 
            this.lblCoinValue.AutoSize = true;
            this.lblCoinValue.Location = new System.Drawing.Point(89, 322);
            this.lblCoinValue.Name = "lblCoinValue";
            this.lblCoinValue.Size = new System.Drawing.Size(169, 16);
            this.lblCoinValue.TabIndex = 4;
            this.lblCoinValue.Text = "Coins Required per Course";
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(202, 109);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(351, 24);
            this.cmbCourses.TabIndex = 5;
            this.cmbCourses.SelectedIndexChanged += new System.EventHandler(this.cmbCourses_SelectedIndexChanged);
            // 
            // cmbInstructors
            // 
            this.cmbInstructors.FormattingEnabled = true;
            this.cmbInstructors.Location = new System.Drawing.Point(202, 160);
            this.cmbInstructors.Name = "cmbInstructors";
            this.cmbInstructors.Size = new System.Drawing.Size(351, 24);
            this.cmbInstructors.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(444, 541);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 70);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPreRequisite
            // 
            this.txtPreRequisite.Location = new System.Drawing.Point(202, 270);
            this.txtPreRequisite.Name = "txtPreRequisite";
            this.txtPreRequisite.ReadOnly = true;
            this.txtPreRequisite.Size = new System.Drawing.Size(351, 22);
            this.txtPreRequisite.TabIndex = 8;
            // 
            // txtMaxCapacity
            // 
            this.txtMaxCapacity.Location = new System.Drawing.Point(278, 213);
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.ReadOnly = true;
            this.txtMaxCapacity.Size = new System.Drawing.Size(137, 22);
            this.txtMaxCapacity.TabIndex = 9;
            // 
            // txtCoinsRequired
            // 
            this.txtCoinsRequired.Location = new System.Drawing.Point(278, 316);
            this.txtCoinsRequired.Name = "txtCoinsRequired";
            this.txtCoinsRequired.ReadOnly = true;
            this.txtCoinsRequired.Size = new System.Drawing.Size(137, 22);
            this.txtCoinsRequired.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(444, 419);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 72);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1192, 779);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCoinsRequired);
            this.Controls.Add(this.txtMaxCapacity);
            this.Controls.Add(this.txtPreRequisite);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbInstructors);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.lblCoinValue);
            this.Controls.Add(this.lblPrerequisite);
            this.Controls.Add(this.lblCapacityValue);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblCourse);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.Label lblPrerequisite;
        private System.Windows.Forms.Label lblCoinValue;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbInstructors;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPreRequisite;
        private System.Windows.Forms.TextBox txtMaxCapacity;
        private System.Windows.Forms.TextBox txtCoinsRequired;
        private System.Windows.Forms.Button btnConfirm;
    }
}
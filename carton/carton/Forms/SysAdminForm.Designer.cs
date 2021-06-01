
namespace carton
{
    partial class SysAdminForm
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
            this.buttonOpenUserManagementForm = new System.Windows.Forms.Button();
            this.buttonOpenDepartmentManagementForm = new System.Windows.Forms.Button();
            this.labelSysAdminForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenUserManagementForm
            // 
            this.buttonOpenUserManagementForm.Location = new System.Drawing.Point(63, 170);
            this.buttonOpenUserManagementForm.Name = "buttonOpenUserManagementForm";
            this.buttonOpenUserManagementForm.Size = new System.Drawing.Size(154, 52);
            this.buttonOpenUserManagementForm.TabIndex = 0;
            this.buttonOpenUserManagementForm.Text = "Управление Пользователями";
            this.buttonOpenUserManagementForm.UseVisualStyleBackColor = true;
            this.buttonOpenUserManagementForm.Click += new System.EventHandler(this.buttonOpenUserManagementForm_Click);
            // 
            // buttonOpenDepartmentManagementForm
            // 
            this.buttonOpenDepartmentManagementForm.Location = new System.Drawing.Point(291, 170);
            this.buttonOpenDepartmentManagementForm.Name = "buttonOpenDepartmentManagementForm";
            this.buttonOpenDepartmentManagementForm.Size = new System.Drawing.Size(152, 52);
            this.buttonOpenDepartmentManagementForm.TabIndex = 1;
            this.buttonOpenDepartmentManagementForm.Text = "Управление Предприятиями";
            this.buttonOpenDepartmentManagementForm.UseVisualStyleBackColor = true;
            // 
            // labelSysAdminForm
            // 
            this.labelSysAdminForm.AutoSize = true;
            this.labelSysAdminForm.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSysAdminForm.Location = new System.Drawing.Point(16, 77);
            this.labelSysAdminForm.Name = "labelSysAdminForm";
            this.labelSysAdminForm.Size = new System.Drawing.Size(495, 38);
            this.labelSysAdminForm.TabIndex = 2;
            this.labelSysAdminForm.Text = "Системный Администратор";
            // 
            // SysAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 272);
            this.Controls.Add(this.labelSysAdminForm);
            this.Controls.Add(this.buttonOpenDepartmentManagementForm);
            this.Controls.Add(this.buttonOpenUserManagementForm);
            this.Name = "SysAdminForm";
            this.Text = "SysAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenUserManagementForm;
        private System.Windows.Forms.Button buttonOpenDepartmentManagementForm;
        private System.Windows.Forms.Label labelSysAdminForm;
    }
}
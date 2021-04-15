
namespace carton.Classes
{
    partial class LoginForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelInvite = new System.Windows.Forms.Label();
            this.buttonLoginProceed = new System.Windows.Forms.Button();
            this.loginEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.pictureLoginForm = new System.Windows.Forms.PictureBox();
            this.loadGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(294, 275);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(287, 314);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // labelInvite
            // 
            this.labelInvite.AutoSize = true;
            this.labelInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInvite.Location = new System.Drawing.Point(246, 234);
            this.labelInvite.Name = "labelInvite";
            this.labelInvite.Size = new System.Drawing.Size(252, 24);
            this.labelInvite.TabIndex = 3;
            this.labelInvite.Text = "Введите логин и пароль";
            // 
            // buttonLoginProceed
            // 
            this.buttonLoginProceed.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLoginProceed.Location = new System.Drawing.Point(352, 355);
            this.buttonLoginProceed.Name = "buttonLoginProceed";
            this.buttonLoginProceed.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginProceed.TabIndex = 4;
            this.buttonLoginProceed.Text = "Принять";
            this.buttonLoginProceed.UseVisualStyleBackColor = true;
            this.buttonLoginProceed.Click += new System.EventHandler(this.buttonLoginProceed_Click);
            // 
            // loginEntry
            // 
            this.loginEntry.Location = new System.Drawing.Point(338, 272);
            this.loginEntry.Name = "loginEntry";
            this.loginEntry.Size = new System.Drawing.Size(136, 20);
            this.loginEntry.TabIndex = 5;
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(338, 311);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.Size = new System.Drawing.Size(136, 20);
            this.passwordEntry.TabIndex = 6;
            // 
            // pictureLoginForm
            // 
            this.pictureLoginForm.Image = global::carton.Properties.Resources.loginform;
            this.pictureLoginForm.Location = new System.Drawing.Point(0, 0);
            this.pictureLoginForm.Name = "pictureLoginForm";
            this.pictureLoginForm.Size = new System.Drawing.Size(785, 194);
            this.pictureLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLoginForm.TabIndex = 0;
            this.pictureLoginForm.TabStop = false;
            // 
            // loadGridView
            // 
            this.loadGridView.AllowUserToAddRows = false;
            this.loadGridView.AllowUserToDeleteRows = false;
            this.loadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadGridView.Location = new System.Drawing.Point(13, 340);
            this.loadGridView.Name = "loadGridView";
            this.loadGridView.ReadOnly = true;
            this.loadGridView.Size = new System.Drawing.Size(0, 0);
            this.loadGridView.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.buttonLoginProceed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.loadGridView);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.loginEntry);
            this.Controls.Add(this.buttonLoginProceed);
            this.Controls.Add(this.labelInvite);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureLoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLoginForm;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelInvite;
        private System.Windows.Forms.Button buttonLoginProceed;
        private System.Windows.Forms.TextBox loginEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.DataGridView loadGridView;
    }
}
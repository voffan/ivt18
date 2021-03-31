
namespace grades
{
    partial class AddMultipleUsers
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
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(419, 23);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(75, 23);
            this.openFileDialogButton.TabIndex = 0;
            this.openFileDialogButton.Text = "Открыть";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(419, 68);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Принять";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(34, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Путь:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(15, 25);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(398, 20);
            this.pathBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(338, 68);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddMultipleUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 103);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.openFileDialogButton);
            this.Name = "AddMultipleUsers";
            this.Text = "AddMultipleUsers";
            this.Load += new System.EventHandler(this.AddMultipleUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button cancelButton;
    }
}
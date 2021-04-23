namespace grades
{
    partial class ClassGeneretion
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
            this.CountBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(30, 39);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 22);
            this.CountBox.TabIndex = 0;
            this.CountBox.Text = "0";
            this.CountBox.TextChanged += new System.EventHandler(this.CountBox_TextChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(161, 39);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(30, 80);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(121, 24);
            this.ClassList.TabIndex = 2;
            this.ClassList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            // 
            // ClassGeneretion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 143);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CountBox);
            this.Name = "ClassGeneretion";
            this.Text = "ClassGeneretion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ComboBox ClassList;
    }
}
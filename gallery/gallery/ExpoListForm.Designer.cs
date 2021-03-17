
namespace gallery
{
    partial class ExpoListForm
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
            this.listExpoBox = new System.Windows.Forms.ListBox();
            this.addExpoButton = new System.Windows.Forms.Button();
            this.deleteExpoButton = new System.Windows.Forms.Button();
            this.editExpoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listExpoBox
            // 
            this.listExpoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listExpoBox.FormattingEnabled = true;
            this.listExpoBox.ItemHeight = 20;
            this.listExpoBox.Location = new System.Drawing.Point(34, 36);
            this.listExpoBox.Name = "listExpoBox";
            this.listExpoBox.Size = new System.Drawing.Size(693, 644);
            this.listExpoBox.TabIndex = 0;
            this.listExpoBox.SelectedIndexChanged += new System.EventHandler(this.listExpoBox_SelectedIndexChanged);
            this.listExpoBox.DoubleClick += new System.EventHandler(this.listExpoBox_DoubleClick);
            // 
            // addExpoButton
            // 
            this.addExpoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addExpoButton.Location = new System.Drawing.Point(673, 737);
            this.addExpoButton.Name = "addExpoButton";
            this.addExpoButton.Size = new System.Drawing.Size(40, 33);
            this.addExpoButton.TabIndex = 1;
            this.addExpoButton.Text = "+";
            this.addExpoButton.UseVisualStyleBackColor = true;
            this.addExpoButton.Click += new System.EventHandler(this.addExpoButton_Click);
            // 
            // deleteExpoButton
            // 
            this.deleteExpoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteExpoButton.Location = new System.Drawing.Point(34, 737);
            this.deleteExpoButton.Name = "deleteExpoButton";
            this.deleteExpoButton.Size = new System.Drawing.Size(117, 33);
            this.deleteExpoButton.TabIndex = 2;
            this.deleteExpoButton.Text = "мусорка";
            this.deleteExpoButton.UseVisualStyleBackColor = true;
            this.deleteExpoButton.Click += new System.EventHandler(this.deleteExpoButton_Click);
            // 
            // editExpoButton
            // 
            this.editExpoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editExpoButton.Location = new System.Drawing.Point(528, 737);
            this.editExpoButton.Name = "editExpoButton";
            this.editExpoButton.Size = new System.Drawing.Size(107, 33);
            this.editExpoButton.TabIndex = 3;
            this.editExpoButton.Text = "карандаш";
            this.editExpoButton.UseVisualStyleBackColor = true;
            this.editExpoButton.Click += new System.EventHandler(this.editExpoButton_Click);
            // 
            // ExpoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.editExpoButton);
            this.Controls.Add(this.deleteExpoButton);
            this.Controls.Add(this.addExpoButton);
            this.Controls.Add(this.listExpoBox);
            this.Name = "ExpoListForm";
            this.Text = "Список экспозиций";
            this.Load += new System.EventHandler(this.ExpoListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listExpoBox;
        private System.Windows.Forms.Button addExpoButton;
        private System.Windows.Forms.Button deleteExpoButton;
        private System.Windows.Forms.Button editExpoButton;
    }
}
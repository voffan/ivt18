
namespace gallery
{
    partial class ExpoViewForm
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
            this.expoInfoLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expoInfoLabel2 = new System.Windows.Forms.Label();
            this.expoPicturesBox = new System.Windows.Forms.ListBox();
            this.expoInfoLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // expoInfoLabel1
            // 
            this.expoInfoLabel1.AutoSize = true;
            this.expoInfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expoInfoLabel1.Location = new System.Drawing.Point(34, 88);
            this.expoInfoLabel1.Name = "expoInfoLabel1";
            this.expoInfoLabel1.Size = new System.Drawing.Size(182, 20);
            this.expoInfoLabel1.TabIndex = 0;
            this.expoInfoLabel1.Text = "Название экспозиции: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация о выставке";
            // 
            // expoInfoLabel2
            // 
            this.expoInfoLabel2.AutoSize = true;
            this.expoInfoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expoInfoLabel2.Location = new System.Drawing.Point(34, 238);
            this.expoInfoLabel2.Name = "expoInfoLabel2";
            this.expoInfoLabel2.Size = new System.Drawing.Size(161, 20);
            this.expoInfoLabel2.TabIndex = 2;
            this.expoInfoLabel2.Text = "Место проведения: ";
            // 
            // expoPicturesBox
            // 
            this.expoPicturesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expoPicturesBox.FormattingEnabled = true;
            this.expoPicturesBox.ItemHeight = 20;
            this.expoPicturesBox.Location = new System.Drawing.Point(526, 88);
            this.expoPicturesBox.Name = "expoPicturesBox";
            this.expoPicturesBox.Size = new System.Drawing.Size(399, 404);
            this.expoPicturesBox.TabIndex = 3;
            // 
            // expoInfoLabel3
            // 
            this.expoInfoLabel3.AutoSize = true;
            this.expoInfoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expoInfoLabel3.Location = new System.Drawing.Point(34, 373);
            this.expoInfoLabel3.Name = "expoInfoLabel3";
            this.expoInfoLabel3.Size = new System.Drawing.Size(66, 20);
            this.expoInfoLabel3.TabIndex = 4;
            this.expoInfoLabel3.Text = "Время: ";
            // 
            // ExpoViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 569);
            this.Controls.Add(this.expoInfoLabel3);
            this.Controls.Add(this.expoPicturesBox);
            this.Controls.Add(this.expoInfoLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expoInfoLabel1);
            this.Name = "ExpoViewForm";
            this.Text = "ExpoViewForm";
            this.Load += new System.EventHandler(this.ExpoViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expoInfoLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label expoInfoLabel2;
        private System.Windows.Forms.ListBox expoPicturesBox;
        private System.Windows.Forms.Label expoInfoLabel3;
    }
}
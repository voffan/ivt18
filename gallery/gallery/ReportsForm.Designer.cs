namespace gallery
{
    partial class ReportsForm
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
            this.reportsGridView = new System.Windows.Forms.DataGridView();
            this.downloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsGridView
            // 
            this.reportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGridView.Location = new System.Drawing.Point(41, 78);
            this.reportsGridView.Name = "reportsGridView";
            this.reportsGridView.RowTemplate.Height = 24;
            this.reportsGridView.Size = new System.Drawing.Size(895, 513);
            this.reportsGridView.TabIndex = 0;
            this.reportsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsGridView_CellContentClick);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(808, 24);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(110, 23);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Загрузить";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 639);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.reportsGridView);
            this.Name = "ReportsForm";
            this.Text = "JournalForm";
            this.Load += new System.EventHandler(this.reportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportsGridView;
        private System.Windows.Forms.Button downloadButton;
    }
}
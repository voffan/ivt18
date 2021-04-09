
namespace carton
{
    partial class DirectorForm
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
            this.ApplyPlanButton = new System.Windows.Forms.Button();
            this.ApproveCompletionButton = new System.Windows.Forms.Button();
            this.planGridView = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyPlanButton
            // 
            this.ApplyPlanButton.Location = new System.Drawing.Point(12, 526);
            this.ApplyPlanButton.Name = "ApplyPlanButton";
            this.ApplyPlanButton.Size = new System.Drawing.Size(144, 23);
            this.ApplyPlanButton.TabIndex = 1;
            this.ApplyPlanButton.Text = "Утвердить план";
            this.ApplyPlanButton.UseVisualStyleBackColor = true;
            this.ApplyPlanButton.Click += new System.EventHandler(this.ApplyPlanButton_Click);
            // 
            // ApproveCompletionButton
            // 
            this.ApproveCompletionButton.Location = new System.Drawing.Point(578, 526);
            this.ApproveCompletionButton.Name = "ApproveCompletionButton";
            this.ApproveCompletionButton.Size = new System.Drawing.Size(194, 23);
            this.ApproveCompletionButton.TabIndex = 2;
            this.ApproveCompletionButton.Text = "Подтвердить выполнение";
            this.ApproveCompletionButton.UseVisualStyleBackColor = true;
            this.ApproveCompletionButton.Click += new System.EventHandler(this.ApproveCompletionButton_Click);
            // 
            // planGridView
            // 
            this.planGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planGridView.Location = new System.Drawing.Point(15, 50);
            this.planGridView.MultiSelect = false;
            this.planGridView.Name = "planGridView";
            this.planGridView.Size = new System.Drawing.Size(750, 414);
            this.planGridView.TabIndex = 3;
            this.planGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planGridView_CellContentClick);
            this.planGridView.SelectionChanged += new System.EventHandler(this.planGridView_SelectionChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(37, 13);
            this.header.TabIndex = 4;
            this.header.Text = "debug";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(324, 526);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.planGridView);
            this.Controls.Add(this.ApproveCompletionButton);
            this.Controls.Add(this.ApplyPlanButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ApplyPlanButton;
        private System.Windows.Forms.Button ApproveCompletionButton;
        private System.Windows.Forms.DataGridView planGridView;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button ResetButton;
    }
}
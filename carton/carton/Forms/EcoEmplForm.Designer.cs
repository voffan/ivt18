
namespace carton
{
    partial class EcoEmplForm
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.plannedGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyPlanButton
            // 
            this.ApplyPlanButton.Location = new System.Drawing.Point(448, 526);
            this.ApplyPlanButton.Name = "ApplyPlanButton";
            this.ApplyPlanButton.Size = new System.Drawing.Size(155, 23);
            this.ApplyPlanButton.TabIndex = 1;
            this.ApplyPlanButton.Text = "Утвердить план";
            this.ApplyPlanButton.UseVisualStyleBackColor = true;
            this.ApplyPlanButton.Click += new System.EventHandler(this.ApplyPlanButton_Click);
            // 
            // ApproveCompletionButton
            // 
            this.ApproveCompletionButton.Location = new System.Drawing.Point(609, 526);
            this.ApproveCompletionButton.Name = "ApproveCompletionButton";
            this.ApproveCompletionButton.Size = new System.Drawing.Size(155, 23);
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
            this.planGridView.Size = new System.Drawing.Size(750, 204);
            this.planGridView.TabIndex = 3;
            this.planGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planGridView_CellContentClick);
            this.planGridView.SelectionChanged += new System.EventHandler(this.planGridView_SelectionChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(86, 13);
            this.header.TabIndex = 4;
            this.header.Text = "Список планов:";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(287, 526);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(155, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(12, 526);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Выйти";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // plannedGridView
            // 
            this.plannedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plannedGridView.Location = new System.Drawing.Point(15, 302);
            this.plannedGridView.Name = "plannedGridView";
            this.plannedGridView.Size = new System.Drawing.Size(750, 204);
            this.plannedGridView.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Запланировано:";
            // 
            // EcoEmplForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plannedGridView);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.planGridView);
            this.Controls.Add(this.ApproveCompletionButton);
            this.Controls.Add(this.ApplyPlanButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EcoEmplForm";
            this.Text = "EcoEmplForm";
            this.Load += new System.EventHandler(this.EcoEmplForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ApplyPlanButton;
        private System.Windows.Forms.Button ApproveCompletionButton;
        private System.Windows.Forms.DataGridView planGridView;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView plannedGridView;
        private System.Windows.Forms.Label label1;
    }
}
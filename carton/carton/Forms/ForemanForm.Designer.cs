
namespace carton
{
    partial class ForemanForm
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
            this.GetPlanButton = new System.Windows.Forms.Button();
            this.ShiftRepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetPlanButton
            // 
            this.GetPlanButton.Location = new System.Drawing.Point(640, 240);
            this.GetPlanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetPlanButton.Name = "GetPlanButton";
            this.GetPlanButton.Size = new System.Drawing.Size(259, 47);
            this.GetPlanButton.TabIndex = 0;
            this.GetPlanButton.Text = "Получить план";
            this.GetPlanButton.UseVisualStyleBackColor = true;
            this.GetPlanButton.Click += new System.EventHandler(this.GetPlanButton_Click);
            // 
            // ShiftRepButton
            // 
            this.ShiftRepButton.Location = new System.Drawing.Point(187, 240);
            this.ShiftRepButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShiftRepButton.Name = "ShiftRepButton";
            this.ShiftRepButton.Size = new System.Drawing.Size(237, 47);
            this.ShiftRepButton.TabIndex = 1;
            this.ShiftRepButton.Text = "Управление отчетом о смене смены";
            this.ShiftRepButton.UseVisualStyleBackColor = true;
            this.ShiftRepButton.Click += new System.EventHandler(this.ShiftRepButton_Click);
            // 
            // ForemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ShiftRepButton);
            this.Controls.Add(this.GetPlanButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForemanForm";
            this.Text = "ForemanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetPlanButton;
        private System.Windows.Forms.Button ShiftRepButton;
    }
}

namespace carton
{
    partial class EcoForm
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
            this.createPlanButton = new System.Windows.Forms.Button();
            this.editPlanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.planGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createPlanButton
            // 
            this.createPlanButton.Location = new System.Drawing.Point(12, 526);
            this.createPlanButton.Name = "createPlanButton";
            this.createPlanButton.Size = new System.Drawing.Size(192, 23);
            this.createPlanButton.TabIndex = 0;
            this.createPlanButton.Text = "Создать план";
            this.createPlanButton.UseVisualStyleBackColor = true;
            this.createPlanButton.Click += new System.EventHandler(this.createPlanButton_Click);
            // 
            // editPlanButton
            // 
            this.editPlanButton.Location = new System.Drawing.Point(579, 526);
            this.editPlanButton.Name = "editPlanButton";
            this.editPlanButton.Size = new System.Drawing.Size(193, 23);
            this.editPlanButton.TabIndex = 1;
            this.editPlanButton.Text = "Редактировать план";
            this.editPlanButton.UseVisualStyleBackColor = true;
            this.editPlanButton.Click += new System.EventHandler(this.editPlanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сотрудник экономического отдела";
            // 
            // planGridView
            // 
            this.planGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planGridView.Location = new System.Drawing.Point(10, 38);
            this.planGridView.Name = "planGridView";
            this.planGridView.Size = new System.Drawing.Size(760, 463);
            this.planGridView.TabIndex = 3;
            // 
            // EcoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.planGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editPlanButton);
            this.Controls.Add(this.createPlanButton);
            this.Name = "EcoForm";
            this.Text = "EcoForm";
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPlanButton;
        private System.Windows.Forms.Button editPlanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView planGridView;
    }
}
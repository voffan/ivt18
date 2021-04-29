
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
            this.planGridView = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.plannedGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.editSavePlanButton = new System.Windows.Forms.Button();
            this.createPlanBbutton = new System.Windows.Forms.Button();
            this.deletePlan = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedGridView)).BeginInit();
            this.SuspendLayout();
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
            // editSavePlanButton
            // 
            this.editSavePlanButton.Location = new System.Drawing.Point(638, 526);
            this.editSavePlanButton.Name = "editSavePlanButton";
            this.editSavePlanButton.Size = new System.Drawing.Size(126, 23);
            this.editSavePlanButton.TabIndex = 9;
            this.editSavePlanButton.Text = "Изменить план";
            this.editSavePlanButton.UseVisualStyleBackColor = true;
            this.editSavePlanButton.Click += new System.EventHandler(this.editSavePlanButton_Click);
            // 
            // createPlanBbutton
            // 
            this.createPlanBbutton.Location = new System.Drawing.Point(506, 526);
            this.createPlanBbutton.Name = "createPlanBbutton";
            this.createPlanBbutton.Size = new System.Drawing.Size(126, 23);
            this.createPlanBbutton.TabIndex = 10;
            this.createPlanBbutton.Text = "Создать план";
            this.createPlanBbutton.UseVisualStyleBackColor = true;
            this.createPlanBbutton.Click += new System.EventHandler(this.createPlanBbutton_Click);
            // 
            // deletePlan
            // 
            this.deletePlan.Location = new System.Drawing.Point(375, 526);
            this.deletePlan.Name = "deletePlan";
            this.deletePlan.Size = new System.Drawing.Size(125, 23);
            this.deletePlan.TabIndex = 11;
            this.deletePlan.Text = "Удалить план";
            this.deletePlan.UseVisualStyleBackColor = true;
            this.deletePlan.Click += new System.EventHandler(this.deletePlan_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(285, 526);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // EcoEmplForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.deletePlan);
            this.Controls.Add(this.createPlanBbutton);
            this.Controls.Add(this.editSavePlanButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plannedGridView);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.planGridView);
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
        private System.Windows.Forms.DataGridView planGridView;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView plannedGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editSavePlanButton;
        private System.Windows.Forms.Button createPlanBbutton;
        private System.Windows.Forms.Button deletePlan;
        private System.Windows.Forms.Button exportButton;
    }
}
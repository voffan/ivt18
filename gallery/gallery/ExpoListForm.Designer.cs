
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
            this.addExpoButton = new System.Windows.Forms.Button();
            this.deleteExpoButton = new System.Windows.Forms.Button();
            this.editExpoButton = new System.Windows.Forms.Button();
            this.expoDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.expoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addExpoButton
            // 
            this.addExpoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addExpoButton.Location = new System.Drawing.Point(915, 508);
            this.addExpoButton.Margin = new System.Windows.Forms.Padding(4);
            this.addExpoButton.Name = "addExpoButton";
            this.addExpoButton.Size = new System.Drawing.Size(53, 41);
            this.addExpoButton.TabIndex = 1;
            this.addExpoButton.Text = "+";
            this.addExpoButton.UseVisualStyleBackColor = true;
            this.addExpoButton.Click += new System.EventHandler(this.addExpoButton_Click);
            // 
            // deleteExpoButton
            // 
            this.deleteExpoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteExpoButton.Location = new System.Drawing.Point(45, 508);
            this.deleteExpoButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteExpoButton.Name = "deleteExpoButton";
            this.deleteExpoButton.Size = new System.Drawing.Size(156, 41);
            this.deleteExpoButton.TabIndex = 2;
            this.deleteExpoButton.Text = "мусорка";
            this.deleteExpoButton.UseVisualStyleBackColor = true;
            this.deleteExpoButton.Click += new System.EventHandler(this.deleteExpoButton_Click);
            // 
            // editExpoButton
            // 
            this.editExpoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editExpoButton.Location = new System.Drawing.Point(697, 508);
            this.editExpoButton.Margin = new System.Windows.Forms.Padding(4);
            this.editExpoButton.Name = "editExpoButton";
            this.editExpoButton.Size = new System.Drawing.Size(143, 41);
            this.editExpoButton.TabIndex = 3;
            this.editExpoButton.Text = "карандаш";
            this.editExpoButton.UseVisualStyleBackColor = true;
            this.editExpoButton.Click += new System.EventHandler(this.editExpoButton_Click);
            // 
            // expoDataGrid
            // 
            this.expoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expoDataGrid.Location = new System.Drawing.Point(52, 55);
            this.expoDataGrid.Name = "expoDataGrid";
            this.expoDataGrid.RowHeadersWidth = 51;
            this.expoDataGrid.RowTemplate.Height = 24;
            this.expoDataGrid.Size = new System.Drawing.Size(915, 414);
            this.expoDataGrid.TabIndex = 4;
            this.expoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expoDataGrid_CellContentClick);
            this.expoDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expoDataGrid_CellDoubleClick);
            this.expoDataGrid.Click += new System.EventHandler(this.ExpoListForm_Load);
            // 
            // ExpoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 593);
            this.Controls.Add(this.expoDataGrid);
            this.Controls.Add(this.editExpoButton);
            this.Controls.Add(this.deleteExpoButton);
            this.Controls.Add(this.addExpoButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpoListForm";
            this.Text = "Список экспозиций";
            this.Load += new System.EventHandler(this.ExpoListForm_Load);
            this.Click += new System.EventHandler(this.ExpoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addExpoButton;
        private System.Windows.Forms.Button deleteExpoButton;
        private System.Windows.Forms.Button editExpoButton;
        private System.Windows.Forms.DataGridView expoDataGrid;
    }
}
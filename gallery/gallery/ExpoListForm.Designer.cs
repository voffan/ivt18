
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
            this.expoDataGrid = new System.Windows.Forms.DataGridView();
            this.editExpoButton = new System.Windows.Forms.Button();
            this.deleteExpoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addExpoButton
            // 
            this.addExpoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addExpoButton.Location = new System.Drawing.Point(706, 66);
            this.addExpoButton.Name = "addExpoButton";
            this.addExpoButton.Size = new System.Drawing.Size(30, 32);
            this.addExpoButton.TabIndex = 1;
            this.addExpoButton.Text = "+";
            this.addExpoButton.UseVisualStyleBackColor = true;
            this.addExpoButton.Click += new System.EventHandler(this.addExpoButton_Click);
            // 
            // expoDataGrid
            // 
            this.expoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expoDataGrid.Location = new System.Drawing.Point(39, 66);
            this.expoDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expoDataGrid.Name = "expoDataGrid";
            this.expoDataGrid.RowHeadersWidth = 51;
            this.expoDataGrid.RowTemplate.Height = 24;
            this.expoDataGrid.Size = new System.Drawing.Size(642, 379);
            this.expoDataGrid.TabIndex = 4;
            this.expoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expoDataGrid_CellContentClick);
            this.expoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expoDataGrid_CellContentClick_1);
            this.expoDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expoDataGrid_CellDoubleClick);
            // 
            // editExpoButton
            // 
            this.editExpoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editExpoButton.Image = global::gallery.Properties.Resources.pencil;
            this.editExpoButton.Location = new System.Drawing.Point(706, 114);
            this.editExpoButton.Name = "editExpoButton";
            this.editExpoButton.Size = new System.Drawing.Size(30, 32);
            this.editExpoButton.TabIndex = 3;
            this.editExpoButton.UseVisualStyleBackColor = true;
            this.editExpoButton.Click += new System.EventHandler(this.editExpoButton_Click);
            // 
            // deleteExpoButton
            // 
            this.deleteExpoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteExpoButton.Image = global::gallery.Properties.Resources.trash__1_1;
            this.deleteExpoButton.Location = new System.Drawing.Point(706, 161);
            this.deleteExpoButton.Name = "deleteExpoButton";
            this.deleteExpoButton.Size = new System.Drawing.Size(30, 32);
            this.deleteExpoButton.TabIndex = 2;
            this.deleteExpoButton.UseVisualStyleBackColor = true;
            this.deleteExpoButton.Click += new System.EventHandler(this.deleteExpoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список выставок:";
            // 
            // ExpoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expoDataGrid);
            this.Controls.Add(this.editExpoButton);
            this.Controls.Add(this.deleteExpoButton);
            this.Controls.Add(this.addExpoButton);
            this.Name = "ExpoListForm";
            this.Text = "Список экспозиций";
            this.Activated += new System.EventHandler(this.ExpoListForm_Load);
            this.Load += new System.EventHandler(this.ExpoListForm_Load);
            this.Click += new System.EventHandler(this.ExpoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addExpoButton;
        private System.Windows.Forms.Button deleteExpoButton;
        private System.Windows.Forms.Button editExpoButton;
        private System.Windows.Forms.DataGridView expoDataGrid;
        private System.Windows.Forms.Label label1;
    }
}
namespace carton
{
    partial class StorageEmp
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
            this.buttonOpenSendProd = new System.Windows.Forms.Button();
            this.buttonOpenReceiveProd = new System.Windows.Forms.Button();
            this.labelStorageEmpForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenSendProd
            // 
            this.buttonOpenSendProd.Location = new System.Drawing.Point(128, 281);
            this.buttonOpenSendProd.Name = "buttonOpenSendProd";
            this.buttonOpenSendProd.Size = new System.Drawing.Size(176, 46);
            this.buttonOpenSendProd.TabIndex = 0;
            this.buttonOpenSendProd.Text = "Отправить продукцию";
            this.buttonOpenSendProd.UseVisualStyleBackColor = true;
            // 
            // buttonOpenReceiveProd
            // 
            this.buttonOpenReceiveProd.Location = new System.Drawing.Point(495, 281);
            this.buttonOpenReceiveProd.Name = "buttonOpenReceiveProd";
            this.buttonOpenReceiveProd.Size = new System.Drawing.Size(176, 46);
            this.buttonOpenReceiveProd.TabIndex = 1;
            this.buttonOpenReceiveProd.Text = "Принять продукцию";
            this.buttonOpenReceiveProd.UseVisualStyleBackColor = true;
            // 
            // labelStorageEmpForm
            // 
            this.labelStorageEmpForm.AutoSize = true;
            this.labelStorageEmpForm.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
            this.labelStorageEmpForm.Location = new System.Drawing.Point(285, 139);
            this.labelStorageEmpForm.Name = "labelStorageEmpForm";
            this.labelStorageEmpForm.Size = new System.Drawing.Size(223, 38);
            this.labelStorageEmpForm.TabIndex = 2;
            this.labelStorageEmpForm.Text = "Хранилище";
            // 
            // StorageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStorageEmpForm);
            this.Controls.Add(this.buttonOpenReceiveProd);
            this.Controls.Add(this.buttonOpenSendProd);
            this.Name = "StorageEmp";
            this.Text = "StorageEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenSendProd;
        private System.Windows.Forms.Button buttonOpenReceiveProd;
        private System.Windows.Forms.Label labelStorageEmpForm;
    }
}
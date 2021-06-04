
namespace grades
{
    partial class ChooseAddUserMethodForm
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
            this.addMultipleutton = new System.Windows.Forms.Button();
            this.addSingleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMultipleutton
            // 
            this.addMultipleutton.FlatAppearance.BorderSize = 0;
            this.addMultipleutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMultipleutton.Location = new System.Drawing.Point(16, 15);
            this.addMultipleutton.Margin = new System.Windows.Forms.Padding(4);
            this.addMultipleutton.Name = "addMultipleutton";
            this.addMultipleutton.Size = new System.Drawing.Size(412, 28);
            this.addMultipleutton.TabIndex = 0;
            this.addMultipleutton.Text = "Добавление пользователей из фалйа";
            this.addMultipleutton.UseVisualStyleBackColor = true;
            this.addMultipleutton.Click += new System.EventHandler(this.addMultipleButton_Click);
            // 
            // addSingleButton
            // 
            this.addSingleButton.FlatAppearance.BorderSize = 0;
            this.addSingleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSingleButton.Location = new System.Drawing.Point(16, 55);
            this.addSingleButton.Margin = new System.Windows.Forms.Padding(4);
            this.addSingleButton.Name = "addSingleButton";
            this.addSingleButton.Size = new System.Drawing.Size(412, 28);
            this.addSingleButton.TabIndex = 1;
            this.addSingleButton.Text = "Добавление одного пользователя";
            this.addSingleButton.UseVisualStyleBackColor = true;
            this.addSingleButton.Click += new System.EventHandler(this.addSingleButton_Click);
            // 
            // ChooseAddUserMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 90);
            this.Controls.Add(this.addSingleButton);
            this.Controls.Add(this.addMultipleutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChooseAddUserMethodForm";
            this.Text = "Способа добавления";
            this.Load += new System.EventHandler(this.ChooseAddUserMethodForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMultipleutton;
        private System.Windows.Forms.Button addSingleButton;
    }
}
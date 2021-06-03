namespace SportApp.Panel
{
    partial class EditProfile
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.Gray;
            this.PanelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1200, 1040);
            this.PanelContainer.TabIndex = 11;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EditProfile";
            this.Size = new System.Drawing.Size(1200, 1040);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContainer;
    }
}

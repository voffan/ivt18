
namespace gallery
{
    partial class MainPageForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.journalButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Список картин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Список работников";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Картины на реставрации";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // journalButton
            // 
            this.journalButton.Location = new System.Drawing.Point(422, 158);
            this.journalButton.Margin = new System.Windows.Forms.Padding(4);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(196, 28);
            this.journalButton.TabIndex = 2;
            this.journalButton.Text = "Journal";
            this.journalButton.UseVisualStyleBackColor = true;
            this.journalButton.Click += new System.EventHandler(this.journalButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(422, 101);
            this.reportButton.Margin = new System.Windows.Forms.Padding(4);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(196, 28);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.journalButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPageForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.Button reportButton;
    }
}


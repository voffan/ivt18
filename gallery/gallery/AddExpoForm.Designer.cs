
namespace gallery
{
    partial class AddExpoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.placeBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picturesBox = new System.Windows.Forms.ListBox();
            this.expoPicturesBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(101, 135);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(570, 22);
            this.nameBox.TabIndex = 1;
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(101, 200);
            this.placeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(570, 22);
            this.placeBox.TabIndex = 2;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(101, 276);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(265, 22);
            this.startDatePicker.TabIndex = 3;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(406, 276);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(265, 22);
            this.endDatePicker.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(921, 647);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Город";
            // 
            // picturesBox
            // 
            this.picturesBox.FormattingEnabled = true;
            this.picturesBox.ItemHeight = 16;
            this.picturesBox.Location = new System.Drawing.Point(101, 367);
            this.picturesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picturesBox.Name = "picturesBox";
            this.picturesBox.Size = new System.Drawing.Size(337, 308);
            this.picturesBox.TabIndex = 8;
            this.picturesBox.DoubleClick += new System.EventHandler(this.picturesBox_DoubleClick);
            // 
            // expoPicturesBox
            // 
            this.expoPicturesBox.FormattingEnabled = true;
            this.expoPicturesBox.ItemHeight = 16;
            this.expoPicturesBox.Location = new System.Drawing.Point(500, 367);
            this.expoPicturesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expoPicturesBox.Name = "expoPicturesBox";
            this.expoPicturesBox.Size = new System.Drawing.Size(337, 308);
            this.expoPicturesBox.TabIndex = 9;
            this.expoPicturesBox.DoubleClick += new System.EventHandler(this.expoPicturesBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(458, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = ">>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Время проведения";
            // 
            // AddExpoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 743);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expoPicturesBox);
            this.Controls.Add(this.picturesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddExpoForm";
            this.Text = "Новая экспозиция";
            this.Load += new System.EventHandler(this.AddExpoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox placeBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox picturesBox;
        private System.Windows.Forms.ListBox expoPicturesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
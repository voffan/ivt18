
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
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(76, 110);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(428, 20);
            this.nameBox.TabIndex = 1;
            // 
            // placeBox
            // 
            this.placeBox.Location = new System.Drawing.Point(76, 162);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(428, 20);
            this.placeBox.TabIndex = 2;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(76, 224);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 3;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(304, 224);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(691, 526);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Город";
            // 
            // picturesBox
            // 
            this.picturesBox.FormattingEnabled = true;
            this.picturesBox.Location = new System.Drawing.Point(76, 298);
            this.picturesBox.Name = "picturesBox";
            this.picturesBox.Size = new System.Drawing.Size(254, 251);
            this.picturesBox.TabIndex = 8;
            this.picturesBox.DoubleClick += new System.EventHandler(this.picturesBox_DoubleClick);
            // 
            // expoPicturesBox
            // 
            this.expoPicturesBox.FormattingEnabled = true;
            this.expoPicturesBox.Location = new System.Drawing.Point(375, 298);
            this.expoPicturesBox.Name = "expoPicturesBox";
            this.expoPicturesBox.Size = new System.Drawing.Size(254, 251);
            this.expoPicturesBox.TabIndex = 9;
            this.expoPicturesBox.SelectedIndexChanged += new System.EventHandler(this.expoPicturesBox_SelectedIndexChanged);
            this.expoPicturesBox.DoubleClick += new System.EventHandler(this.expoPicturesBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(344, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = ">>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Время проведения";
            // 
            // AddExpoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
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
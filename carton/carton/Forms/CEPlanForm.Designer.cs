
namespace carton
{
    partial class CEPlanForm
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
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.productAmountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productListBox = new System.Windows.Forms.ListBox();
            this.header = new System.Windows.Forms.Label();
            this.planNameLabel = new System.Windows.Forms.Label();
            this.planNameTextBox = new System.Windows.Forms.TextBox();
            this.planDateLabel = new System.Windows.Forms.Label();
            this.planDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.planStatusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.plannedListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(677, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 415);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(90, 23);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // productAmountTextBox
            // 
            this.productAmountTextBox.Location = new System.Drawing.Point(342, 242);
            this.productAmountTextBox.Name = "productAmountTextBox";
            this.productAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.productAmountTextBox.TabIndex = 4;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(342, 223);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(66, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Количество";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(342, 91);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(49, 13);
            this.productLabel.TabIndex = 6;
            this.productLabel.Text = "Продукт";
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.Location = new System.Drawing.Point(342, 114);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(120, 95);
            this.productListBox.TabIndex = 3;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(110, 13);
            this.header.TabIndex = 10;
            this.header.Text = "Что-то пошло не так";
            // 
            // planNameLabel
            // 
            this.planNameLabel.AutoSize = true;
            this.planNameLabel.Location = new System.Drawing.Point(37, 78);
            this.planNameLabel.Name = "planNameLabel";
            this.planNameLabel.Size = new System.Drawing.Size(65, 13);
            this.planNameLabel.TabIndex = 11;
            this.planNameLabel.Text = "Имя плана:";
            // 
            // planNameTextBox
            // 
            this.planNameTextBox.Location = new System.Drawing.Point(40, 103);
            this.planNameTextBox.Name = "planNameTextBox";
            this.planNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.planNameTextBox.TabIndex = 1;
            // 
            // planDateLabel
            // 
            this.planDateLabel.AutoSize = true;
            this.planDateLabel.Location = new System.Drawing.Point(37, 144);
            this.planDateLabel.Name = "planDateLabel";
            this.planDateLabel.Size = new System.Drawing.Size(107, 13);
            this.planDateLabel.TabIndex = 13;
            this.planDateLabel.Text = "Дата начала плана:";
            // 
            // planDateTimePicker
            // 
            this.planDateTimePicker.Location = new System.Drawing.Point(40, 175);
            this.planDateTimePicker.Name = "planDateTimePicker";
            this.planDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.planDateTimePicker.TabIndex = 2;
            // 
            // planStatusLabel
            // 
            this.planStatusLabel.AutoSize = true;
            this.planStatusLabel.Location = new System.Drawing.Point(37, 223);
            this.planStatusLabel.Name = "planStatusLabel";
            this.planStatusLabel.Size = new System.Drawing.Size(77, 13);
            this.planStatusLabel.TabIndex = 15;
            this.planStatusLabel.Text = "Статус плана:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(40, 254);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 16;
            // 
            // plannedListBox
            // 
            this.plannedListBox.FormattingEnabled = true;
            this.plannedListBox.Location = new System.Drawing.Point(547, 114);
            this.plannedListBox.Name = "plannedListBox";
            this.plannedListBox.Size = new System.Drawing.Size(120, 95);
            this.plannedListBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "второй вариант";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Количество";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(647, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Продукт";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(524, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "список продукт - количество";
            // 
            // CEPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plannedListBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.planStatusLabel);
            this.Controls.Add(this.planDateTimePicker);
            this.Controls.Add(this.planDateLabel);
            this.Controls.Add(this.planNameTextBox);
            this.Controls.Add(this.planNameLabel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productAmountTextBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Name = "CEPlanForm";
            this.Text = "CEPlan";
            this.Load += new System.EventHandler(this.CEPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox productAmountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label planNameLabel;
        private System.Windows.Forms.TextBox planNameTextBox;
        private System.Windows.Forms.Label planDateLabel;
        private System.Windows.Forms.DateTimePicker planDateTimePicker;
        private System.Windows.Forms.Label planStatusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ListBox plannedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}
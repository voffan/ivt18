
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
            this.planNameLabel = new System.Windows.Forms.Label();
            this.planNameTextBox = new System.Windows.Forms.TextBox();
            this.planDateLabel = new System.Windows.Forms.Label();
            this.planStatusLabel = new System.Windows.Forms.Label();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.header = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prodLineIdTextBox = new System.Windows.Forms.TextBox();
            this.planDateTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(341, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(698, 415);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(90, 23);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // planNameLabel
            // 
            this.planNameLabel.AutoSize = true;
            this.planNameLabel.Location = new System.Drawing.Point(294, 61);
            this.planNameLabel.Name = "planNameLabel";
            this.planNameLabel.Size = new System.Drawing.Size(65, 13);
            this.planNameLabel.TabIndex = 11;
            this.planNameLabel.Text = "Имя плана:";
            // 
            // planNameTextBox
            // 
            this.planNameTextBox.Location = new System.Drawing.Point(297, 86);
            this.planNameTextBox.Name = "planNameTextBox";
            this.planNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.planNameTextBox.TabIndex = 1;
            this.planNameTextBox.TextChanged += new System.EventHandler(this.planNameTextBox_TextChanged);
            // 
            // planDateLabel
            // 
            this.planDateLabel.AutoSize = true;
            this.planDateLabel.Location = new System.Drawing.Point(294, 127);
            this.planDateLabel.Name = "planDateLabel";
            this.planDateLabel.Size = new System.Drawing.Size(107, 13);
            this.planDateLabel.TabIndex = 13;
            this.planDateLabel.Text = "Дата начала плана:";
            // 
            // planStatusLabel
            // 
            this.planStatusLabel.AutoSize = true;
            this.planStatusLabel.Location = new System.Drawing.Point(294, 206);
            this.planStatusLabel.Name = "planStatusLabel";
            this.planStatusLabel.Size = new System.Drawing.Size(77, 13);
            this.planStatusLabel.TabIndex = 15;
            this.planStatusLabel.Text = "Статус плана:";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(0, 13);
            this.header.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID линии продукции:";
            // 
            // prodLineIdTextBox
            // 
            this.prodLineIdTextBox.Location = new System.Drawing.Point(297, 310);
            this.prodLineIdTextBox.Name = "prodLineIdTextBox";
            this.prodLineIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.prodLineIdTextBox.TabIndex = 25;
            // 
            // planDateTextBox
            // 
            this.planDateTextBox.Location = new System.Drawing.Point(297, 171);
            this.planDateTextBox.Name = "planDateTextBox";
            this.planDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.planDateTextBox.TabIndex = 26;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(297, 240);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 27;
            // 
            // CEPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.planDateTextBox);
            this.Controls.Add(this.prodLineIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.planStatusLabel);
            this.Controls.Add(this.planDateLabel);
            this.Controls.Add(this.planNameTextBox);
            this.Controls.Add(this.planNameLabel);
            this.Controls.Add(this.header);
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
        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.Label planNameLabel;
        private System.Windows.Forms.TextBox planNameTextBox;
        private System.Windows.Forms.Label planDateLabel;
        private System.Windows.Forms.Label planStatusLabel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodLineIdTextBox;
        private System.Windows.Forms.TextBox planDateTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}
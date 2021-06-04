namespace grades
{
    partial class AddUser
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
            this.guideText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.personFirstNameBox = new System.Windows.Forms.TextBox();
            this.personSurNameBox = new System.Windows.Forms.TextBox();
            this.personMiddleNameBox = new System.Windows.Forms.TextBox();
            this.personPhoneNumberBox = new System.Windows.Forms.TextBox();
            this.personHomeAddressBox = new System.Windows.Forms.TextBox();
            this.cancelAddingUser = new System.Windows.Forms.Button();
            this.applyAddingUser = new System.Windows.Forms.Button();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // guideText
            // 
            this.guideText.AutoSize = true;
            this.guideText.Location = new System.Drawing.Point(17, 16);
            this.guideText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guideText.Name = "guideText";
            this.guideText.Size = new System.Drawing.Size(224, 17);
            this.guideText.TabIndex = 0;
            this.guideText.Text = "Введите следующие параметры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Роль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Контактный номер:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Домашний адрес:";
            // 
            // personFirstNameBox
            // 
            this.personFirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personFirstNameBox.Location = new System.Drawing.Point(176, 47);
            this.personFirstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.personFirstNameBox.Name = "personFirstNameBox";
            this.personFirstNameBox.Size = new System.Drawing.Size(347, 15);
            this.personFirstNameBox.TabIndex = 7;
            this.personFirstNameBox.TextChanged += new System.EventHandler(this.personFirstNameBox_TextChanged);
            // 
            // personSurNameBox
            // 
            this.personSurNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personSurNameBox.Location = new System.Drawing.Point(176, 80);
            this.personSurNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.personSurNameBox.Name = "personSurNameBox";
            this.personSurNameBox.Size = new System.Drawing.Size(347, 15);
            this.personSurNameBox.TabIndex = 8;
            // 
            // personMiddleNameBox
            // 
            this.personMiddleNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personMiddleNameBox.Location = new System.Drawing.Point(176, 113);
            this.personMiddleNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.personMiddleNameBox.Name = "personMiddleNameBox";
            this.personMiddleNameBox.Size = new System.Drawing.Size(347, 15);
            this.personMiddleNameBox.TabIndex = 9;
            this.personMiddleNameBox.TextChanged += new System.EventHandler(this.personMiddleNameBox_TextChanged);
            // 
            // personPhoneNumberBox
            // 
            this.personPhoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personPhoneNumberBox.Location = new System.Drawing.Point(176, 245);
            this.personPhoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.personPhoneNumberBox.Name = "personPhoneNumberBox";
            this.personPhoneNumberBox.Size = new System.Drawing.Size(347, 15);
            this.personPhoneNumberBox.TabIndex = 10;
            this.personPhoneNumberBox.TextChanged += new System.EventHandler(this.personPhoneNumberBox_TextChanged);
            // 
            // personHomeAddressBox
            // 
            this.personHomeAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personHomeAddressBox.Location = new System.Drawing.Point(176, 315);
            this.personHomeAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.personHomeAddressBox.Name = "personHomeAddressBox";
            this.personHomeAddressBox.Size = new System.Drawing.Size(347, 15);
            this.personHomeAddressBox.TabIndex = 11;
            // 
            // cancelAddingUser
            // 
            this.cancelAddingUser.FlatAppearance.BorderSize = 0;
            this.cancelAddingUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddingUser.Location = new System.Drawing.Point(421, 359);
            this.cancelAddingUser.Margin = new System.Windows.Forms.Padding(4);
            this.cancelAddingUser.Name = "cancelAddingUser";
            this.cancelAddingUser.Size = new System.Drawing.Size(100, 28);
            this.cancelAddingUser.TabIndex = 13;
            this.cancelAddingUser.Text = "Отмена";
            this.cancelAddingUser.UseVisualStyleBackColor = true;
            this.cancelAddingUser.Click += new System.EventHandler(this.cancelAddingUser_Click);
            // 
            // applyAddingUser
            // 
            this.applyAddingUser.FlatAppearance.BorderSize = 0;
            this.applyAddingUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyAddingUser.Location = new System.Drawing.Point(313, 359);
            this.applyAddingUser.Margin = new System.Windows.Forms.Padding(4);
            this.applyAddingUser.Name = "applyAddingUser";
            this.applyAddingUser.Size = new System.Drawing.Size(100, 28);
            this.applyAddingUser.TabIndex = 14;
            this.applyAddingUser.Text = "Применить";
            this.applyAddingUser.UseVisualStyleBackColor = true;
            this.applyAddingUser.Click += new System.EventHandler(this.applyAddingUser_Click);
            // 
            // positionList
            // 
            this.positionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionList.FormattingEnabled = true;
            this.positionList.Location = new System.Drawing.Point(176, 176);
            this.positionList.Margin = new System.Windows.Forms.Padding(4);
            this.positionList.Name = "positionList";
            this.positionList.Size = new System.Drawing.Size(344, 24);
            this.positionList.TabIndex = 15;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 400);
            this.Controls.Add(this.positionList);
            this.Controls.Add(this.applyAddingUser);
            this.Controls.Add(this.cancelAddingUser);
            this.Controls.Add(this.personHomeAddressBox);
            this.Controls.Add(this.personPhoneNumberBox);
            this.Controls.Add(this.personMiddleNameBox);
            this.Controls.Add(this.personSurNameBox);
            this.Controls.Add(this.personFirstNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guideText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guideText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personFirstNameBox;
        private System.Windows.Forms.TextBox personSurNameBox;
        private System.Windows.Forms.TextBox personMiddleNameBox;
        private System.Windows.Forms.TextBox personPhoneNumberBox;
        private System.Windows.Forms.TextBox personHomeAddressBox;
        private System.Windows.Forms.Button cancelAddingUser;
        private System.Windows.Forms.Button applyAddingUser;
        private System.Windows.Forms.ComboBox positionList;
    }
}
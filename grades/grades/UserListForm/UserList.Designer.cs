﻿namespace grades
{
    partial class UserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.deleteUser = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.showStaff = new System.Windows.Forms.CheckBox();
            this.showStudents = new System.Windows.Forms.CheckBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.viewUser = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDGV
            // 
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.usersDGV.Location = new System.Drawing.Point(13, 47);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersDGV.Size = new System.Drawing.Size(775, 361);
            this.usersDGV.TabIndex = 0;
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteUser.FlatAppearance.BorderSize = 0;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Location = new System.Drawing.Point(712, 419);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 1;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // editUser
            // 
            this.editUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.editUser.FlatAppearance.BorderSize = 0;
            this.editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUser.Location = new System.Drawing.Point(608, 419);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(98, 23);
            this.editUser.TabIndex = 2;
            this.editUser.Text = "Редактировать";
            this.editUser.UseVisualStyleBackColor = false;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Location = new System.Drawing.Point(527, 419);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Добавить";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(13, 423);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(72, 13);
            this.displayLabel.TabIndex = 4;
            this.displayLabel.Text = "Отображать:";
            // 
            // showStaff
            // 
            this.showStaff.AutoSize = true;
            this.showStaff.Checked = true;
            this.showStaff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStaff.Location = new System.Drawing.Point(92, 423);
            this.showStaff.Name = "showStaff";
            this.showStaff.Size = new System.Drawing.Size(76, 17);
            this.showStaff.TabIndex = 5;
            this.showStaff.Text = "Персонал";
            this.showStaff.UseVisualStyleBackColor = true;
            this.showStaff.CheckedChanged += new System.EventHandler(this.showStaff_CheckedChanged);
            // 
            // showStudents
            // 
            this.showStudents.AutoSize = true;
            this.showStudents.Checked = true;
            this.showStudents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStudents.Location = new System.Drawing.Point(175, 423);
            this.showStudents.Name = "showStudents";
            this.showStudents.Size = new System.Drawing.Size(75, 17);
            this.showStudents.TabIndex = 6;
            this.showStudents.Text = "Учеников";
            this.showStudents.UseVisualStyleBackColor = true;
            this.showStudents.CheckedChanged += new System.EventHandler(this.showStudents_CheckedChanged);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Location = new System.Drawing.Point(61, 5);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(645, 23);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(13, 10);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(42, 13);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Поиск:";
            // 
            // viewUser
            // 
            this.viewUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewUser.FlatAppearance.BorderSize = 0;
            this.viewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUser.Location = new System.Drawing.Point(446, 419);
            this.viewUser.Name = "viewUser";
            this.viewUser.Size = new System.Drawing.Size(75, 23);
            this.viewUser.TabIndex = 10;
            this.viewUser.Text = "Просмотр";
            this.viewUser.UseVisualStyleBackColor = false;
            this.viewUser.Click += new System.EventHandler(this.viewUser_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(712, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.viewUser);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.showStudents);
            this.Controls.Add(this.showStaff);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.usersDGV);
            this.Name = "UserList";
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.CheckBox showStaff;
        private System.Windows.Forms.CheckBox showStudents;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button viewUser;
        private System.Windows.Forms.Button clearButton;
    }
}
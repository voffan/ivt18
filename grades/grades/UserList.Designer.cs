namespace grades
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
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.deleteUser = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showStaff = new System.Windows.Forms.CheckBox();
            this.showStudents = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDGV
            // 
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(13, 32);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.Size = new System.Drawing.Size(775, 376);
            this.usersDGV.TabIndex = 0;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(712, 415);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 1;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // editUser
            // 
            this.editUser.Location = new System.Drawing.Point(608, 414);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(98, 23);
            this.editUser.TabIndex = 2;
            this.editUser.Text = "Редактировать";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(527, 415);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Добавить";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отображать:";
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(713, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(61, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(646, 20);
            this.searchBox.TabIndex = 8;
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
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showStudents);
            this.Controls.Add(this.showStaff);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showStaff;
        private System.Windows.Forms.CheckBox showStudents;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
    }
}
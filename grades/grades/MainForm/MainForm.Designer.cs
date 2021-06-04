
namespace grades
{
    partial class MainForm
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelActivities = new System.Windows.Forms.Panel();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnTransitions = new System.Windows.Forms.Button();
            this.btnGrading = new System.Windows.Forms.Button();
            this.btnSubjectList = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.lblUserPosition = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panelActivities.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.panelActivities);
            this.panelNavigation.Controls.Add(this.btnSettings);
            this.panelNavigation.Controls.Add(this.panelUserInfo);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(199, 461);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelActivities
            // 
            this.panelActivities.AutoScroll = true;
            this.panelActivities.Controls.Add(this.btnUserList);
            this.panelActivities.Controls.Add(this.btnTransitions);
            this.panelActivities.Controls.Add(this.btnGrading);
            this.panelActivities.Controls.Add(this.btnSubjectList);
            this.panelActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActivities.Location = new System.Drawing.Point(0, 190);
            this.panelActivities.Name = "panelActivities";
            this.panelActivities.Size = new System.Drawing.Size(199, 240);
            this.panelActivities.TabIndex = 2;
            // 
            // btnUserList
            // 
            this.btnUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserList.FlatAppearance.BorderSize = 0;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserList.Location = new System.Drawing.Point(0, 93);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(199, 31);
            this.btnUserList.TabIndex = 1;
            this.btnUserList.Text = "Список пользователей";
            this.btnUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserList.UseVisualStyleBackColor = true;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnTransitions
            // 
            this.btnTransitions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransitions.FlatAppearance.BorderSize = 0;
            this.btnTransitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransitions.Location = new System.Drawing.Point(0, 62);
            this.btnTransitions.Name = "btnTransitions";
            this.btnTransitions.Size = new System.Drawing.Size(199, 31);
            this.btnTransitions.TabIndex = 1;
            this.btnTransitions.Text = "Перевод учеников";
            this.btnTransitions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransitions.UseVisualStyleBackColor = true;
            this.btnTransitions.Click += new System.EventHandler(this.transitionsButton_Click);
            // 
            // btnGrading
            // 
            this.btnGrading.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrading.FlatAppearance.BorderSize = 0;
            this.btnGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGrading.Location = new System.Drawing.Point(0, 31);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Size = new System.Drawing.Size(199, 31);
            this.btnGrading.TabIndex = 1;
            this.btnGrading.Text = "Выставление оценок";
            this.btnGrading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.UseVisualStyleBackColor = true;
            this.btnGrading.Click += new System.EventHandler(this.btnGrading_Click);
            // 
            // btnSubjectList
            // 
            this.btnSubjectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjectList.FlatAppearance.BorderSize = 0;
            this.btnSubjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubjectList.Location = new System.Drawing.Point(0, 0);
            this.btnSubjectList.Name = "btnSubjectList";
            this.btnSubjectList.Size = new System.Drawing.Size(199, 31);
            this.btnSubjectList.TabIndex = 1;
            this.btnSubjectList.Text = "Список предметов";
            this.btnSubjectList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjectList.UseVisualStyleBackColor = true;
            this.btnSubjectList.Click += new System.EventHandler(this.btnSubjectList_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.Location = new System.Drawing.Point(0, 430);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(199, 31);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.lblUserPosition);
            this.panelUserInfo.Controls.Add(this.lblUserName);
            this.panelUserInfo.Controls.Add(this.pictureBox1);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(199, 190);
            this.panelUserInfo.TabIndex = 0;
            // 
            // lblUserPosition
            // 
            this.lblUserPosition.AutoSize = true;
            this.lblUserPosition.BackColor = System.Drawing.Color.White;
            this.lblUserPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserPosition.Location = new System.Drawing.Point(47, 149);
            this.lblUserPosition.Name = "lblUserPosition";
            this.lblUserPosition.Size = new System.Drawing.Size(35, 13);
            this.lblUserPosition.TabIndex = 2;
            this.lblUserPosition.Text = "label2";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(47, 123);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::grades.Properties.Resources.User_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.White;
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(199, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(785, 461);
            this.panelMainContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelNavigation);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelNavigation.ResumeLayout(false);
            this.panelActivities.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTransitions;
        private System.Windows.Forms.Button btnGrading;
        private System.Windows.Forms.Button btnSubjectList;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserPosition;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panelActivities;
    }
}
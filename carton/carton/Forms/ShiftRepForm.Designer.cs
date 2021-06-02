
namespace carton
{
    partial class ShiftRepForm
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
            this.planGridView = new System.Windows.Forms.DataGridView();
            this.header = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createReportButton = new System.Windows.Forms.Button();
            this.editReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // planGridView
            // 
            this.planGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planGridView.Location = new System.Drawing.Point(15, 50);
            this.planGridView.MultiSelect = false;
            this.planGridView.Name = "planGridView";
            this.planGridView.RowHeadersWidth = 51;
            this.planGridView.Size = new System.Drawing.Size(750, 204);
            this.planGridView.TabIndex = 3;
            this.planGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planGridView_CellContentClick);
            this.planGridView.SelectionChanged += new System.EventHandler(this.planGridView_SelectionChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(86, 13);
            this.header.TabIndex = 4;
            this.header.Text = "Список планов:";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(12, 526);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Выйти";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(46, 307);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(76, 20);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(46, 371);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(76, 20);
            this.textBoxB.TabIndex = 8;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(46, 445);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(76, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Box A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Box B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Box C";
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(594, 526);
            this.createReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(171, 19);
            this.createReportButton.TabIndex = 13;
            this.createReportButton.Text = "Добавить";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // editReportButton
            // 
            this.editReportButton.Location = new System.Drawing.Point(375, 526);
            this.editReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editReportButton.Name = "editReportButton";
            this.editReportButton.Size = new System.Drawing.Size(171, 19);
            this.editReportButton.TabIndex = 14;
            this.editReportButton.Text = "Изменить";
            this.editReportButton.UseVisualStyleBackColor = true;
            this.editReportButton.Click += new System.EventHandler(this.editReportButton_Click);
            // 
            // ShiftRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.editReportButton);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.planGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShiftRepForm";
            this.Text = "DirectorForm";
            this.Load += new System.EventHandler(this.ShiftRepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView planGridView;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button editReportButton;
    }
}
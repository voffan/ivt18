
namespace grades
{
    partial class TransitionManagement
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
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.reportCardButton = new System.Windows.Forms.Button();
            this.studentsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(12, 16);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(41, 13);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Класс:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(77, 13);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(398, 21);
            this.groupComboBox.TabIndex = 1;
            this.groupComboBox.DropDownClosed += new System.EventHandler(this.groupComboBox_DropDownClosed);
            // 
            // reportCardButton
            // 
            this.reportCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportCardButton.Location = new System.Drawing.Point(659, 415);
            this.reportCardButton.Name = "reportCardButton";
            this.reportCardButton.Size = new System.Drawing.Size(129, 23);
            this.reportCardButton.TabIndex = 2;
            this.reportCardButton.Text = "Просмотреть табель";
            this.reportCardButton.UseVisualStyleBackColor = true;
            // 
            // studentsDGV
            // 
            this.studentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDGV.Location = new System.Drawing.Point(13, 52);
            this.studentsDGV.Name = "studentsDGV";
            this.studentsDGV.Size = new System.Drawing.Size(775, 357);
            this.studentsDGV.TabIndex = 3;
            // 
            // TransitionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentsDGV);
            this.Controls.Add(this.reportCardButton);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.groupLabel);
            this.Name = "TransitionManagement";
            this.Text = "TransitionManagement";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button reportCardButton;
        private System.Windows.Forms.DataGridView studentsDGV;
    }
}
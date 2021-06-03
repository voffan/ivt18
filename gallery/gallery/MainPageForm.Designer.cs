
namespace gallery
{
    partial class MainPageForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.comissionListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTool
            // 
            this.menuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureListMenu,
            this.employeeListMenu,
            this.comissionListMenu,
            this.reportListMenu});
            this.menuTool.Name = "menuTool";
            this.menuTool.Size = new System.Drawing.Size(83, 24);
            this.menuTool.Text = "Перейти";
            this.menuTool.Click += new System.EventHandler(this.списокКартинToolStripMenuItem_Click);
            // 
            // pictureListMenu
            // 
            this.pictureListMenu.Name = "pictureListMenu";
            this.pictureListMenu.Size = new System.Drawing.Size(236, 26);
            this.pictureListMenu.Text = "Список картин";
            this.pictureListMenu.Click += new System.EventHandler(this.pictureListMenu_Click);
            // 
            // employeeListMenu
            // 
            this.employeeListMenu.Name = "employeeListMenu";
            this.employeeListMenu.Size = new System.Drawing.Size(236, 26);
            this.employeeListMenu.Text = "Список работников";
            this.employeeListMenu.Click += new System.EventHandler(this.employeeListMenu_Click);
            // 
            // comissionListMenu
            // 
            this.comissionListMenu.Name = "comissionListMenu";
            this.comissionListMenu.Size = new System.Drawing.Size(236, 26);
            this.comissionListMenu.Text = "Список реставраций";
            this.comissionListMenu.Click += new System.EventHandler(this.restorationListMenu_Click);
            // 
            // reportListMenu
            // 
            this.reportListMenu.Name = "reportListMenu";
            this.reportListMenu.Size = new System.Drawing.Size(236, 26);
            this.reportListMenu.Text = "Отчеты";
            this.reportListMenu.Click += new System.EventHandler(this.reportListMenu_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPageForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTool;
        private System.Windows.Forms.ToolStripMenuItem pictureListMenu;
        private System.Windows.Forms.ToolStripMenuItem employeeListMenu;
        private System.Windows.Forms.ToolStripMenuItem comissionListMenu;
        private System.Windows.Forms.ToolStripMenuItem reportListMenu;
    }
}


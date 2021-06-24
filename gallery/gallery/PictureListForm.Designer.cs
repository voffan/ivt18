﻿
namespace gallery
{
    partial class PictureListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокХудожниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспозицийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьНаРеставрациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(853, 332);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список картин:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокХудожниковToolStripMenuItem,
            this.картинаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокХудожниковToolStripMenuItem
            // 
            this.списокХудожниковToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.galleryToolStripMenuItem,
            this.экспозицийToolStripMenuItem});
            this.списокХудожниковToolStripMenuItem.Name = "списокХудожниковToolStripMenuItem";
            this.списокХудожниковToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.списокХудожниковToolStripMenuItem.Text = "Список:";
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.artistToolStripMenuItem.Text = "Художников";
            this.artistToolStripMenuItem.Click += new System.EventHandler(this.artistListView_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.genreToolStripMenuItem.Text = "Жанров";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreListView_Click);
            // 
            // galleryToolStripMenuItem
            // 
            this.galleryToolStripMenuItem.Name = "galleryToolStripMenuItem";
            this.galleryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.galleryToolStripMenuItem.Text = "Галерей";
            this.galleryToolStripMenuItem.Click += new System.EventHandler(this.galleryListView_Click);
            // 
            // экспозицийToolStripMenuItem
            // 
            this.экспозицийToolStripMenuItem.Name = "экспозицийToolStripMenuItem";
            this.экспозицийToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.экспозицийToolStripMenuItem.Text = "Экспозиций";
            this.экспозицийToolStripMenuItem.Click += new System.EventHandler(this.expoListView);
            // 
            // картинаToolStripMenuItem
            // 
            this.картинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.отправитьНаРеставрациюToolStripMenuItem});
            this.картинаToolStripMenuItem.Name = "картинаToolStripMenuItem";
            this.картинаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.картинаToolStripMenuItem.Text = "Картина:";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.pictureAdd_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.pictureView_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.pictureEdit_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.pictureDelete_Click);
            // 
            // отправитьНаРеставрациюToolStripMenuItem
            // 
            this.отправитьНаРеставрациюToolStripMenuItem.Name = "отправитьНаРеставрациюToolStripMenuItem";
            this.отправитьНаРеставрациюToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.отправитьНаРеставрациюToolStripMenuItem.Text = "Отправить на реставрацию";
            this.отправитьНаРеставрациюToolStripMenuItem.Click += new System.EventHandler(this.pictureSendToResto_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(87, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(509, 26);
            this.txtSearch.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Поиск:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(602, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotal.Location = new System.Drawing.Point(12, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(169, 20);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Всего совпадений:";
            // 
            // PictureListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 470);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PictureListForm";
            this.Text = "Список картин";
            this.Activated += new System.EventHandler(this.PictureListForm_Activated);
            this.Load += new System.EventHandler(this.PictureListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокХудожниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galleryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьНаРеставрациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспозицийToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotal;
    }
}
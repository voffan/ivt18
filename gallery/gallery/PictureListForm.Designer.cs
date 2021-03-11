
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.galleryDBDataSet1 = new gallery.GalleryDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.galleryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureTableAdapter = new gallery.GalleryDBDataSetTableAdapters.PictureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить картину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Список экспозиций";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // galleryDBDataSet1
            // 
            this.galleryDBDataSet1.DataSetName = "GalleryDBDataSet";
            this.galleryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.artistIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.placeIdDataGridViewTextBoxColumn,
            this.galleryIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pictureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureIdDataGridViewTextBoxColumn
            // 
            this.pictureIdDataGridViewTextBoxColumn.DataPropertyName = "PictureId";
            this.pictureIdDataGridViewTextBoxColumn.HeaderText = "PictureId";
            this.pictureIdDataGridViewTextBoxColumn.Name = "pictureIdDataGridViewTextBoxColumn";
            this.pictureIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // artistIdDataGridViewTextBoxColumn
            // 
            this.artistIdDataGridViewTextBoxColumn.DataPropertyName = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.HeaderText = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.Name = "artistIdDataGridViewTextBoxColumn";
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            // 
            // placeIdDataGridViewTextBoxColumn
            // 
            this.placeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaceId";
            this.placeIdDataGridViewTextBoxColumn.HeaderText = "PlaceId";
            this.placeIdDataGridViewTextBoxColumn.Name = "placeIdDataGridViewTextBoxColumn";
            // 
            // galleryIdDataGridViewTextBoxColumn
            // 
            this.galleryIdDataGridViewTextBoxColumn.DataPropertyName = "GalleryId";
            this.galleryIdDataGridViewTextBoxColumn.HeaderText = "GalleryId";
            this.galleryIdDataGridViewTextBoxColumn.Name = "galleryIdDataGridViewTextBoxColumn";
            // 
            // pictureBindingSource
            // 
            this.pictureBindingSource.DataMember = "Picture";
            this.pictureBindingSource.DataSource = this.galleryDBDataSet1;
            // 
            // pictureTableAdapter
            // 
            this.pictureTableAdapter.ClearBeforeFill = true;
            // 
            // PictureListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PictureListForm";
            this.Text = "PictureListForm";
            this.Load += new System.EventHandler(this.PictureListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galleryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private GalleryDBDataSet galleryDBDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pictureBindingSource;
        private GalleryDBDataSetTableAdapters.PictureTableAdapter pictureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn galleryIdDataGridViewTextBoxColumn;
    }
}
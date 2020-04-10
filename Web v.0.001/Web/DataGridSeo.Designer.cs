namespace Web
{
    partial class DataGridSeo
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
            this.bdDataSet = new Web.bdDataSet();
            this.наполнениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наполнениеTableAdapter = new Web.bdDataSetTableAdapters.НаполнениеTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.продвижениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продвижениеTableAdapter = new Web.bdDataSetTableAdapters.ПродвижениеTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оптимизацияИзображенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аналитикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рекламаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наполнениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продвижениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // наполнениеBindingSource
            // 
            this.наполнениеBindingSource.DataMember = "Наполнение";
            this.наполнениеBindingSource.DataSource = this.bdDataSet;
            // 
            // наполнениеTableAdapter
            // 
            this.наполнениеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.sEODataGridViewTextBoxColumn,
            this.оптимизацияИзображенийDataGridViewTextBoxColumn,
            this.аналитикаDataGridViewTextBoxColumn,
            this.рекламаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продвижениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // продвижениеBindingSource
            // 
            this.продвижениеBindingSource.DataMember = "Продвижение";
            this.продвижениеBindingSource.DataSource = this.bdDataSet;
            // 
            // продвижениеTableAdapter
            // 
            this.продвижениеTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // sEODataGridViewTextBoxColumn
            // 
            this.sEODataGridViewTextBoxColumn.DataPropertyName = "SEO";
            this.sEODataGridViewTextBoxColumn.HeaderText = "SEO";
            this.sEODataGridViewTextBoxColumn.Name = "sEODataGridViewTextBoxColumn";
            // 
            // оптимизацияИзображенийDataGridViewTextBoxColumn
            // 
            this.оптимизацияИзображенийDataGridViewTextBoxColumn.DataPropertyName = "Оптимизация изображений";
            this.оптимизацияИзображенийDataGridViewTextBoxColumn.HeaderText = "Оптимизация изображений";
            this.оптимизацияИзображенийDataGridViewTextBoxColumn.Name = "оптимизацияИзображенийDataGridViewTextBoxColumn";
            // 
            // аналитикаDataGridViewTextBoxColumn
            // 
            this.аналитикаDataGridViewTextBoxColumn.DataPropertyName = "Аналитика";
            this.аналитикаDataGridViewTextBoxColumn.HeaderText = "Аналитика";
            this.аналитикаDataGridViewTextBoxColumn.Name = "аналитикаDataGridViewTextBoxColumn";
            // 
            // рекламаDataGridViewTextBoxColumn
            // 
            this.рекламаDataGridViewTextBoxColumn.DataPropertyName = "Реклама";
            this.рекламаDataGridViewTextBoxColumn.HeaderText = "Реклама";
            this.рекламаDataGridViewTextBoxColumn.Name = "рекламаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // DataGridSeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 173);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridSeo";
            this.Text = "DataGridSeo";
            this.Load += new System.EventHandler(this.DataGridSeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наполнениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продвижениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource наполнениеBindingSource;
        private bdDataSetTableAdapters.НаполнениеTableAdapter наполнениеTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource продвижениеBindingSource;
        private bdDataSetTableAdapters.ПродвижениеTableAdapter продвижениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оптимизацияИзображенийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аналитикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рекламаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}
namespace Web
{
    partial class DataGridVerstka
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bdDataSet = new Web.bdDataSet();
            this.версткаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.версткаTableAdapter = new Web.bdDataSetTableAdapters.ВерсткаTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.слайдерыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.анимированныеБлокиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.локализацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сложнаяСтруктураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.геопривязкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.слайдерыDataGridViewTextBoxColumn,
            this.анимированныеБлокиDataGridViewTextBoxColumn,
            this.локализацияDataGridViewTextBoxColumn,
            this.сложнаяСтруктураDataGridViewTextBoxColumn,
            this.геопривязкаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.версткаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(935, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // версткаBindingSource
            // 
            this.версткаBindingSource.DataMember = "Верстка";
            this.версткаBindingSource.DataSource = this.bdDataSet;
            // 
            // версткаTableAdapter
            // 
            this.версткаTableAdapter.ClearBeforeFill = true;
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
            // слайдерыDataGridViewTextBoxColumn
            // 
            this.слайдерыDataGridViewTextBoxColumn.DataPropertyName = "Слайдеры";
            this.слайдерыDataGridViewTextBoxColumn.HeaderText = "Слайдеры";
            this.слайдерыDataGridViewTextBoxColumn.Name = "слайдерыDataGridViewTextBoxColumn";
            // 
            // анимированныеБлокиDataGridViewTextBoxColumn
            // 
            this.анимированныеБлокиDataGridViewTextBoxColumn.DataPropertyName = "Анимированные блоки";
            this.анимированныеБлокиDataGridViewTextBoxColumn.HeaderText = "Анимированные блоки";
            this.анимированныеБлокиDataGridViewTextBoxColumn.Name = "анимированныеБлокиDataGridViewTextBoxColumn";
            // 
            // локализацияDataGridViewTextBoxColumn
            // 
            this.локализацияDataGridViewTextBoxColumn.DataPropertyName = "Локализация";
            this.локализацияDataGridViewTextBoxColumn.HeaderText = "Локализация";
            this.локализацияDataGridViewTextBoxColumn.Name = "локализацияDataGridViewTextBoxColumn";
            // 
            // сложнаяСтруктураDataGridViewTextBoxColumn
            // 
            this.сложнаяСтруктураDataGridViewTextBoxColumn.DataPropertyName = "Сложная структура";
            this.сложнаяСтруктураDataGridViewTextBoxColumn.HeaderText = "Сложная структура";
            this.сложнаяСтруктураDataGridViewTextBoxColumn.Name = "сложнаяСтруктураDataGridViewTextBoxColumn";
            // 
            // геопривязкаDataGridViewTextBoxColumn
            // 
            this.геопривязкаDataGridViewTextBoxColumn.DataPropertyName = "Геопривязка";
            this.геопривязкаDataGridViewTextBoxColumn.HeaderText = "Геопривязка";
            this.геопривязкаDataGridViewTextBoxColumn.Name = "геопривязкаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // DataGridVerstka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 180);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DataGridVerstka";
            this.Text = "DataGridVerstka";
            this.Load += new System.EventHandler(this.DataGridVerstka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.версткаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource версткаBindingSource;
        private bdDataSetTableAdapters.ВерсткаTableAdapter версткаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn слайдерыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn анимированныеБлокиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn локализацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сложнаяСтруктураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn геопривязкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}
namespace Web
{
    partial class DataGridBaza
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdDataSet = new Web.bdDataSet();
            this.базовыйФункционалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.базовый_функционалTableAdapter = new Web.bdDataSetTableAdapters.Базовый_функционалTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хостингDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кроссбраузерностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адаптивностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.базовыйФункционалBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.хостингDataGridViewTextBoxColumn,
            this.кроссбраузерностьDataGridViewTextBoxColumn,
            this.адаптивностьDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.базовыйФункционалBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // базовыйФункционалBindingSource
            // 
            this.базовыйФункционалBindingSource.DataMember = "Базовый функционал";
            this.базовыйФункционалBindingSource.DataSource = this.bdDataSet;
            // 
            // базовый_функционалTableAdapter
            // 
            this.базовый_функционалTableAdapter.ClearBeforeFill = true;
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
            // хостингDataGridViewTextBoxColumn
            // 
            this.хостингDataGridViewTextBoxColumn.DataPropertyName = "Хостинг";
            this.хостингDataGridViewTextBoxColumn.HeaderText = "Хостинг";
            this.хостингDataGridViewTextBoxColumn.Name = "хостингDataGridViewTextBoxColumn";
            // 
            // кроссбраузерностьDataGridViewTextBoxColumn
            // 
            this.кроссбраузерностьDataGridViewTextBoxColumn.DataPropertyName = "Кроссбраузерность";
            this.кроссбраузерностьDataGridViewTextBoxColumn.HeaderText = "Кроссбраузерность";
            this.кроссбраузерностьDataGridViewTextBoxColumn.Name = "кроссбраузерностьDataGridViewTextBoxColumn";
            // 
            // адаптивностьDataGridViewTextBoxColumn
            // 
            this.адаптивностьDataGridViewTextBoxColumn.DataPropertyName = "Адаптивность";
            this.адаптивностьDataGridViewTextBoxColumn.HeaderText = "Адаптивность";
            this.адаптивностьDataGridViewTextBoxColumn.Name = "адаптивностьDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // DataGridBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 159);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridBaza";
            this.Text = "DataGridBaza";
            this.Load += new System.EventHandler(this.DataGridBaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базовыйФункционалBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource базовыйФункционалBindingSource;
        private bdDataSetTableAdapters.Базовый_функционалTableAdapter базовый_функционалTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn хостингDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кроссбраузерностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адаптивностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}
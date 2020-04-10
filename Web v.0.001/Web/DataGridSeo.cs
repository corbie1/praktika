using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class DataGridSeo : Form
    {
        public DataGridSeo()
        {
            InitializeComponent();
        }

        private void DataGridSeo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Продвижение". При необходимости она может быть перемещена или удалена.
            this.продвижениеTableAdapter.Fill(this.bdDataSet.Продвижение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Наполнение". При необходимости она может быть перемещена или удалена.
            this.наполнениеTableAdapter.Fill(this.bdDataSet.Наполнение);

        }
    }
}

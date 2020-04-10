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
    public partial class DataGridBaza : Form
    {
        public DataGridBaza()
        {
            InitializeComponent();
        }

        private void DataGridBaza_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Базовый_функционал". При необходимости она может быть перемещена или удалена.
            this.базовый_функционалTableAdapter.Fill(this.bdDataSet.Базовый_функционал);

        }
    }
}

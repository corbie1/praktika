﻿using System;
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
    public partial class DataGridModules : Form
    {
        public DataGridModules()
        {
            InitializeComponent();
        }

        private void DataGridModules_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Модули". При необходимости она может быть перемещена или удалена.
            this.модулиTableAdapter.Fill(this.bdDataSet.Модули);

        }
    }
}

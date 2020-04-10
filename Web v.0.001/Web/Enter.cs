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
    public partial class enter : Form
    {
    
        public enter() => InitializeComponent();

      

        private void button2_onClick(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxFirstName.Text == "")
            {
                MessageBox.Show("Введите поля корректно");
            }
            else
            {
                GlobalTrash.Username = textBoxName.Text;
                GlobalTrash.Fam = textBoxFirstName.Text;
                this.Hide();
                MainForm frm = new MainForm();
               frm.Show();
            }

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                char l = e.KeyChar;
                if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                char l = e.KeyChar;
                if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                {
                    e.Handled = true;
                }
            }
        }
    }
}

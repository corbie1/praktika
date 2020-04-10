using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{

    public partial class MainForm : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bd.mdb;";
        private OleDbConnection myConnection;



        public MainForm()
        {
            InitializeComponent();
            try
            {
                myConnection = new OleDbConnection(connectionString);
                myConnection.Open();
            }
            catch
            {
                new DataException("Отсутствует подключение");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Модули". При необходимости она может быть перемещена или удалена.
            this.модулиTableAdapter.Fill(this.bdDataSet.Модули);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalCheck.Checked == true)
            {
                langTxt.Visible = true;
                label4.Visible = true;
                langTxt.Enabled = true;
            }
            else
            {
                langTxt.Visible = false;

                label4.Visible = false;
                langTxt.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slider_number = (int)(SliderNum.Value);
            animation_number = (int)(AnimNumb.Value);
            string langtext = langTxt.Text;
            string query = $"INSERT INTO Верстка (Имя, Фамилия, Слайдеры, [Анимированные блоки], Локализация, [Сложная структура], Геопривязка, Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{slider_number}', '{animation_number}', '{langtext}',  '{hard_str}', '{geo_loc}', '{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSum1.Clear();

            slider_number = (int)(SliderNum.Value);
            animation_number = (int)(AnimNumb.Value);

            if (langTxt.Text != "")
            {
                language += 1000;
            }

            allPrice = slider_number * slider_price + animation_price * animation_number + language;

            if (HardStr.Checked)
            {
                allPrice += structure;
                hard_str = "+";
            }


            if (GeoCheck.Checked)
            {
                allPrice += geo;
                geo_loc = "+";

            }

            txtSum1.Text = allPrice.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridVerstka frm = new DataGridVerstka();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSum2.Clear();
            allPrice = 0;
            if (ContactCheck.Checked)
            {
                contactForm = 5000;
            }
            else
            {
                contactForm.ToString("none");
            }
            if (ChatCheck.Checked)
            {
                OnlineChat = 4000;
            }
            else
            {
                OnlineChat.ToString("none");
            }
            if (MailCheck.Checked)
            {
                mail = 3000;
            }
            else
            {
                mail.ToString("none");
            }
            allPrice = mail + OnlineChat + contactForm;
            txtSum2.Text = allPrice.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Модули (Имя, Фамилия, [Форма обратной связи], [Настройка почты], [Онлайн чат], Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{contactForm}', '{mail}', '{OnlineChat}','{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        int slider_price = 2000;
        int animation_price = 5000;
        int structure = 15000;
        int geo = 3000;
        string searches_block = "none";
        string geo_loc = "none";
        string hard_str = "none";
        int language = 0;
        int slider_number = 0;
        int allPrice = 0;
        int animation_number = 0;
        int contactForm = 0;
        int OnlineChat = 0;
        int mail = 0;
        int pages = 0;
        int searches = 0;
        int pages_number = 0;
        int seo = 0;
        int optim = 0;
        int analit = 0;
        int promotion = 0;
        int hosting = 0;
        int adapt = 0;
        int cross = 0;

        private void button9_Click(object sender, EventArgs e)
        {
            txtSum3.Clear();

            allPrice = 0;
            pages_number = (int)(PageNum.Value);

            pages = 500;
            searches = 300;
            if(InfoCheck.Checked) {
                allPrice = (pages + searches) * pages_number;
                searches_block = "+";
            }
            else
            {
                allPrice = pages * pages_number;
            }
          
                txtSum3.Text = allPrice.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridModules frm = new DataGridModules();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridNapolnenie frm = new DataGridNapolnenie();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Наполнение (Имя, Фамилия, [Количество страниц], [Поиск и обработка информации], Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{pages_number}', '{searches_block}','{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            allPrice = 0;
            if (AnalitCheck.Checked)
            {
                analit = 5000;
            }
            else
            {
                analit.ToString("none");
            }
            if (SeoCheck.Checked)
            {
                seo = 10000;
            }
            else
            {
                seo.ToString("none");
            }
            if (OptimCheck.Checked)
            {
                optim = 8000;
            }
            else
            {
                optim.ToString("none");
            }
            if (PromCheck.Checked)
            {
                promotion = 15000;
            }
            else
            {
                promotion.ToString("none");
            }
            allPrice = analit + seo + optim + promotion;
            txtSum4.Clear();
            txtSum4.Text = allPrice.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Продвижение (Имя, Фамилия, SEO, [Оптимизация изображений], Аналитика, Реклама, Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{seo}', '{optim}', '{analit}', '{promotion}', '{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataGridSeo frm = new DataGridSeo();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            allPrice = 0;
            if (HostCheck.Checked)
            {
                hosting = 1000;
            }
            else
            {
                hosting.ToString("none");
            }
            if (AdaptCheck.Checked)
            {
                adapt = 1000;
            }
            else
            {
                adapt.ToString("none");
            }
            if (CrossCheck.Checked)
            {
                cross = 1000;
            }
            else
            {
                cross.ToString("none");
            }
            txtSum5.Clear();
            allPrice = hosting + adapt + cross;
            txtSum5.Text = allPrice.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO [Базовый функционал] (Имя, Фамилия, Хостинг, Кроссбраузерность, Адаптивность, Цена) VALUES ('{GlobalTrash.Username}', '{GlobalTrash.Fam}', '{hosting}', '{cross}', '{adapt}', '{allPrice}')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataGridBaza frm = new DataGridBaza();
            frm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                char l = e.KeyChar;
                if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

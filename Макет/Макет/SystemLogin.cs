using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макет
{
    public partial class SystemLogin : Form
    {
        Thread thread;
        const string AccPass = "money";
        const string AdminPass = "admin";
        const string BossPass = "boss";
        const string CallPass = "call";
        const string PartPass = "part";
        public SystemLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Бухгалтер" && this.textBox2.Text == AccPass)
            {
                this.Close();
                thread = new Thread(OpenAcc);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (this.comboBox1.Text == "Управляющий" && this.textBox2.Text == AdminPass)
            {
                this.Close();
                thread = new Thread(OpenAdmin);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (this.comboBox1.Text == "Владелец" && this.textBox2.Text == BossPass)
            {
                this.Close();
                thread = new Thread(OpenBoss);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (this.comboBox1.Text == "Оператор" && this.textBox2.Text == CallPass)
            {
                this.Close();
                thread = new Thread(OpenCall);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (this.comboBox1.Text == "Поставщик" && this.textBox2.Text == PartPass)
            {
                this.Close();
                thread = new Thread(OpenPart);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (this.comboBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("Необходимо ввести данные!");
            }
            else MessageBox.Show("Данные введены неверно!");
        }
        public void OpenAcc(object obj)
        {
            Application.Run(new SystemProfileAcc());
        }
        public void OpenAdmin(object obj)
        {
            Application.Run(new SystemProfileAdmin());
        }
        public void OpenBoss(object obj)
        {
            Application.Run(new SystemProfileBoss());
        }
        public void OpenCall(object obj)
        {
            Application.Run(new SystemProfileCall());
        }
        public void OpenPart(object obj)
        {
            Application.Run(new SystemProfilePart());
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макет
{
    
    public partial class ChangeWorkAcc : Form
    {
        Thread thread;
        public ChangeWorkAcc(string paramenter)
        {
            InitializeComponent();
            if (paramenter == "acc")
            {
                buttonacc.Visible = true;
                buttonadmin.Visible = false;
                buttonboss.Visible = false;
                buttoncall.Visible = false;
            }
            else
            if (paramenter == "admin")
            {
                buttonacc.Visible = false;
                buttonadmin.Visible = true;
                buttonboss.Visible = false;
                buttoncall.Visible = false;
            }
            else
            if (paramenter == "boss")
            {
                buttonacc.Visible = false;
                buttonadmin.Visible = false;
                buttonboss.Visible = true;
                buttoncall.Visible = false;
            }
            else
            if (paramenter == "call")
            {
                buttonacc.Visible = false;
                buttonadmin.Visible = false;
                buttonboss.Visible = false;
                buttoncall.Visible = true;
                dataGridView1.ReadOnly = true;
            }
        }

        private void findbut_Click(object sender, EventArgs e)
        {
            string InsertedName = textBox1.Text;
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\antsi\\OneDrive\\Документы\\МГТУ\\4 семестр\\БД\\Лабораторные\\Макет\\Макет_v2.mdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Work] " + " WHERE WorkName LIKE \'" + InsertedName + "%\'", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void ChangeWorkAcc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.Work". При необходимости она может быть перемещена или удалена.
            this.workTableAdapter.Fill(this.макет_v2DataSet.Work);
           
        }
        private void buttonacc_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAcc);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenAcc(object obj)
        {
            Application.Run(new SystemProfileAcc());
        }
        private void buttonadmin_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAdmin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenAdmin(object obj)
        {
            Application.Run(new SystemProfileAdmin());
        }
        private void buttonboss_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenBoss);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenBoss(object obj)
        {
            Application.Run(new SystemProfileBoss());
        }
        private void buttoncall_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenCall);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenCall(object obj)
        {
            Application.Run(new SystemProfileCall());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findbut.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            workTableAdapter.Update(макет_v2DataSet);
            this.Validate();
            this.workBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.макет_v2DataSet);
            MessageBox.Show("Успешно сохранено!");
        }
    }
}

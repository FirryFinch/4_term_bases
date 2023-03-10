using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Base
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string mybdpath = "C:\\Users\\student\\Documents\\Анцифров ИУ5-41Б\\ИУ5-31Б_Анцифров_ЛП2000.mdb";
            string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr); 
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Client", connection); // добавляем текст SQL запроса
            connection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carTableAdapter.FillBy1(this._ИУ5_31Б_Анцифров_ЛП2000DataSet.Car);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillBy(this._ИУ5_31Б_Анцифров_ЛП2000DataSet.Client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillBy(this._ИУ5_31Б_Анцифров_ЛП2000DataSet.Client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.FillBy1(this._ИУ5_31Б_Анцифров_ЛП2000DataSet.Client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

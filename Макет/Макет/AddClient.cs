using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макет
{
    public partial class AddClient : Form
    {
        string par;
        Thread thread;
        public AddClient(string paramenter)
        {
            InitializeComponent();
            par = paramenter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientTableAdapter.Update(макет_v2DataSet);
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.макет_v2DataSet);
            button1.PerformClick();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
                thread = new Thread(OpenBack);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
        }
        public void OpenBack(object obj)
        {
            Application.Run(new ChangeClient(par));
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            this.clientBindingSource.AddNew();
        }
    }
}

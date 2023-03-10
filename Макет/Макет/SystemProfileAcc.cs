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
    public partial class SystemProfileAcc : Form
    {
        Thread thread;
        public SystemProfileAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenSystemLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenSystemLogin(object obj)
        {
            Application.Run(new SystemLogin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenChangeWork);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenChangeWork(object obj)
        {
            Application.Run(new ChangeWorkAcc("acc"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenChangePart);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenChangePart(object obj)
        {
            Application.Run(new ChangePart("acc"));
        }
    }
}

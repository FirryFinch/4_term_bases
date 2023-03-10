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
    public partial class SystemProfileBoss : Form
    {
        Thread thread;
        public SystemProfileBoss()
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenChangeWork);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenChangeWork(object obj)
        {
            Application.Run(new ChangeWorkAcc("boss"));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenChangePart);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenChangePart(object obj)
        {
            Application.Run(new ChangePart("boss"));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenChangeClient);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenChangeClient(object obj)
        {
            Application.Run(new ChangeClient("boss"));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenEmployees);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenEmployees(object obj)
        {
            Application.Run(new ChangeEmployees());
        }
    }
}

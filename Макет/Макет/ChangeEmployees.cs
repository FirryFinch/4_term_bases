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
    public partial class ChangeEmployees : Form
    {
        Thread thread;
        public ChangeEmployees()
        {
            InitializeComponent();
        }

        private void ChangeEmployees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.EmployeeAreas". При необходимости она может быть перемещена или удалена.
            this.employeeAreasTableAdapter.Fill(this.макет_v2DataSet.EmployeeAreas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.EmployeeClasses". При необходимости она может быть перемещена или удалена.
            this.employeeClassesTableAdapter.Fill(this.макет_v2DataSet.EmployeeClasses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.макет_v2DataSet.Employee);

        }
        public void OpenBoss(object obj)
        {
            Application.Run(new SystemProfileBoss());
        }

        private void buttonboss_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenBoss);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.Update(макет_v2DataSet);
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.макет_v2DataSet);
            MessageBox.Show("Успешно сохранено!");
        }
    }
}

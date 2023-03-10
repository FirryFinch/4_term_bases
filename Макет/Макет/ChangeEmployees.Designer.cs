
namespace Макет
{
    partial class ChangeEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.макет_v2DataSet = new Макет.Макет_v2DataSet();
            this.employeeTableAdapter = new Макет.Макет_v2DataSetTableAdapters.EmployeeTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonboss = new System.Windows.Forms.Button();
            this.buttonadmin = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Макет.Макет_v2DataSetTableAdapters.TableAdapterManager();
            this.employeeClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeClassesTableAdapter = new Макет.Макет_v2DataSetTableAdapters.EmployeeClassesTableAdapter();
            this.employeeAreasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAreasTableAdapter = new Макет.Макет_v2DataSetTableAdapters.EmployeeAreasTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeePhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAreasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 53);
            this.panel4.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(419, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Информация о сотрудниках";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeMiddleNameDataGridViewTextBoxColumn,
            this.employeeClassDataGridViewTextBoxColumn,
            this.employeeAreaDataGridViewTextBoxColumn,
            this.employeePhoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 339);
            this.dataGridView1.TabIndex = 37;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.макет_v2DataSet;
            // 
            // макет_v2DataSet
            // 
            this.макет_v2DataSet.DataSetName = "Макет_v2DataSet";
            this.макет_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(229, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(343, 31);
            this.button3.TabIndex = 51;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonboss
            // 
            this.buttonboss.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonboss.ForeColor = System.Drawing.Color.Maroon;
            this.buttonboss.Location = new System.Drawing.Point(615, 506);
            this.buttonboss.Name = "buttonboss";
            this.buttonboss.Size = new System.Drawing.Size(343, 31);
            this.buttonboss.TabIndex = 50;
            this.buttonboss.Text = "Закрыть";
            this.buttonboss.UseVisualStyleBackColor = true;
            this.buttonboss.Click += new System.EventHandler(this.buttonboss_Click);
            // 
            // buttonadmin
            // 
            this.buttonadmin.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonadmin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonadmin.Location = new System.Drawing.Point(615, 506);
            this.buttonadmin.Name = "buttonadmin";
            this.buttonadmin.Size = new System.Drawing.Size(343, 31);
            this.buttonadmin.TabIndex = 49;
            this.buttonadmin.Text = "Закрыть";
            this.buttonadmin.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarTableAdapter = null;
            this.tableAdapterManager1.CarTypesTableAdapter = null;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.EmployeeAreasTableAdapter = this.employeeAreasTableAdapter;
            this.tableAdapterManager1.EmployeeClassesTableAdapter = this.employeeClassesTableAdapter;
            this.tableAdapterManager1.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager1.InOrderTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.PartTableAdapter = null;
            this.tableAdapterManager1.SystemUsersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Макет.Макет_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = null;
            // 
            // employeeClassesBindingSource
            // 
            this.employeeClassesBindingSource.DataMember = "EmployeeClasses";
            this.employeeClassesBindingSource.DataSource = this.макет_v2DataSet;
            // 
            // employeeClassesTableAdapter
            // 
            this.employeeClassesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeAreasBindingSource
            // 
            this.employeeAreasBindingSource.DataMember = "EmployeeAreas";
            this.employeeAreasBindingSource.DataSource = this.макет_v2DataSet;
            // 
            // employeeAreasTableAdapter
            // 
            this.employeeAreasTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            this.employeeIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSurname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.employeeSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            this.employeeSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeMiddleNameDataGridViewTextBoxColumn
            // 
            this.employeeMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeMiddleName";
            this.employeeMiddleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.employeeMiddleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeMiddleNameDataGridViewTextBoxColumn.Name = "employeeMiddleNameDataGridViewTextBoxColumn";
            this.employeeMiddleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeClassDataGridViewTextBoxColumn
            // 
            this.employeeClassDataGridViewTextBoxColumn.DataPropertyName = "EmployeeClass";
            this.employeeClassDataGridViewTextBoxColumn.DataSource = this.employeeClassesBindingSource;
            this.employeeClassDataGridViewTextBoxColumn.DisplayMember = "EmployeeClassName";
            this.employeeClassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.employeeClassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeClassDataGridViewTextBoxColumn.Name = "employeeClassDataGridViewTextBoxColumn";
            this.employeeClassDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeClassDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeClassDataGridViewTextBoxColumn.ValueMember = "EmployeeClassID";
            this.employeeClassDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeAreaDataGridViewTextBoxColumn
            // 
            this.employeeAreaDataGridViewTextBoxColumn.DataPropertyName = "EmployeeArea";
            this.employeeAreaDataGridViewTextBoxColumn.DataSource = this.employeeAreasBindingSource;
            this.employeeAreaDataGridViewTextBoxColumn.DisplayMember = "EmployeeAreaName";
            this.employeeAreaDataGridViewTextBoxColumn.HeaderText = "Зона";
            this.employeeAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeAreaDataGridViewTextBoxColumn.Name = "employeeAreaDataGridViewTextBoxColumn";
            this.employeeAreaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeAreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeAreaDataGridViewTextBoxColumn.ValueMember = "EmployeeAreaID";
            this.employeeAreaDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeePhoneNumberDataGridViewTextBoxColumn
            // 
            this.employeePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.employeePhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeePhoneNumberDataGridViewTextBoxColumn.Name = "employeePhoneNumberDataGridViewTextBoxColumn";
            this.employeePhoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // ChangeEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonboss);
            this.Controls.Add(this.buttonadmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Name = "ChangeEmployees";
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.ChangeEmployees_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAreasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Макет_v2DataSet макет_v2DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Макет_v2DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonboss;
        private System.Windows.Forms.Button buttonadmin;
        private Макет_v2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Макет_v2DataSetTableAdapters.EmployeeClassesTableAdapter employeeClassesTableAdapter;
        private System.Windows.Forms.BindingSource employeeClassesBindingSource;
        private Макет_v2DataSetTableAdapters.EmployeeAreasTableAdapter employeeAreasTableAdapter;
        private System.Windows.Forms.BindingSource employeeAreasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneNumberDataGridViewTextBoxColumn;
    }
}
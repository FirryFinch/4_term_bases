
namespace Макет
{
    partial class ChangeWorkAcc
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonacc = new System.Windows.Forms.Button();
            this.findbut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.макет_v2DataSet = new Макет.Макет_v2DataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.workTableAdapter = new Макет.Макет_v2DataSetTableAdapters.WorkTableAdapter();
            this.buttonadmin = new System.Windows.Forms.Button();
            this.buttonboss = new System.Windows.Forms.Button();
            this.buttoncall = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Макет.Макет_v2DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(175, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск по названию:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox1.Location = new System.Drawing.Point(385, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // buttonacc
            // 
            this.buttonacc.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonacc.ForeColor = System.Drawing.Color.Maroon;
            this.buttonacc.Location = new System.Drawing.Point(477, 467);
            this.buttonacc.Name = "buttonacc";
            this.buttonacc.Size = new System.Drawing.Size(343, 31);
            this.buttonacc.TabIndex = 13;
            this.buttonacc.Text = "Закрыть";
            this.buttonacc.UseVisualStyleBackColor = true;
            this.buttonacc.Click += new System.EventHandler(this.buttonacc_Click);
            // 
            // findbut
            // 
            this.findbut.Font = new System.Drawing.Font("Calibri", 12F);
            this.findbut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findbut.Location = new System.Drawing.Point(606, 97);
            this.findbut.Name = "findbut";
            this.findbut.Size = new System.Drawing.Size(162, 31);
            this.findbut.TabIndex = 14;
            this.findbut.Text = "Найти";
            this.findbut.UseVisualStyleBackColor = true;
            this.findbut.Click += new System.EventHandler(this.findbut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workIDDataGridViewTextBoxColumn,
            this.workNameDataGridViewTextBoxColumn,
            this.workDurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 283);
            this.dataGridView1.TabIndex = 15;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "WorkID";
            this.workIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.Visible = false;
            this.workIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // workNameDataGridViewTextBoxColumn
            // 
            this.workNameDataGridViewTextBoxColumn.DataPropertyName = "WorkName";
            this.workNameDataGridViewTextBoxColumn.HeaderText = "Название работы";
            this.workNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workNameDataGridViewTextBoxColumn.Name = "workNameDataGridViewTextBoxColumn";
            this.workNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // workDurationDataGridViewTextBoxColumn
            // 
            this.workDurationDataGridViewTextBoxColumn.DataPropertyName = "WorkDuration";
            this.workDurationDataGridViewTextBoxColumn.HeaderText = "н/ч";
            this.workDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workDurationDataGridViewTextBoxColumn.Name = "workDurationDataGridViewTextBoxColumn";
            this.workDurationDataGridViewTextBoxColumn.Width = 120;
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataMember = "Work";
            this.workBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.макет_v2DataSet;
            this.bindingSource1.Position = 0;
            // 
            // макет_v2DataSet
            // 
            this.макет_v2DataSet.DataSetName = "Макет_v2DataSet";
            this.макет_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(938, 53);
            this.panel4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(337, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Информация о работах";
            // 
            // workTableAdapter
            // 
            this.workTableAdapter.ClearBeforeFill = true;
            // 
            // buttonadmin
            // 
            this.buttonadmin.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonadmin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonadmin.Location = new System.Drawing.Point(477, 467);
            this.buttonadmin.Name = "buttonadmin";
            this.buttonadmin.Size = new System.Drawing.Size(343, 31);
            this.buttonadmin.TabIndex = 17;
            this.buttonadmin.Text = "Закрыть";
            this.buttonadmin.UseVisualStyleBackColor = true;
            this.buttonadmin.Click += new System.EventHandler(this.buttonadmin_Click);
            // 
            // buttonboss
            // 
            this.buttonboss.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonboss.ForeColor = System.Drawing.Color.Maroon;
            this.buttonboss.Location = new System.Drawing.Point(477, 467);
            this.buttonboss.Name = "buttonboss";
            this.buttonboss.Size = new System.Drawing.Size(343, 31);
            this.buttonboss.TabIndex = 18;
            this.buttonboss.Text = "Закрыть";
            this.buttonboss.UseVisualStyleBackColor = true;
            this.buttonboss.Click += new System.EventHandler(this.buttonboss_Click);
            // 
            // buttoncall
            // 
            this.buttoncall.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttoncall.ForeColor = System.Drawing.Color.Maroon;
            this.buttoncall.Location = new System.Drawing.Point(477, 466);
            this.buttoncall.Name = "buttoncall";
            this.buttoncall.Size = new System.Drawing.Size(343, 31);
            this.buttoncall.TabIndex = 19;
            this.buttoncall.Text = "Закрыть";
            this.buttoncall.UseVisualStyleBackColor = true;
            this.buttoncall.Click += new System.EventHandler(this.buttoncall_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(128, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(343, 31);
            this.button3.TabIndex = 49;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarTableAdapter = null;
            this.tableAdapterManager1.CarTypesTableAdapter = null;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.EmployeeAreasTableAdapter = null;
            this.tableAdapterManager1.EmployeeClassesTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.InOrderTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.PartTableAdapter = null;
            this.tableAdapterManager1.SystemUsersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Макет.Макет_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = this.workTableAdapter;
            // 
            // ChangeWorkAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 524);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttoncall);
            this.Controls.Add(this.buttonboss);
            this.Controls.Add(this.buttonadmin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findbut);
            this.Controls.Add(this.buttonacc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "ChangeWorkAcc";
            this.Text = "Информация о работах";
            this.Load += new System.EventHandler(this.ChangeWorkAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonacc;
        private System.Windows.Forms.Button findbut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Макет_v2DataSet макет_v2DataSet;
        private System.Windows.Forms.BindingSource workBindingSource;
        private Макет_v2DataSetTableAdapters.WorkTableAdapter workTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonadmin;
        private System.Windows.Forms.Button buttonboss;
        private System.Windows.Forms.Button buttoncall;
        private System.Windows.Forms.Button button3;
        private Макет_v2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}
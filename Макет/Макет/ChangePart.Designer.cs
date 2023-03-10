
namespace Макет
{
    partial class ChangePart
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
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partOriginalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMadeByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBelongDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.partNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.макет_v2DataSet = new Макет.Макет_v2DataSet();
            this.findbut = new System.Windows.Forms.Button();
            this.buttonacc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonadmin = new System.Windows.Forms.Button();
            this.buttonboss = new System.Windows.Forms.Button();
            this.buttoncall = new System.Windows.Forms.Button();
            this.buttonpart = new System.Windows.Forms.Button();
            this.partTableAdapter = new Макет.Макет_v2DataSetTableAdapters.PartTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Макет.Макет_v2DataSetTableAdapters.TableAdapterManager();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1297, 53);
            this.panel4.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(513, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Информация о деталях";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.partOriginalNumberDataGridViewTextBoxColumn,
            this.partMadeByDataGridViewTextBoxColumn,
            this.partBelongDataGridViewCheckBoxColumn,
            this.partNoteDataGridViewTextBoxColumn,
            this.partCostDataGridViewTextBoxColumn,
            this.partQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 311);
            this.dataGridView1.TabIndex = 21;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.Visible = false;
            this.partIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Название детали";
            this.partNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // partOriginalNumberDataGridViewTextBoxColumn
            // 
            this.partOriginalNumberDataGridViewTextBoxColumn.DataPropertyName = "PartOriginalNumber";
            this.partOriginalNumberDataGridViewTextBoxColumn.HeaderText = "№ в каталоге";
            this.partOriginalNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partOriginalNumberDataGridViewTextBoxColumn.Name = "partOriginalNumberDataGridViewTextBoxColumn";
            this.partOriginalNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // partMadeByDataGridViewTextBoxColumn
            // 
            this.partMadeByDataGridViewTextBoxColumn.DataPropertyName = "PartMadeBy";
            this.partMadeByDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.partMadeByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partMadeByDataGridViewTextBoxColumn.Name = "partMadeByDataGridViewTextBoxColumn";
            this.partMadeByDataGridViewTextBoxColumn.Width = 120;
            // 
            // partBelongDataGridViewCheckBoxColumn
            // 
            this.partBelongDataGridViewCheckBoxColumn.DataPropertyName = "PartBelong";
            this.partBelongDataGridViewCheckBoxColumn.HeaderText = "Пр.";
            this.partBelongDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.partBelongDataGridViewCheckBoxColumn.Name = "partBelongDataGridViewCheckBoxColumn";
            this.partBelongDataGridViewCheckBoxColumn.Width = 60;
            // 
            // partNoteDataGridViewTextBoxColumn
            // 
            this.partNoteDataGridViewTextBoxColumn.DataPropertyName = "PartNote";
            this.partNoteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.partNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoteDataGridViewTextBoxColumn.Name = "partNoteDataGridViewTextBoxColumn";
            this.partNoteDataGridViewTextBoxColumn.Width = 200;
            // 
            // partCostDataGridViewTextBoxColumn
            // 
            this.partCostDataGridViewTextBoxColumn.DataPropertyName = "PartCost";
            this.partCostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.partCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partCostDataGridViewTextBoxColumn.Name = "partCostDataGridViewTextBoxColumn";
            this.partCostDataGridViewTextBoxColumn.Width = 120;
            // 
            // partQuantityDataGridViewTextBoxColumn
            // 
            this.partQuantityDataGridViewTextBoxColumn.DataPropertyName = "PartQuantity";
            this.partQuantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.partQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partQuantityDataGridViewTextBoxColumn.Name = "partQuantityDataGridViewTextBoxColumn";
            this.partQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.bindingSource1;
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
            // findbut
            // 
            this.findbut.Font = new System.Drawing.Font("Calibri", 12F);
            this.findbut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findbut.Location = new System.Drawing.Point(782, 110);
            this.findbut.Name = "findbut";
            this.findbut.Size = new System.Drawing.Size(162, 31);
            this.findbut.TabIndex = 20;
            this.findbut.Text = "Найти";
            this.findbut.UseVisualStyleBackColor = true;
            this.findbut.Click += new System.EventHandler(this.findbut_Click);
            // 
            // buttonacc
            // 
            this.buttonacc.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonacc.ForeColor = System.Drawing.Color.Maroon;
            this.buttonacc.Location = new System.Drawing.Point(674, 590);
            this.buttonacc.Name = "buttonacc";
            this.buttonacc.Size = new System.Drawing.Size(343, 31);
            this.buttonacc.TabIndex = 19;
            this.buttonacc.Text = "Закрыть";
            this.buttonacc.UseVisualStyleBackColor = true;
            this.buttonacc.Click += new System.EventHandler(this.buttonacc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox1.Location = new System.Drawing.Point(561, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 18;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(359, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Поиск по названию";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(782, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 31);
            this.button2.TabIndex = 25;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox2.Location = new System.Drawing.Point(561, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 31);
            this.textBox2.TabIndex = 24;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(359, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поиск по №";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonadmin
            // 
            this.buttonadmin.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonadmin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonadmin.Location = new System.Drawing.Point(674, 590);
            this.buttonadmin.Name = "buttonadmin";
            this.buttonadmin.Size = new System.Drawing.Size(343, 31);
            this.buttonadmin.TabIndex = 26;
            this.buttonadmin.Text = "Закрыть";
            this.buttonadmin.UseVisualStyleBackColor = true;
            this.buttonadmin.Click += new System.EventHandler(this.buttonadmin_Click);
            // 
            // buttonboss
            // 
            this.buttonboss.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonboss.ForeColor = System.Drawing.Color.Maroon;
            this.buttonboss.Location = new System.Drawing.Point(674, 589);
            this.buttonboss.Name = "buttonboss";
            this.buttonboss.Size = new System.Drawing.Size(343, 31);
            this.buttonboss.TabIndex = 27;
            this.buttonboss.Text = "Закрыть";
            this.buttonboss.UseVisualStyleBackColor = true;
            this.buttonboss.Click += new System.EventHandler(this.buttonboss_Click);
            // 
            // buttoncall
            // 
            this.buttoncall.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttoncall.ForeColor = System.Drawing.Color.Maroon;
            this.buttoncall.Location = new System.Drawing.Point(674, 590);
            this.buttoncall.Name = "buttoncall";
            this.buttoncall.Size = new System.Drawing.Size(343, 31);
            this.buttoncall.TabIndex = 28;
            this.buttoncall.Text = "Закрыть";
            this.buttoncall.UseVisualStyleBackColor = true;
            this.buttoncall.Click += new System.EventHandler(this.buttoncall_Click);
            // 
            // buttonpart
            // 
            this.buttonpart.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonpart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonpart.Location = new System.Drawing.Point(674, 590);
            this.buttonpart.Name = "buttonpart";
            this.buttonpart.Size = new System.Drawing.Size(343, 31);
            this.buttonpart.TabIndex = 29;
            this.buttonpart.Text = "Закрыть";
            this.buttonpart.UseVisualStyleBackColor = true;
            this.buttonpart.Click += new System.EventHandler(this.buttonpart_Click);
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(304, 590);
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
            this.tableAdapterManager1.PartTableAdapter = this.partTableAdapter;
            this.tableAdapterManager1.SystemUsersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Макет.Макет_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = null;
            // 
            // ChangePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 652);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonpart);
            this.Controls.Add(this.buttoncall);
            this.Controls.Add(this.buttonboss);
            this.Controls.Add(this.buttonadmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findbut);
            this.Controls.Add(this.buttonacc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "ChangePart";
            this.Text = "Информация о деталях";
            this.Load += new System.EventHandler(this.ChangePart_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button findbut;
        private System.Windows.Forms.Button buttonacc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonadmin;
        private System.Windows.Forms.Button buttonboss;
        private System.Windows.Forms.Button buttoncall;
        private System.Windows.Forms.Button buttonpart;
        private Макет_v2DataSet макет_v2DataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private Макет_v2DataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partOriginalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMadeByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn partBelongDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private Макет_v2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}
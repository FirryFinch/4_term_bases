
namespace Макет
{
    partial class ChangeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeClient));
            this.partTableAdapter = new Макет.Макет_v2DataSetTableAdapters.PartTableAdapter();
            this.buttonboss = new System.Windows.Forms.Button();
            this.buttonadmin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.макет_v2DataSet = new Макет.Макет_v2DataSet();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findbut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new Макет.Макет_v2DataSetTableAdapters.ClientTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMiddleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Макет.Макет_v2DataSetTableAdapters.TableAdapterManager();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // buttonboss
            // 
            this.buttonboss.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonboss.ForeColor = System.Drawing.Color.Maroon;
            this.buttonboss.Location = new System.Drawing.Point(613, 595);
            this.buttonboss.Name = "buttonboss";
            this.buttonboss.Size = new System.Drawing.Size(343, 31);
            this.buttonboss.TabIndex = 40;
            this.buttonboss.Text = "Закрыть";
            this.buttonboss.UseVisualStyleBackColor = true;
            this.buttonboss.Click += new System.EventHandler(this.buttonboss_Click);
            // 
            // buttonadmin
            // 
            this.buttonadmin.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonadmin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonadmin.Location = new System.Drawing.Point(613, 595);
            this.buttonadmin.Name = "buttonadmin";
            this.buttonadmin.Size = new System.Drawing.Size(343, 31);
            this.buttonadmin.TabIndex = 39;
            this.buttonadmin.Text = "Закрыть";
            this.buttonadmin.UseVisualStyleBackColor = true;
            this.buttonadmin.Click += new System.EventHandler(this.buttonadmin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1204, 53);
            this.panel4.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(470, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Информация о клиентах";
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
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            this.clientIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.clientSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            this.clientSurnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientMiddleNameDataGridViewTextBoxColumn
            // 
            this.clientMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "ClientMiddleName";
            this.clientMiddleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.clientMiddleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientMiddleNameDataGridViewTextBoxColumn.Name = "clientMiddleNameDataGridViewTextBoxColumn";
            this.clientMiddleNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "ClientPhoneNumber";
            this.clientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.clientPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientPhoneNumberDataGridViewTextBoxColumn.Name = "clientPhoneNumberDataGridViewTextBoxColumn";
            this.clientPhoneNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSource1;
            // 
            // findbut
            // 
            this.findbut.Font = new System.Drawing.Font("Calibri", 12F);
            this.findbut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findbut.Location = new System.Drawing.Point(476, 138);
            this.findbut.Name = "findbut";
            this.findbut.Size = new System.Drawing.Size(162, 31);
            this.findbut.TabIndex = 33;
            this.findbut.Text = "Найти";
            this.findbut.UseVisualStyleBackColor = true;
            this.findbut.Click += new System.EventHandler(this.findbut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox1.Location = new System.Drawing.Point(249, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 31;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Поиск по фамилии:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(805, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 31);
            this.button2.TabIndex = 44;
            this.button2.Text = "Добавить данные о новом клиенте";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.clientBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1204, 26);
            this.bindingNavigator1.TabIndex = 45;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.bindingSource1;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 23);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(805, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 31);
            this.button1.TabIndex = 46;
            this.button1.Text = "Сортировка по фамилии по возрастанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn1,
            this.clientSurnameDataGridViewTextBoxColumn1,
            this.clientNameDataGridViewTextBoxColumn1,
            this.clientMiddleNameDataGridViewTextBoxColumn1,
            this.clientPhoneNumberDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.clientBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(47, 237);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1101, 326);
            this.dataGridView2.TabIndex = 47;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            this.clientIDDataGridViewTextBoxColumn1.Visible = false;
            this.clientIDDataGridViewTextBoxColumn1.Width = 120;
            // 
            // clientSurnameDataGridViewTextBoxColumn1
            // 
            this.clientSurnameDataGridViewTextBoxColumn1.DataPropertyName = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.clientSurnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientSurnameDataGridViewTextBoxColumn1.Name = "clientSurnameDataGridViewTextBoxColumn1";
            this.clientSurnameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.clientNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            this.clientNameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // clientMiddleNameDataGridViewTextBoxColumn1
            // 
            this.clientMiddleNameDataGridViewTextBoxColumn1.DataPropertyName = "ClientMiddleName";
            this.clientMiddleNameDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.clientMiddleNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientMiddleNameDataGridViewTextBoxColumn1.Name = "clientMiddleNameDataGridViewTextBoxColumn1";
            this.clientMiddleNameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // clientPhoneNumberDataGridViewTextBoxColumn1
            // 
            this.clientPhoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "ClientPhoneNumber";
            this.clientPhoneNumberDataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            this.clientPhoneNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientPhoneNumberDataGridViewTextBoxColumn1.Name = "clientPhoneNumberDataGridViewTextBoxColumn1";
            this.clientPhoneNumberDataGridViewTextBoxColumn1.Width = 200;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(227, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(343, 31);
            this.button3.TabIndex = 48;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarTableAdapter = null;
            this.tableAdapterManager1.CarTypesTableAdapter = null;
            this.tableAdapterManager1.ClientTableAdapter = this.clientTableAdapter;
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
            // ChangeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 663);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonboss);
            this.Controls.Add(this.buttonadmin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.findbut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "ChangeClient";
            this.Text = "Информация о клиентах";
            this.Load += new System.EventHandler(this.ChangeClient_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Макет_v2DataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.Button buttonboss;
        private System.Windows.Forms.Button buttonadmin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Макет_v2DataSet макет_v2DataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button findbut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Макет_v2DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMiddleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private Макет_v2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}
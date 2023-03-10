
namespace Макет
{
    partial class Car_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Client));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.макет_v2DataSet = new Макет.Макет_v2DataSet();
            this.clientTableAdapter = new Макет.Макет_v2DataSetTableAdapters.ClientTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.carTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Макет.Макет_v2DataSetTableAdapters.CarTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Макет.Макет_v2DataSetTableAdapters.TableAdapterManager();
            this.buttonboss = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.carTypesTableAdapter = new Макет.Макет_v2DataSetTableAdapters.CarTypesTableAdapter();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carGenNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.carPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carVINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1171, 53);
            this.panel4.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(470, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Клиенты и автомобили";
            // 
            // макет_v2DataSet
            // 
            this.макет_v2DataSet.DataSetName = "Макет_v2DataSet";
            this.макет_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientMiddleNameDataGridViewTextBoxColumn,
            this.clientPhoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 171);
            this.dataGridView1.TabIndex = 48;
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.макет_v2DataSet;
            this.bindingSource1.Position = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.clientBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1170, 26);
            this.bindingNavigator1.TabIndex = 49;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 8.765218F);
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.carBrandDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.carGenNumDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.carPlateDataGridViewTextBoxColumn,
            this.carVINDataGridViewTextBoxColumn,
            this.carOwnerDataGridViewTextBoxColumn,
            this.carNoteDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientCarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(35, 332);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1101, 178);
            this.dataGridView2.TabIndex = 50;
            // 
            // carTypesBindingSource
            // 
            this.carTypesBindingSource.DataMember = "CarTypes";
            this.carTypesBindingSource.DataSource = this.bindingSource1;
            // 
            // clientCarBindingSource
            // 
            this.clientCarBindingSource.DataMember = "ClientCar";
            this.clientCarBindingSource.DataSource = this.clientBindingSource;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.bindingSource1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(870, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 31);
            this.button3.TabIndex = 52;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager1.CarTypesTableAdapter = null;
            this.tableAdapterManager1.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager1.EmployeeAreasTableAdapter = null;
            this.tableAdapterManager1.EmployeeClassesTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = null;
            this.tableAdapterManager1.InOrderTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.PartTableAdapter = null;
            this.tableAdapterManager1.SystemUsersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Макет.Макет_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = null;
            // 
            // buttonboss
            // 
            this.buttonboss.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonboss.ForeColor = System.Drawing.Color.Maroon;
            this.buttonboss.Location = new System.Drawing.Point(417, 582);
            this.buttonboss.Name = "buttonboss";
            this.buttonboss.Size = new System.Drawing.Size(343, 31);
            this.buttonboss.TabIndex = 51;
            this.buttonboss.Text = "Закрыть";
            this.buttonboss.UseVisualStyleBackColor = true;
            this.buttonboss.Click += new System.EventHandler(this.buttonboss_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(586, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 31);
            this.button1.TabIndex = 53;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(315, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 31);
            this.button2.TabIndex = 54;
            this.button2.Text = "Следующий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(35, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 31);
            this.button4.TabIndex = 55;
            this.button4.Text = "Предыдущий";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(35, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 31);
            this.button5.TabIndex = 59;
            this.button5.Text = "Предыдущий";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 12F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(315, 530);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(251, 31);
            this.button6.TabIndex = 58;
            this.button6.Text = "Следующий";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 12F);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(586, 530);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(266, 31);
            this.button7.TabIndex = 57;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Calibri", 12F);
            this.button8.ForeColor = System.Drawing.Color.Green;
            this.button8.Location = new System.Drawing.Point(870, 530);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(266, 31);
            this.button8.TabIndex = 56;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // carTypesTableAdapter
            // 
            this.carTypesTableAdapter.ClearBeforeFill = true;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.Visible = false;
            this.carIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // carBrandDataGridViewTextBoxColumn
            // 
            this.carBrandDataGridViewTextBoxColumn.DataPropertyName = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.carBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carBrandDataGridViewTextBoxColumn.Name = "carBrandDataGridViewTextBoxColumn";
            this.carBrandDataGridViewTextBoxColumn.Width = 120;
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.carModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            this.carModelDataGridViewTextBoxColumn.Width = 120;
            // 
            // carGenNumDataGridViewTextBoxColumn
            // 
            this.carGenNumDataGridViewTextBoxColumn.DataPropertyName = "CarGenNum";
            this.carGenNumDataGridViewTextBoxColumn.HeaderText = "Номер кузова";
            this.carGenNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carGenNumDataGridViewTextBoxColumn.Name = "carGenNumDataGridViewTextBoxColumn";
            this.carGenNumDataGridViewTextBoxColumn.Width = 120;
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            this.carTypeDataGridViewTextBoxColumn.DataSource = this.carTypesBindingSource;
            this.carTypeDataGridViewTextBoxColumn.DisplayMember = "CarTypeName";
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.carTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            this.carTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.carTypeDataGridViewTextBoxColumn.ValueMember = "CarTypeID";
            this.carTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // carPlateDataGridViewTextBoxColumn
            // 
            this.carPlateDataGridViewTextBoxColumn.DataPropertyName = "CarPlate";
            this.carPlateDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.carPlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carPlateDataGridViewTextBoxColumn.Name = "carPlateDataGridViewTextBoxColumn";
            this.carPlateDataGridViewTextBoxColumn.Width = 120;
            // 
            // carVINDataGridViewTextBoxColumn
            // 
            this.carVINDataGridViewTextBoxColumn.DataPropertyName = "CarVIN";
            this.carVINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.carVINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carVINDataGridViewTextBoxColumn.Name = "carVINDataGridViewTextBoxColumn";
            this.carVINDataGridViewTextBoxColumn.Width = 120;
            // 
            // carOwnerDataGridViewTextBoxColumn
            // 
            this.carOwnerDataGridViewTextBoxColumn.DataPropertyName = "CarOwner";
            this.carOwnerDataGridViewTextBoxColumn.HeaderText = "CarOwner";
            this.carOwnerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carOwnerDataGridViewTextBoxColumn.Name = "carOwnerDataGridViewTextBoxColumn";
            this.carOwnerDataGridViewTextBoxColumn.Visible = false;
            this.carOwnerDataGridViewTextBoxColumn.Width = 120;
            // 
            // carNoteDataGridViewTextBoxColumn
            // 
            this.carNoteDataGridViewTextBoxColumn.DataPropertyName = "CarNote";
            this.carNoteDataGridViewTextBoxColumn.HeaderText = "CarNote";
            this.carNoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNoteDataGridViewTextBoxColumn.Name = "carNoteDataGridViewTextBoxColumn";
            this.carNoteDataGridViewTextBoxColumn.Visible = false;
            this.carNoteDataGridViewTextBoxColumn.Width = 120;
            // 
            // Car_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 634);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonboss);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Name = "Car_Client";
            this.Text = "Клиенты и автомобили";
            this.Load += new System.EventHandler(this.Car_Client_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Макет_v2DataSet макет_v2DataSet;
        private Макет_v2DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource carBindingSource;
        private Макет_v2DataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource clientCarBindingSource;
        private System.Windows.Forms.Button button3;
        private Макет_v2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button buttonboss;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource carTypesBindingSource;
        private Макет_v2DataSetTableAdapters.CarTypesTableAdapter carTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carGenNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carVINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNoteDataGridViewTextBoxColumn;
    }
}

namespace Макет
{
    partial class AddClient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.макет_v2DataSet = new Макет.Макет_v2DataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Макет.Макет_v2DataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager1 = new Макет.Макет_v2DataSetTableAdapters.TableAdapterManager();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientSurname", true));
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox1.Location = new System.Drawing.Point(466, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(264, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Фамилия";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(287, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление нового клиента";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 53);
            this.panel4.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientName", true));
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox2.Location = new System.Drawing.Point(466, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 31);
            this.textBox2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(264, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientMiddleName", true));
            this.textBox3.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox3.Location = new System.Drawing.Point(466, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 31);
            this.textBox3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(264, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "Отчество";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientPhoneNumber", true));
            this.textBox4.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox4.Location = new System.Drawing.Point(466, 274);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 31);
            this.textBox4.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(264, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Номер телефона";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(492, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F);
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(279, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 35);
            this.button2.TabIndex = 44;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSource1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager1.PartTableAdapter = null;
            this.tableAdapterManager1.SystemUsersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Макет.Макет_v2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = null;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "AddClient";
            this.Text = "Добавление нового клиента";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.макет_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Макет_v2DataSet макет_v2DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Макет_v2DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private Макет_v2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}
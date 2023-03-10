namespace Base
{
    partial class Form2
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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иУ531БАнцифровЛП2000DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИУ5_31Б_Анцифров_ЛП2000DataSet = new Base._ИУ5_31Б_Анцифров_ЛП2000DataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Base._ИУ5_31Б_Анцифров_ЛП2000DataSetTableAdapters.CarTableAdapter();
            this.clientTableAdapter = new Base._ИУ5_31Б_Анцифров_ЛП2000DataSetTableAdapters.ClientTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иУ531БАнцифровЛП2000DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИУ5_31Б_Анцифров_ЛП2000DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.иУ531БАнцифровЛП2000DataSetBindingSource;
            // 
            // иУ531БАнцифровЛП2000DataSetBindingSource
            // 
            this.иУ531БАнцифровЛП2000DataSetBindingSource.DataSource = this._ИУ5_31Б_Анцифров_ЛП2000DataSet;
            this.иУ531БАнцифровЛП2000DataSetBindingSource.Position = 0;
            // 
            // _ИУ5_31Б_Анцифров_ЛП2000DataSet
            // 
            this._ИУ5_31Б_Анцифров_ЛП2000DataSet.DataSetName = "_ИУ5_31Б_Анцифров_ЛП2000DataSet";
            this._ИУ5_31Б_Анцифров_ЛП2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.иУ531БАнцифровЛП2000DataSetBindingSource;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.иУ531БАнцифровЛП2000DataSetBindingSource;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1487, 27);
            this.fillBy1ToolStrip.TabIndex = 1;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 528);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иУ531БАнцифровЛП2000DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИУ5_31Б_Анцифров_ЛП2000DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource иУ531БАнцифровЛП2000DataSetBindingSource;
        private _ИУ5_31Б_Анцифров_ЛП2000DataSet _ИУ5_31Б_Анцифров_ЛП2000DataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private _ИУ5_31Б_Анцифров_ЛП2000DataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private _ИУ5_31Б_Анцифров_ЛП2000DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}
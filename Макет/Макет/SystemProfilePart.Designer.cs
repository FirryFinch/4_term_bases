
namespace Макет
{
    partial class SystemProfilePart
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(873, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 42);
            this.panel2.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(92, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вы успешно авторизовались под профилем: Поставщик";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Location = new System.Drawing.Point(328, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 117);
            this.panel3.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(112, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Просмотр и редактирование";
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.Font = new System.Drawing.Font("Calibri", 12F);
            this.button12.Location = new System.Drawing.Point(93, 56);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(291, 35);
            this.button12.TabIndex = 13;
            this.button12.Text = "Детали";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(-3, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1120, 53);
            this.panel5.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F);
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "АИС \"Автосервис\"";
            // 
            // SystemProfilePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Name = "SystemProfilePart";
            this.Text = "Профиль поставщика";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}
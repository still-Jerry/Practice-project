﻿namespace BeautySalon
{
    partial class Masters
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
            this.dataGridViewMaters = new System.Windows.Forms.DataGridView();
            this.EditB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.GoToMenuForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AdminSpace = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaters)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdminSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMaters
            // 
            this.dataGridViewMaters.AllowUserToAddRows = false;
            this.dataGridViewMaters.AllowUserToDeleteRows = false;
            this.dataGridViewMaters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaters.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaters.Name = "dataGridViewMaters";
            this.dataGridViewMaters.ReadOnly = true;
            this.dataGridViewMaters.Size = new System.Drawing.Size(738, 460);
            this.dataGridViewMaters.TabIndex = 0;
            // 
            // EditB
            // 
            this.EditB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditB.Location = new System.Drawing.Point(6, 4);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(145, 31);
            this.EditB.TabIndex = 0;
            this.EditB.Text = "Редактировать";
            this.EditB.UseVisualStyleBackColor = false;
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddB.Location = new System.Drawing.Point(308, 4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(145, 31);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = false;
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteB.Location = new System.Drawing.Point(157, 4);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(145, 31);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Удалить";
            this.DeleteB.UseVisualStyleBackColor = false;
            // 
            // GoToMenuForm
            // 
            this.GoToMenuForm.BackColor = System.Drawing.Color.Tan;
            this.GoToMenuForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToMenuForm.Location = new System.Drawing.Point(692, 5);
            this.GoToMenuForm.Name = "GoToMenuForm";
            this.GoToMenuForm.Size = new System.Drawing.Size(40, 30);
            this.GoToMenuForm.TabIndex = 4;
            this.GoToMenuForm.Text = "<-";
            this.GoToMenuForm.UseVisualStyleBackColor = false;
            this.GoToMenuForm.Click += new System.EventHandler(this.GoToMenuForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.GoToMenuForm);
            this.panel1.Controls.Add(this.AddB);
            this.panel1.Controls.Add(this.EditB);
            this.panel1.Controls.Add(this.DeleteB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 41);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(294, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(294, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(532, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 27);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(532, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 27);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(532, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // AdminSpace
            // 
            this.AdminSpace.BackColor = System.Drawing.SystemColors.Control;
            this.AdminSpace.Controls.Add(this.dateTimePicker1);
            this.AdminSpace.Controls.Add(this.label5);
            this.AdminSpace.Controls.Add(this.label4);
            this.AdminSpace.Controls.Add(this.textBox4);
            this.AdminSpace.Controls.Add(this.label3);
            this.AdminSpace.Controls.Add(this.textBox3);
            this.AdminSpace.Controls.Add(this.label2);
            this.AdminSpace.Controls.Add(this.textBox2);
            this.AdminSpace.Controls.Add(this.label1);
            this.AdminSpace.Controls.Add(this.textBox1);
            this.AdminSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdminSpace.Location = new System.Drawing.Point(0, 320);
            this.AdminSpace.Name = "AdminSpace";
            this.AdminSpace.Size = new System.Drawing.Size(738, 140);
            this.AdminSpace.TabIndex = 3;
            this.AdminSpace.TabStop = false;
            // 
            // Masters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminSpace);
            this.Controls.Add(this.dataGridViewMaters);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Masters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастера";
            this.Load += new System.EventHandler(this.Masters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaters)).EndInit();
            this.panel1.ResumeLayout(false);
            this.AdminSpace.ResumeLayout(false);
            this.AdminSpace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaters;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button GoToMenuForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox AdminSpace;
    }
}
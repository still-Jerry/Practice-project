namespace BeautySalon
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoToMenuForm = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.AdminSpace = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.AdminSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 8;
            // 
            // GoToMenuForm
            // 
            this.GoToMenuForm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GoToMenuForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToMenuForm.Location = new System.Drawing.Point(692, 5);
            this.GoToMenuForm.Name = "GoToMenuForm";
            this.GoToMenuForm.Size = new System.Drawing.Size(40, 30);
            this.GoToMenuForm.TabIndex = 4;
            this.GoToMenuForm.Text = "<-";
            this.GoToMenuForm.UseVisualStyleBackColor = false;
            this.GoToMenuForm.Click += new System.EventHandler(this.GoToMenuForm_Click);
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.Wheat;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddB.Location = new System.Drawing.Point(308, 4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(145, 31);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = false;
            // 
            // EditB
            // 
            this.EditB.BackColor = System.Drawing.Color.Wheat;
            this.EditB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditB.Location = new System.Drawing.Point(6, 4);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(145, 31);
            this.EditB.TabIndex = 0;
            this.EditB.Text = "Редактировать";
            this.EditB.UseVisualStyleBackColor = false;
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.Wheat;
            this.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteB.Location = new System.Drawing.Point(157, 4);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(145, 31);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Удалить";
            this.DeleteB.UseVisualStyleBackColor = false;
            // 
            // AdminSpace
            // 
            this.AdminSpace.BackColor = System.Drawing.SystemColors.Control;
            this.AdminSpace.Controls.Add(this.comboBox2);
            this.AdminSpace.Controls.Add(this.comboBox1);
            this.AdminSpace.Controls.Add(this.dateTimePicker2);
            this.AdminSpace.Controls.Add(this.label6);
            this.AdminSpace.Controls.Add(this.dateTimePicker1);
            this.AdminSpace.Controls.Add(this.label5);
            this.AdminSpace.Controls.Add(this.label3);
            this.AdminSpace.Controls.Add(this.label2);
            this.AdminSpace.Controls.Add(this.textBox2);
            this.AdminSpace.Controls.Add(this.label1);
            this.AdminSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdminSpace.Location = new System.Drawing.Point(0, 320);
            this.AdminSpace.Name = "AdminSpace";
            this.AdminSpace.Size = new System.Drawing.Size(738, 140);
            this.AdminSpace.TabIndex = 7;
            this.AdminSpace.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(294, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 26);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 26);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Время";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 20, 2, 14, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость";
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мастер";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(738, 460);
            this.dataGridViewMain.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminSpace);
            this.Controls.Add(this.dataGridViewMain);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записи на посещение";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.AdminSpace.ResumeLayout(false);
            this.AdminSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GoToMenuForm;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.GroupBox AdminSpace;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
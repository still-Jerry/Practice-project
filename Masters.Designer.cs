namespace BeautySalon
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
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatronymicField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JobTitleField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WasBornPicker = new System.Windows.Forms.DateTimePicker();
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
            this.dataGridViewMaters.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaters.Name = "dataGridViewMaters";
            this.dataGridViewMaters.ReadOnly = true;
            this.dataGridViewMaters.Size = new System.Drawing.Size(738, 277);
            this.dataGridViewMaters.TabIndex = 0;
            this.dataGridViewMaters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMaters_MouseClick);
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
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
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
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
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
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
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
            // SurnameField
            // 
            this.SurnameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameField.Location = new System.Drawing.Point(294, 39);
            this.SurnameField.MaxLength = 70;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(200, 27);
            this.SurnameField.TabIndex = 0;
            this.SurnameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameField_KeyPress);
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
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameField.Location = new System.Drawing.Point(294, 108);
            this.NameField.MaxLength = 35;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(200, 27);
            this.NameField.TabIndex = 2;
            this.NameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameField_KeyPress);
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
            // PatronymicField
            // 
            this.PatronymicField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicField.Location = new System.Drawing.Point(532, 39);
            this.PatronymicField.MaxLength = 35;
            this.PatronymicField.Name = "PatronymicField";
            this.PatronymicField.Size = new System.Drawing.Size(200, 27);
            this.PatronymicField.TabIndex = 4;
            this.PatronymicField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicField_KeyPress);
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
            // JobTitleField
            // 
            this.JobTitleField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobTitleField.Location = new System.Drawing.Point(532, 109);
            this.JobTitleField.MaxLength = 255;
            this.JobTitleField.Name = "JobTitleField";
            this.JobTitleField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.JobTitleField.Size = new System.Drawing.Size(200, 27);
            this.JobTitleField.TabIndex = 6;
            this.JobTitleField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JobTitleField_KeyPress);
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
            // WasBornPicker
            // 
            this.WasBornPicker.Location = new System.Drawing.Point(6, 39);
            this.WasBornPicker.MaxDate = new System.DateTime(2022, 6, 27, 0, 0, 0, 0);
            this.WasBornPicker.MinDate = new System.DateTime(1870, 1, 1, 0, 0, 0, 0);
            this.WasBornPicker.Name = "WasBornPicker";
            this.WasBornPicker.Size = new System.Drawing.Size(200, 27);
            this.WasBornPicker.TabIndex = 10;
            this.WasBornPicker.Value = new System.DateTime(2022, 6, 27, 0, 0, 0, 0);
            // 
            // AdminSpace
            // 
            this.AdminSpace.BackColor = System.Drawing.SystemColors.Control;
            this.AdminSpace.Controls.Add(this.WasBornPicker);
            this.AdminSpace.Controls.Add(this.label5);
            this.AdminSpace.Controls.Add(this.label4);
            this.AdminSpace.Controls.Add(this.JobTitleField);
            this.AdminSpace.Controls.Add(this.label3);
            this.AdminSpace.Controls.Add(this.PatronymicField);
            this.AdminSpace.Controls.Add(this.label2);
            this.AdminSpace.Controls.Add(this.NameField);
            this.AdminSpace.Controls.Add(this.label1);
            this.AdminSpace.Controls.Add(this.SurnameField);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Masters_FormClosing);
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
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatronymicField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JobTitleField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker WasBornPicker;
        private System.Windows.Forms.GroupBox AdminSpace;
    }
}
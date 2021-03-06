namespace BeautySalon
{
    partial class Users
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
            this.StatusCheck = new System.Windows.Forms.CheckBox();
            this.GeneratePasswdB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.AdminSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
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
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddB.Location = new System.Drawing.Point(308, 4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(145, 31);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // EditB
            // 
            this.EditB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EditB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditB.Location = new System.Drawing.Point(6, 4);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(145, 31);
            this.EditB.TabIndex = 0;
            this.EditB.Text = "Редактировать";
            this.EditB.UseVisualStyleBackColor = false;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteB.Location = new System.Drawing.Point(157, 4);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(145, 31);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Удалить";
            this.DeleteB.UseVisualStyleBackColor = false;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // AdminSpace
            // 
            this.AdminSpace.BackColor = System.Drawing.SystemColors.Control;
            this.AdminSpace.Controls.Add(this.StatusCheck);
            this.AdminSpace.Controls.Add(this.GeneratePasswdB);
            this.AdminSpace.Controls.Add(this.label4);
            this.AdminSpace.Controls.Add(this.LoginField);
            this.AdminSpace.Controls.Add(this.label3);
            this.AdminSpace.Controls.Add(this.PasswordField);
            this.AdminSpace.Controls.Add(this.label1);
            this.AdminSpace.Controls.Add(this.NameField);
            this.AdminSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdminSpace.Location = new System.Drawing.Point(0, 320);
            this.AdminSpace.Name = "AdminSpace";
            this.AdminSpace.Size = new System.Drawing.Size(738, 140);
            this.AdminSpace.TabIndex = 7;
            this.AdminSpace.TabStop = false;
            // 
            // StatusCheck
            // 
            this.StatusCheck.AutoSize = true;
            this.StatusCheck.Location = new System.Drawing.Point(9, 104);
            this.StatusCheck.Name = "StatusCheck";
            this.StatusCheck.Size = new System.Drawing.Size(220, 22);
            this.StatusCheck.TabIndex = 12;
            this.StatusCheck.Text = "Статус администратора";
            this.StatusCheck.UseVisualStyleBackColor = true;
            // 
            // GeneratePasswdB
            // 
            this.GeneratePasswdB.BackColor = System.Drawing.Color.Gainsboro;
            this.GeneratePasswdB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneratePasswdB.Location = new System.Drawing.Point(523, 99);
            this.GeneratePasswdB.Name = "GeneratePasswdB";
            this.GeneratePasswdB.Size = new System.Drawing.Size(209, 31);
            this.GeneratePasswdB.TabIndex = 11;
            this.GeneratePasswdB.Text = "Сгенерировать пароль";
            this.GeneratePasswdB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratePasswdB.UseVisualStyleBackColor = false;
            this.GeneratePasswdB.Click += new System.EventHandler(this.GeneratePasswdB_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // LoginField
            // 
            this.LoginField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginField.Location = new System.Drawing.Point(272, 39);
            this.LoginField.MaxLength = 70;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(200, 27);
            this.LoginField.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordField.Location = new System.Drawing.Point(523, 39);
            this.PasswordField.MaxLength = 30;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(209, 27);
            this.PasswordField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пароль";
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameField.Location = new System.Drawing.Point(9, 39);
            this.NameField.MaxLength = 150;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(206, 27);
            this.NameField.TabIndex = 0;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(738, 460);
            this.dataGridViewUsers.TabIndex = 6;
            this.dataGridViewUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUsers_MouseClick);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminSpace);
            this.Controls.Add(this.dataGridViewUsers);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing);
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.AdminSpace.ResumeLayout(false);
            this.AdminSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GoToMenuForm;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.GroupBox AdminSpace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.CheckBox StatusCheck;
        private System.Windows.Forms.Button GeneratePasswdB;
    }
}
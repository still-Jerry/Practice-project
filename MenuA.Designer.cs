namespace BeautySalon
{
    partial class MenuA
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
            this.GoToMainForm = new System.Windows.Forms.Button();
            this.GoToClientsForm = new System.Windows.Forms.Button();
            this.GoToAutorizationForm = new System.Windows.Forms.Button();
            this.GoToMastersForm = new System.Windows.Forms.Button();
            this.GoToUsersForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToMainForm
            // 
            this.GoToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToMainForm.BackColor = System.Drawing.SystemColors.Control;
            this.GoToMainForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GoToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToMainForm.Location = new System.Drawing.Point(12, 9);
            this.GoToMainForm.Name = "GoToMainForm";
            this.GoToMainForm.Size = new System.Drawing.Size(157, 36);
            this.GoToMainForm.TabIndex = 0;
            this.GoToMainForm.Text = "Запись";
            this.GoToMainForm.UseVisualStyleBackColor = false;
            this.GoToMainForm.Click += new System.EventHandler(this.GoToMainForm_Click);
            // 
            // GoToClientsForm
            // 
            this.GoToClientsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToClientsForm.BackColor = System.Drawing.SystemColors.Control;
            this.GoToClientsForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToClientsForm.Location = new System.Drawing.Point(12, 93);
            this.GoToClientsForm.Name = "GoToClientsForm";
            this.GoToClientsForm.Size = new System.Drawing.Size(157, 36);
            this.GoToClientsForm.TabIndex = 1;
            this.GoToClientsForm.Text = "Клиенты";
            this.GoToClientsForm.UseVisualStyleBackColor = false;
            this.GoToClientsForm.Click += new System.EventHandler(this.GoToClientsForm_Click);
            // 
            // GoToAutorizationForm
            // 
            this.GoToAutorizationForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToAutorizationForm.BackColor = System.Drawing.Color.Tan;
            this.GoToAutorizationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToAutorizationForm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToAutorizationForm.ForeColor = System.Drawing.Color.Black;
            this.GoToAutorizationForm.Location = new System.Drawing.Point(12, 177);
            this.GoToAutorizationForm.Name = "GoToAutorizationForm";
            this.GoToAutorizationForm.Size = new System.Drawing.Size(157, 47);
            this.GoToAutorizationForm.TabIndex = 3;
            this.GoToAutorizationForm.Text = "Реавторизация";
            this.GoToAutorizationForm.UseVisualStyleBackColor = false;
            this.GoToAutorizationForm.Click += new System.EventHandler(this.GoToAutorizationForm_Click);
            // 
            // GoToMastersForm
            // 
            this.GoToMastersForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToMastersForm.BackColor = System.Drawing.SystemColors.Control;
            this.GoToMastersForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToMastersForm.Location = new System.Drawing.Point(12, 51);
            this.GoToMastersForm.Name = "GoToMastersForm";
            this.GoToMastersForm.Size = new System.Drawing.Size(157, 36);
            this.GoToMastersForm.TabIndex = 4;
            this.GoToMastersForm.Text = "Мастера";
            this.GoToMastersForm.UseVisualStyleBackColor = false;
            this.GoToMastersForm.Click += new System.EventHandler(this.GoToMastersForm_Click);
            // 
            // GoToUsersForm
            // 
            this.GoToUsersForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToUsersForm.BackColor = System.Drawing.SystemColors.Control;
            this.GoToUsersForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoToUsersForm.Location = new System.Drawing.Point(12, 135);
            this.GoToUsersForm.Name = "GoToUsersForm";
            this.GoToUsersForm.Size = new System.Drawing.Size(157, 36);
            this.GoToUsersForm.TabIndex = 2;
            this.GoToUsersForm.Text = "Пользователи";
            this.GoToUsersForm.UseVisualStyleBackColor = false;
            this.GoToUsersForm.Click += new System.EventHandler(this.GoToUsersForm_Click);
            // 
            // MenuA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(182, 236);
            this.Controls.Add(this.GoToMastersForm);
            this.Controls.Add(this.GoToAutorizationForm);
            this.Controls.Add(this.GoToUsersForm);
            this.Controls.Add(this.GoToClientsForm);
            this.Controls.Add(this.GoToMainForm);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MenuA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuA_FormClosing);
            this.Load += new System.EventHandler(this.MenuA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToMainForm;
        private System.Windows.Forms.Button GoToClientsForm;
        private System.Windows.Forms.Button GoToAutorizationForm;
        private System.Windows.Forms.Button GoToMastersForm;
        private System.Windows.Forms.Button GoToUsersForm;
    }
}
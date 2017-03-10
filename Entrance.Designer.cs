namespace MyShop
{
    partial class Entrance
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
            this.LabelAutorization = new System.Windows.Forms.Label();
            this.usersDataSet = new MyShop.UsersDataSet();
            this.shopUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopUsersTableAdapter = new MyShop.UsersDataSetTableAdapters.ShopUsersTableAdapter();
            this.tableAdapterManager = new MyShop.UsersDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Enter = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Regestration = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.groupAutorization = new System.Windows.Forms.GroupBox();
            this.btnAccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopUsersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupAutorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelAutorization
            // 
            this.LabelAutorization.AutoSize = true;
            this.LabelAutorization.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAutorization.Location = new System.Drawing.Point(112, 53);
            this.LabelAutorization.Name = "LabelAutorization";
            this.LabelAutorization.Size = new System.Drawing.Size(242, 45);
            this.LabelAutorization.TabIndex = 0;
            this.LabelAutorization.Text = "Autorization";
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopUsersBindingSource
            // 
            this.shopUsersBindingSource.DataMember = "ShopUsers";
            this.shopUsersBindingSource.DataSource = this.usersDataSet;
            // 
            // shopUsersTableAdapter
            // 
            this.shopUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ShopUsersTableAdapter = this.shopUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyShop.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Enter);
            this.groupBox1.Controls.Add(this.PasswordText);
            this.groupBox1.Controls.Add(this.LoginText);
            this.groupBox1.Controls.Add(this.LoginLabel);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Enter
            // 
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(163, 197);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(172, 72);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(163, 146);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(198, 22);
            this.PasswordText.TabIndex = 2;
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(163, 66);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(198, 22);
            this.LoginText.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(38, 66);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(70, 25);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(38, 143);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(103, 25);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // Regestration
            // 
            this.Regestration.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regestration.Location = new System.Drawing.Point(24, 456);
            this.Regestration.Name = "Regestration";
            this.Regestration.Size = new System.Drawing.Size(129, 55);
            this.Regestration.TabIndex = 5;
            this.Regestration.Text = "Regestration";
            this.Regestration.UseVisualStyleBackColor = true;
            this.Regestration.Click += new System.EventHandler(this.Regestration_Click_1);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(344, 456);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(129, 55);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(38, 143);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(103, 25);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Password";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.Location = new System.Drawing.Point(38, 66);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(70, 25);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Login";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(163, 66);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(198, 22);
            this.Login.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(163, 146);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(198, 22);
            this.Password.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(352, 236);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 39);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Location = new System.Drawing.Point(5, 236);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(103, 39);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupAutorization
            // 
            this.groupAutorization.BackColor = System.Drawing.Color.Transparent;
            this.groupAutorization.Controls.Add(this.EnterButton);
            this.groupAutorization.Controls.Add(this.CloseButton);
            this.groupAutorization.Controls.Add(this.Password);
            this.groupAutorization.Controls.Add(this.Login);
            this.groupAutorization.Controls.Add(this.LabelLogin);
            this.groupAutorization.Controls.Add(this.LabelPassword);
            this.groupAutorization.Location = new System.Drawing.Point(12, 154);
            this.groupAutorization.Name = "groupAutorization";
            this.groupAutorization.Size = new System.Drawing.Size(461, 287);
            this.groupAutorization.TabIndex = 5;
            this.groupAutorization.TabStop = false;
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(175, 456);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(151, 55);
            this.btnAccess.TabIndex = 6;
            this.btnAccess.Text = "Файловый сервер";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MyShop.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 568);
            this.ControlBox = false;
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.Regestration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupAutorization);
            this.Controls.Add(this.LabelAutorization);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Entrance";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrance";
            this.Load += new System.EventHandler(this.Entrance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopUsersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAutorization.ResumeLayout(false);
            this.groupAutorization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAutorization;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource shopUsersBindingSource;
        private UsersDataSetTableAdapters.ShopUsersTableAdapter shopUsersTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Regestration;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.GroupBox groupAutorization;
        private System.Windows.Forms.Button btnAccess;

        public string login{ get; set; }
    }
}
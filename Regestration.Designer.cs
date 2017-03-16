namespace MyShop
{
    partial class Regestration
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
            this.btnRegestration = new System.Windows.Forms.Button();
            this.regLogin = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.regRepPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegestrationGroup = new System.Windows.Forms.GroupBox();
            this.RegestrationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegestration
            // 
            this.btnRegestration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegestration.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegestration.Location = new System.Drawing.Point(47, 356);
            this.btnRegestration.Name = "btnRegestration";
            this.btnRegestration.Size = new System.Drawing.Size(292, 88);
            this.btnRegestration.TabIndex = 3;
            this.btnRegestration.Text = "DONE";
            this.btnRegestration.UseVisualStyleBackColor = true;
            this.btnRegestration.Click += new System.EventHandler(this.btnRegestration_Click);
            // 
            // regLogin
            // 
            this.regLogin.Location = new System.Drawing.Point(47, 96);
            this.regLogin.Multiline = true;
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(288, 31);
            this.regLogin.TabIndex = 0;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(51, 188);
            this.regPassword.Multiline = true;
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '*';
            this.regPassword.Size = new System.Drawing.Size(288, 32);
            this.regPassword.TabIndex = 1;
            // 
            // regRepPassword
            // 
            this.regRepPassword.Location = new System.Drawing.Point(51, 273);
            this.regRepPassword.Multiline = true;
            this.regRepPassword.Name = "regRepPassword";
            this.regRepPassword.PasswordChar = '*';
            this.regRepPassword.Size = new System.Drawing.Size(288, 34);
            this.regRepPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat Password";
            // 
            // RegestrationGroup
            // 
            this.RegestrationGroup.BackColor = System.Drawing.Color.Transparent;
            this.RegestrationGroup.Controls.Add(this.label2);
            this.RegestrationGroup.Controls.Add(this.label3);
            this.RegestrationGroup.Controls.Add(this.label1);
            this.RegestrationGroup.Controls.Add(this.regRepPassword);
            this.RegestrationGroup.Controls.Add(this.regPassword);
            this.RegestrationGroup.Controls.Add(this.regLogin);
            this.RegestrationGroup.Controls.Add(this.btnRegestration);
            this.RegestrationGroup.Location = new System.Drawing.Point(55, 31);
            this.RegestrationGroup.Name = "RegestrationGroup";
            this.RegestrationGroup.Size = new System.Drawing.Size(394, 503);
            this.RegestrationGroup.TabIndex = 3;
            this.RegestrationGroup.TabStop = false;
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyShop.Properties.Resources.parol;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 568);
            this.Controls.Add(this.RegestrationGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Regestration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.RegestrationGroup.ResumeLayout(false);
            this.RegestrationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegestration;
        private System.Windows.Forms.TextBox regLogin;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.TextBox regRepPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox RegestrationGroup;
    }
}
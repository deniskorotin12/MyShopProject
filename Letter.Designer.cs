namespace MyShop
{
    partial class Letter
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
            this.button2 = new System.Windows.Forms.Button();
            this.myTelephone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.myLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myTelephone
            // 
            this.myTelephone.Location = new System.Drawing.Point(309, 347);
            this.myTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.myTelephone.Mask = "(999) 000-0000";
            this.myTelephone.Name = "myTelephone";
            this.myTelephone.Size = new System.Drawing.Size(132, 22);
            this.myTelephone.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myLetter
            // 
            this.myLetter.Location = new System.Drawing.Point(131, 22);
            this.myLetter.Margin = new System.Windows.Forms.Padding(4);
            this.myLetter.Multiline = true;
            this.myLetter.Name = "myLetter";
            this.myLetter.Size = new System.Drawing.Size(488, 245);
            this.myLetter.TabIndex = 4;
            // 
            // Letter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.myTelephone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myLetter);
            this.Name = "Letter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutAs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox myTelephone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox myLetter;
    }
}
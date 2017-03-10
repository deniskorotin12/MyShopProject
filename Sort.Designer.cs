namespace MyShop
{
    partial class Sort
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
            this.SortA = new System.Windows.Forms.Button();
            this.SortZ = new System.Windows.Forms.Button();
            this.mySort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortA
            // 
            this.SortA.Location = new System.Drawing.Point(49, 47);
            this.SortA.Name = "SortA";
            this.SortA.Size = new System.Drawing.Size(259, 52);
            this.SortA.TabIndex = 0;
            this.SortA.Text = "От А до Я";
            this.SortA.UseVisualStyleBackColor = true;
            this.SortA.Click += new System.EventHandler(this.button1_Click);
            // 
            // SortZ
            // 
            this.SortZ.Location = new System.Drawing.Point(625, 47);
            this.SortZ.Name = "SortZ";
            this.SortZ.Size = new System.Drawing.Size(259, 52);
            this.SortZ.TabIndex = 0;
            this.SortZ.Text = "От Я до А";
            this.SortZ.UseVisualStyleBackColor = true;
            this.SortZ.Click += new System.EventHandler(this.button2_Click);
            // 
            // mySort
            // 
            this.mySort.Location = new System.Drawing.Point(49, 162);
            this.mySort.Margin = new System.Windows.Forms.Padding(4);
            this.mySort.Multiline = true;
            this.mySort.Name = "mySort";
            this.mySort.Size = new System.Drawing.Size(835, 350);
            this.mySort.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перенести в Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Перенести в Exel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mySort);
            this.Controls.Add(this.SortZ);
            this.Controls.Add(this.SortA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SortA;
        private System.Windows.Forms.Button SortZ;
        private System.Windows.Forms.TextBox mySort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
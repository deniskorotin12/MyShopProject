namespace MyShop
{
    partial class Basket
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
        public void InitializeComponent()
        {
            this.basketResult = new System.Windows.Forms.GroupBox();
            this.TestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // basketResult
            // 
            this.basketResult.Location = new System.Drawing.Point(57, 179);
            this.basketResult.Name = "basketResult";
            this.basketResult.Size = new System.Drawing.Size(370, 298);
            this.basketResult.TabIndex = 8;
            this.basketResult.TabStop = false;
            // 
            // TestTextBox
            // 
            this.TestTextBox.Location = new System.Drawing.Point(535, 126);
            this.TestTextBox.Name = "TestTextBox";
            this.TestTextBox.Size = new System.Drawing.Size(380, 22);
            this.TestTextBox.TabIndex = 9;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 839);
            this.Controls.Add(this.TestTextBox);
            this.Controls.Add(this.basketResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox basketResult;
        private System.Windows.Forms.TextBox TestTextBox;
    }
}
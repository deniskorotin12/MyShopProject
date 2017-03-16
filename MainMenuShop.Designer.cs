namespace MyShop
{
    partial class MainMenuShop
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
            this.Basket = new System.Windows.Forms.Button();
            this.LabelVikki = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForMens = new System.Windows.Forms.Button();
            this.ForWoomens = new System.Windows.Forms.Button();
            this.ForKids = new System.Windows.Forms.Button();
            this.FootWear = new System.Windows.Forms.Button();
            this.OutWear = new System.Windows.Forms.Button();
            this.UnderWear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SortItems = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(22, 63);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(153, 56);
            this.Basket.TabIndex = 12;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // LabelVikki
            // 
            this.LabelVikki.AutoSize = true;
            this.LabelVikki.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVikki.Location = new System.Drawing.Point(620, 39);
            this.LabelVikki.Name = "LabelVikki";
            this.LabelVikki.Size = new System.Drawing.Size(513, 83);
            this.LabelVikki.TabIndex = 11;
            this.LabelVikki.Text = "VIKKI SHOP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAsToolStripMenuItem});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // aboutAsToolStripMenuItem
            // 
            this.aboutAsToolStripMenuItem.Name = "aboutAsToolStripMenuItem";
            this.aboutAsToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutAsToolStripMenuItem.Text = "Letter";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ForMens
            // 
            this.ForMens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForMens.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForMens.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ForMens.Location = new System.Drawing.Point(22, 189);
            this.ForMens.Name = "ForMens";
            this.ForMens.Size = new System.Drawing.Size(325, 201);
            this.ForMens.TabIndex = 15;
            this.ForMens.Text = "МУЖСКОЕ";
            this.ForMens.UseVisualStyleBackColor = true;
            this.ForMens.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForWoomens
            // 
            this.ForWoomens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForWoomens.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForWoomens.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ForWoomens.Location = new System.Drawing.Point(434, 189);
            this.ForWoomens.Name = "ForWoomens";
            this.ForWoomens.Size = new System.Drawing.Size(325, 201);
            this.ForWoomens.TabIndex = 15;
            this.ForWoomens.Text = "ЖЕНСКОЕ";
            this.ForWoomens.UseVisualStyleBackColor = true;
            this.ForWoomens.Click += new System.EventHandler(this.button2_Click);
            // 
            // ForKids
            // 
            this.ForKids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForKids.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForKids.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ForKids.Location = new System.Drawing.Point(852, 189);
            this.ForKids.Name = "ForKids";
            this.ForKids.Size = new System.Drawing.Size(325, 201);
            this.ForKids.TabIndex = 15;
            this.ForKids.Text = "ДЕТСКОЕ";
            this.ForKids.UseVisualStyleBackColor = true;
            this.ForKids.Click += new System.EventHandler(this.button3_Click);
            // 
            // FootWear
            // 
            this.FootWear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FootWear.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FootWear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FootWear.Location = new System.Drawing.Point(22, 446);
            this.FootWear.Name = "FootWear";
            this.FootWear.Size = new System.Drawing.Size(325, 201);
            this.FootWear.TabIndex = 15;
            this.FootWear.Text = "ОБУВЬ";
            this.FootWear.UseVisualStyleBackColor = true;
            this.FootWear.Click += new System.EventHandler(this.button4_Click);
            // 
            // OutWear
            // 
            this.OutWear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutWear.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutWear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OutWear.Location = new System.Drawing.Point(434, 446);
            this.OutWear.Name = "OutWear";
            this.OutWear.Size = new System.Drawing.Size(325, 201);
            this.OutWear.TabIndex = 15;
            this.OutWear.Text = "ВЕРХНЯЯ ОДЕЖДА";
            this.OutWear.UseVisualStyleBackColor = true;
            this.OutWear.Click += new System.EventHandler(this.button5_Click);
            // 
            // UnderWear
            // 
            this.UnderWear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnderWear.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderWear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UnderWear.Location = new System.Drawing.Point(852, 446);
            this.UnderWear.Name = "UnderWear";
            this.UnderWear.Size = new System.Drawing.Size(325, 201);
            this.UnderWear.TabIndex = 15;
            this.UnderWear.Text = "НИЖНЕЕ БЕЛЬЕ";
            this.UnderWear.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 750);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 44);
            this.button7.TabIndex = 17;
            this.button7.Text = "Запросы";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // SortItems
            // 
            this.SortItems.Location = new System.Drawing.Point(914, 749);
            this.SortItems.Name = "SortItems";
            this.SortItems.Size = new System.Drawing.Size(199, 47);
            this.SortItems.TabIndex = 16;
            this.SortItems.Text = "Сортировка товаров";
            this.SortItems.UseVisualStyleBackColor = true;
            // 
            // MainMenuShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1208, 839);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SortItems);
            this.Controls.Add(this.UnderWear);
            this.Controls.Add(this.ForKids);
            this.Controls.Add(this.OutWear);
            this.Controls.Add(this.ForWoomens);
            this.Controls.Add(this.FootWear);
            this.Controls.Add(this.ForMens);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.LabelVikki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenuShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuShop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Basket;
        private System.Windows.Forms.Label LabelVikki;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button ForMens;
        private System.Windows.Forms.Button ForWoomens;
        private System.Windows.Forms.Button ForKids;
        private System.Windows.Forms.Button FootWear;
        private System.Windows.Forms.Button OutWear;
        private System.Windows.Forms.Button UnderWear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SortItems;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
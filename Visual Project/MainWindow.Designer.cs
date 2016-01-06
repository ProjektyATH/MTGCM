namespace MTGCM
{
    partial class MainWindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Language_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Subtype_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Type_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Rarity_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Block_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Set_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Card_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CardBase_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Other_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Artist_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Deck_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OwnedCard_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Owned_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LogInTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.User_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Language_TSMI
            // 
            this.Language_TSMI.Name = "Language_TSMI";
            this.Language_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Language_TSMI.Text = "Języki";
            this.Language_TSMI.Click += new System.EventHandler(this.Language_TSMI_Click);
            // 
            // Subtype_TSMI
            // 
            this.Subtype_TSMI.Name = "Subtype_TSMI";
            this.Subtype_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Subtype_TSMI.Text = "Podtypy";
            this.Subtype_TSMI.Click += new System.EventHandler(this.Subtype_TSMI_Click);
            // 
            // Type_TSMI
            // 
            this.Type_TSMI.Name = "Type_TSMI";
            this.Type_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Type_TSMI.Text = "Typy";
            this.Type_TSMI.Click += new System.EventHandler(this.Type_TSMI_Click);
            // 
            // Rarity_TSMI
            // 
            this.Rarity_TSMI.Name = "Rarity_TSMI";
            this.Rarity_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Rarity_TSMI.Text = "Rzadkość";
            // 
            // Block_TSMI
            // 
            this.Block_TSMI.Name = "Block_TSMI";
            this.Block_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Block_TSMI.Text = "Bloki";
            // 
            // Set_TSMI
            // 
            this.Set_TSMI.Name = "Set_TSMI";
            this.Set_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Set_TSMI.Text = "Zestawy";
            // 
            // Card_TSMI
            // 
            this.Card_TSMI.Name = "Card_TSMI";
            this.Card_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Card_TSMI.Text = "Karty dostępne";
            this.Card_TSMI.Click += new System.EventHandler(this.Card_TSMI_Click);
            // 
            // CardBase_TSMI
            // 
            this.CardBase_TSMI.Name = "CardBase_TSMI";
            this.CardBase_TSMI.Size = new System.Drawing.Size(153, 22);
            this.CardBase_TSMI.Text = "Bazy kart";
            // 
            // Other_TSMI
            // 
            this.Other_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CardBase_TSMI,
            this.Card_TSMI,
            this.Set_TSMI,
            this.Block_TSMI,
            this.Rarity_TSMI,
            this.Type_TSMI,
            this.Subtype_TSMI,
            this.Language_TSMI,
            this.Artist_TSMI});
            this.Other_TSMI.Name = "Other_TSMI";
            this.Other_TSMI.Size = new System.Drawing.Size(90, 20);
            this.Other_TSMI.Text = "Obsługa bazy";
            // 
            // Artist_TSMI
            // 
            this.Artist_TSMI.Name = "Artist_TSMI";
            this.Artist_TSMI.Size = new System.Drawing.Size(153, 22);
            this.Artist_TSMI.Text = "Artyści";
            this.Artist_TSMI.Click += new System.EventHandler(this.Artist_TSMI_Click);
            // 
            // Deck_TSMI
            // 
            this.Deck_TSMI.Name = "Deck_TSMI";
            this.Deck_TSMI.Size = new System.Drawing.Size(101, 22);
            this.Deck_TSMI.Text = "Talie";
            // 
            // OwnedCard_TSMI
            // 
            this.OwnedCard_TSMI.Name = "OwnedCard_TSMI";
            this.OwnedCard_TSMI.Size = new System.Drawing.Size(101, 22);
            this.OwnedCard_TSMI.Text = "Karty";
            // 
            // Owned_TSMI
            // 
            this.Owned_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OwnedCard_TSMI,
            this.Deck_TSMI});
            this.Owned_TSMI.Name = "Owned_TSMI";
            this.Owned_TSMI.Size = new System.Drawing.Size(46, 20);
            this.Owned_TSMI.Text = "Moje";
            // 
            // LogInTSMI
            // 
            this.LogInTSMI.Name = "LogInTSMI";
            this.LogInTSMI.Size = new System.Drawing.Size(141, 22);
            this.LogInTSMI.Text = "Zaloguj";
            // 
            // User_TSMI
            // 
            this.User_TSMI.Name = "User_TSMI";
            this.User_TSMI.Size = new System.Drawing.Size(141, 22);
            this.User_TSMI.Text = "Użytkownicy";
            // 
            // Main_TSMI
            // 
            this.Main_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.User_TSMI,
            this.LogInTSMI});
            this.Main_TSMI.Name = "Main_TSMI";
            this.Main_TSMI.Size = new System.Drawing.Size(50, 20);
            this.Main_TSMI.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_TSMI,
            this.Owned_TSMI,
            this.Other_TSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zalogowany:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem Language_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Subtype_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Type_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Rarity_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Block_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Set_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Card_TSMI;
        private System.Windows.Forms.ToolStripMenuItem CardBase_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Other_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Artist_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Deck_TSMI;
        private System.Windows.Forms.ToolStripMenuItem OwnedCard_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Owned_TSMI;
        private System.Windows.Forms.ToolStripMenuItem LogInTSMI;
        private System.Windows.Forms.ToolStripMenuItem User_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Main_TSMI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
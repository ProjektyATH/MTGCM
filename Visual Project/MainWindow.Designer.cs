﻿namespace MTGCM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Language_TSMI
            // 
            this.Language_TSMI.Name = "Language_TSMI";
            this.Language_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Language_TSMI.Text = "Języki";
            this.Language_TSMI.Click += new System.EventHandler(this.Language_TSMI_Click);
            // 
            // Subtype_TSMI
            // 
            this.Subtype_TSMI.Name = "Subtype_TSMI";
            this.Subtype_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Subtype_TSMI.Text = "Podtypy";
            this.Subtype_TSMI.Click += new System.EventHandler(this.Subtype_TSMI_Click);
            // 
            // Type_TSMI
            // 
            this.Type_TSMI.Name = "Type_TSMI";
            this.Type_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Type_TSMI.Text = "Typy";
            this.Type_TSMI.Click += new System.EventHandler(this.Type_TSMI_Click);
            // 
            // Rarity_TSMI
            // 
            this.Rarity_TSMI.Name = "Rarity_TSMI";
            this.Rarity_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Rarity_TSMI.Text = "Rzadkość";
            this.Rarity_TSMI.Click += new System.EventHandler(this.Rarity_TSMI_Click);
            // 
            // Block_TSMI
            // 
            this.Block_TSMI.Name = "Block_TSMI";
            this.Block_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Block_TSMI.Text = "Bloki";
            this.Block_TSMI.Click += new System.EventHandler(this.Block_TSMI_Click);
            // 
            // Set_TSMI
            // 
            this.Set_TSMI.Name = "Set_TSMI";
            this.Set_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Set_TSMI.Text = "Zestawy";
            this.Set_TSMI.Click += new System.EventHandler(this.Set_TSMI_Click);
            // 
            // Card_TSMI
            // 
            this.Card_TSMI.Name = "Card_TSMI";
            this.Card_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Card_TSMI.Text = "Typy Zestawów";
            this.Card_TSMI.Click += new System.EventHandler(this.Card_TSMI_Click);
            // 
            // CardBase_TSMI
            // 
            this.CardBase_TSMI.Name = "CardBase_TSMI";
            this.CardBase_TSMI.Size = new System.Drawing.Size(156, 22);
            this.CardBase_TSMI.Text = "Bazy kart";
            this.CardBase_TSMI.Click += new System.EventHandler(this.CardBase_TSMI_Click);
            // 
            // Other_TSMI
            // 
            this.Other_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CardBase_TSMI,
            this.Set_TSMI,
            this.Block_TSMI,
            this.Rarity_TSMI,
            this.Type_TSMI,
            this.Subtype_TSMI,
            this.Language_TSMI,
            this.Artist_TSMI,
            this.Card_TSMI});
            this.Other_TSMI.Name = "Other_TSMI";
            this.Other_TSMI.Size = new System.Drawing.Size(90, 20);
            this.Other_TSMI.Text = "Obsługa bazy";
            // 
            // Artist_TSMI
            // 
            this.Artist_TSMI.Name = "Artist_TSMI";
            this.Artist_TSMI.Size = new System.Drawing.Size(156, 22);
            this.Artist_TSMI.Text = "Artyści";
            this.Artist_TSMI.Click += new System.EventHandler(this.Artist_TSMI_Click);
            // 
            // Deck_TSMI
            // 
            this.Deck_TSMI.Name = "Deck_TSMI";
            this.Deck_TSMI.Size = new System.Drawing.Size(101, 22);
            this.Deck_TSMI.Text = "Talie";
            this.Deck_TSMI.Click += new System.EventHandler(this.Deck_TSMI_Click);
            // 
            // OwnedCard_TSMI
            // 
            this.OwnedCard_TSMI.Name = "OwnedCard_TSMI";
            this.OwnedCard_TSMI.Size = new System.Drawing.Size(101, 22);
            this.OwnedCard_TSMI.Text = "Karty";
            this.OwnedCard_TSMI.Click += new System.EventHandler(this.OwnedCard_TSMI_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Owned_TSMI,
            this.Other_TSMI,
            this.importerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
    }
}
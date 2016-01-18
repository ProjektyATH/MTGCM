namespace MTGCM.Forms
{
    partial class CardSubtype_List
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
            this.buttonFiltrate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImmageTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new MTGCM.DBDataSet();
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistTableAdapter = new MTGCM.DBDataSetTableAdapters.ArtistTableAdapter();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setTableAdapter = new MTGCM.DBDataSetTableAdapters.SetTableAdapter();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageTableAdapter = new MTGCM.DBDataSetTableAdapters.LanguageTableAdapter();
            this.cardBaseTableAdapter = new MTGCM.DBDataSetTableAdapters.CardBaseTableAdapter();
            this.rarityTableAdapter = new MTGCM.DBDataSetTableAdapters.RarityTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFiltrate
            // 
            this.buttonFiltrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFiltrate.Location = new System.Drawing.Point(5, 10);
            this.buttonFiltrate.Name = "buttonFiltrate";
            this.buttonFiltrate.Size = new System.Drawing.Size(153, 39);
            this.buttonFiltrate.TabIndex = 0;
            this.buttonFiltrate.Text = "Filtruj";
            this.buttonFiltrate.UseVisualStyleBackColor = true;
            this.buttonFiltrate.Click += new System.EventHandler(this.buttonFiltrate_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ImmageTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Location = new System.Drawing.Point(857, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 420);
            this.panel2.TabIndex = 5;
            // 
            // ImmageTB
            // 
            this.ImmageTB.Location = new System.Drawing.Point(6, 55);
            this.ImmageTB.Name = "ImmageTB";
            this.ImmageTB.Size = new System.Drawing.Size(186, 20);
            this.ImmageTB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PodTyp";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(23, 387);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(23, 351);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 30);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(23, 315);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataMember = "Rarity";
            this.rarityBindingSource.DataSource = this.dBDataSet;
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.dBDataSet;
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.dBDataSet;
            // 
            // cardBaseBindingSource
            // 
            this.cardBaseBindingSource.DataMember = "CardBase";
            this.cardBaseBindingSource.DataSource = this.dBDataSet;
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.dBDataSet;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSetBindingSource
            // 
            this.dBDataSetBindingSource.DataSource = this.dBDataSet;
            this.dBDataSetBindingSource.Position = 0;
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // cardBaseTableAdapter
            // 
            this.cardBaseTableAdapter.ClearBeforeFill = true;
            // 
            // rarityTableAdapter
            // 
            this.rarityTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.checkBoxName);
            this.panel1.Controls.Add(this.buttonFiltrate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 420);
            this.panel1.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(5, 55);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(63, 17);
            this.checkBoxName.TabIndex = 1;
            this.checkBoxName.Text = "PodTyp";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 420);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // CardSubtype_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CardSubtype_List";
            this.Text = "CardSubtype_List";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBaseBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource setBindingSource;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource rarityBindingSource;
        private System.Windows.Forms.TextBox ImmageTB;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private System.Windows.Forms.BindingSource cardBaseBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private DBDataSetTableAdapters.ArtistTableAdapter artistTableAdapter;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private DBDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private DBDataSetTableAdapters.LanguageTableAdapter languageTableAdapter;
        private DBDataSetTableAdapters.CardBaseTableAdapter cardBaseTableAdapter;
        private DBDataSetTableAdapters.RarityTableAdapter rarityTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
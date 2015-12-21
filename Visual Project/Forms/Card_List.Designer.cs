namespace MTGCM.Forms
{
    partial class Card_List
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new MTGCM.DBDataSet();
            this.checkBoxLanguage = new System.Windows.Forms.CheckBox();
            this.checkBoxSet = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cardTableAdapter = new MTGCM.DBDataSetTableAdapters.CardTableAdapter();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setTableAdapter = new MTGCM.DBDataSetTableAdapters.SetTableAdapter();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageTableAdapter = new MTGCM.DBDataSetTableAdapters.LanguageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.comboBoxLanguage);
            this.panel1.Controls.Add(this.comboBoxSet);
            this.panel1.Controls.Add(this.checkBoxLanguage);
            this.panel1.Controls.Add(this.checkBoxSet);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.checkBoxName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 355);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.DataSource = this.setBindingSource;
            this.comboBoxSet.DisplayMember = "name";
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Location = new System.Drawing.Point(19, 127);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(144, 21);
            this.comboBoxSet.TabIndex = 5;
            this.comboBoxSet.ValueMember = "name";
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxLanguage
            // 
            this.checkBoxLanguage.AutoSize = true;
            this.checkBoxLanguage.Location = new System.Drawing.Point(5, 154);
            this.checkBoxLanguage.Name = "checkBoxLanguage";
            this.checkBoxLanguage.Size = new System.Drawing.Size(53, 17);
            this.checkBoxLanguage.TabIndex = 4;
            this.checkBoxLanguage.Text = "Język";
            this.checkBoxLanguage.UseVisualStyleBackColor = true;
            // 
            // checkBoxSet
            // 
            this.checkBoxSet.AutoSize = true;
            this.checkBoxSet.Location = new System.Drawing.Point(5, 104);
            this.checkBoxSet.Name = "checkBoxSet";
            this.checkBoxSet.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSet.TabIndex = 3;
            this.checkBoxSet.Text = "Dodatek";
            this.checkBoxSet.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(19, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(5, 55);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(85, 17);
            this.checkBoxName.TabIndex = 1;
            this.checkBoxName.Text = "Nazwa karty";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(5, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filtruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(613, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 355);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(23, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(23, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(23, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DataSource = this.languageBindingSource;
            this.comboBoxLanguage.DisplayMember = "name";
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(19, 177);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(144, 21);
            this.comboBoxLanguage.TabIndex = 6;
            this.comboBoxLanguage.ValueMember = "name";
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.dBDataSet;
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
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.dBDataSet;
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // Card_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Card_List";
            this.Text = "Card_List";
            this.Load += new System.EventHandler(this.Card_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSet;
        private System.Windows.Forms.CheckBox checkBoxLanguage;
        private System.Windows.Forms.CheckBox checkBoxSet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private DBDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.BindingSource setBindingSource;
        private DBDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private DBDataSetTableAdapters.LanguageTableAdapter languageTableAdapter;
    }
}
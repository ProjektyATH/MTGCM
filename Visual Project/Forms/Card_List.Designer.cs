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
            this.numericUpDownCMC = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCMC = new System.Windows.Forms.CheckBox();
            this.checkBoxTo = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFrom = new System.Windows.Forms.CheckBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new MTGCM.DBDataSet();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxLanguage = new System.Windows.Forms.CheckBox();
            this.checkBoxSet = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.buttonFiltrate = new System.Windows.Forms.Button();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumberNUD = new System.Windows.Forms.NumericUpDown();
            this.TextTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VersionTB = new System.Windows.Forms.TextBox();
            this.SetCB = new System.Windows.Forms.ComboBox();
            this.RarityCB = new System.Windows.Forms.ComboBox();
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImmageTB = new System.Windows.Forms.TextBox();
            this.ArtistCB = new System.Windows.Forms.ComboBox();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LanguageCB = new System.Windows.Forms.ComboBox();
            this.BaseCB = new System.Windows.Forms.ComboBox();
            this.cardBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.cardTableAdapter = new MTGCM.DBDataSetTableAdapters.CardTableAdapter();
            this.setTableAdapter = new MTGCM.DBDataSetTableAdapters.SetTableAdapter();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageTableAdapter = new MTGCM.DBDataSetTableAdapters.LanguageTableAdapter();
            this.cardBaseTableAdapter = new MTGCM.DBDataSetTableAdapters.CardBaseTableAdapter();
            this.artistTableAdapter = new MTGCM.DBDataSetTableAdapters.ArtistTableAdapter();
            this.rarityTableAdapter = new MTGCM.DBDataSetTableAdapters.RarityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(646, 406);
            this.dataGridView1.TabIndex = 0;

            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter_1);

            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.numericUpDownCMC);
            this.panel1.Controls.Add(this.checkBoxCMC);
            this.panel1.Controls.Add(this.checkBoxTo);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.checkBoxFrom);
            this.panel1.Controls.Add(this.comboBoxLanguage);
            this.panel1.Controls.Add(this.comboBoxSet);
            this.panel1.Controls.Add(this.checkBoxLanguage);
            this.panel1.Controls.Add(this.checkBoxSet);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.checkBoxName);
            this.panel1.Controls.Add(this.buttonFiltrate);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 406);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDownCMC
            // 
            this.numericUpDownCMC.Location = new System.Drawing.Point(14, 328);
            this.numericUpDownCMC.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownCMC.Name = "numericUpDownCMC";
            this.numericUpDownCMC.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownCMC.TabIndex = 13;
            this.numericUpDownCMC.ValueChanged += new System.EventHandler(this.numericUpDownCMC_ValueChanged);
            // 
            // checkBoxCMC
            // 
            this.checkBoxCMC.AutoSize = true;
            this.checkBoxCMC.Location = new System.Drawing.Point(0, 309);
            this.checkBoxCMC.Name = "checkBoxCMC";
            this.checkBoxCMC.Size = new System.Drawing.Size(111, 17);
            this.checkBoxCMC.TabIndex = 12;
            this.checkBoxCMC.Text = "Sumaryczny koszt";
            this.checkBoxCMC.UseMnemonic = false;
            this.checkBoxCMC.UseVisualStyleBackColor = true;
            this.checkBoxCMC.CheckedChanged += new System.EventHandler(this.checkBoxCMC_CheckedChanged);
            // 
            // checkBoxTo
            // 
            this.checkBoxTo.AutoSize = true;
            this.checkBoxTo.Location = new System.Drawing.Point(14, 261);
            this.checkBoxTo.Name = "checkBoxTo";
            this.checkBoxTo.Size = new System.Drawing.Size(43, 17);
            this.checkBoxTo.TabIndex = 11;
            this.checkBoxTo.Text = "Do:";
            this.checkBoxTo.UseVisualStyleBackColor = true;
            this.checkBoxTo.CheckedChanged += new System.EventHandler(this.checkBoxTo_CheckedChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(14, 277);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTo.TabIndex = 10;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Wydania";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(14, 240);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2050, 1, 4, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerFrom.TabIndex = 8;
            this.dateTimePickerFrom.Value = new System.DateTime(2016, 1, 4, 0, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // checkBoxFrom
            // 
            this.checkBoxFrom.AutoSize = true;
            this.checkBoxFrom.Location = new System.Drawing.Point(14, 226);
            this.checkBoxFrom.Name = "checkBoxFrom";
            this.checkBoxFrom.Size = new System.Drawing.Size(43, 17);
            this.checkBoxFrom.TabIndex = 7;
            this.checkBoxFrom.Text = "Od:";
            this.checkBoxFrom.UseVisualStyleBackColor = true;
            this.checkBoxFrom.CheckedChanged += new System.EventHandler(this.checkBoxFrom_CheckedChanged);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DataSource = this.languageBindingSource;
            this.comboBoxLanguage.DisplayMember = "name";
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(14, 177);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(144, 21);
            this.comboBoxLanguage.TabIndex = 6;
            this.comboBoxLanguage.ValueMember = "name";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.dBDataSet;
            this.languageBindingSource.CurrentChanged += new System.EventHandler(this.languageBindingSource_CurrentChanged);
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.DataSource = this.setBindingSource;
            this.comboBoxSet.DisplayMember = "name";
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Location = new System.Drawing.Point(14, 127);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(144, 21);
            this.comboBoxSet.TabIndex = 5;
            this.comboBoxSet.ValueMember = "name";
            this.comboBoxSet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSet_SelectedIndexChanged);
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.dBDataSet;
            this.setBindingSource.CurrentChanged += new System.EventHandler(this.setBindingSource_CurrentChanged);
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
            this.checkBoxLanguage.CheckedChanged += new System.EventHandler(this.checkBoxLanguage_CheckedChanged);
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
            this.checkBoxSet.CheckedChanged += new System.EventHandler(this.checkBoxSet_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(14, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
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
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
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
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.dBDataSet;
            this.cardBindingSource.CurrentChanged += new System.EventHandler(this.cardBindingSource_CurrentChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.NumberNUD);
            this.panel2.Controls.Add(this.TextTB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.VersionTB);
            this.panel2.Controls.Add(this.SetCB);
            this.panel2.Controls.Add(this.RarityCB);
            this.panel2.Controls.Add(this.ImmageTB);
            this.panel2.Controls.Add(this.ArtistCB);
            this.panel2.Controls.Add(this.LanguageCB);
            this.panel2.Controls.Add(this.BaseCB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Location = new System.Drawing.Point(829, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 406);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // NumberNUD
            // 
            this.NumberNUD.Location = new System.Drawing.Point(77, 195);
            this.NumberNUD.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.NumberNUD.Name = "NumberNUD";
            this.NumberNUD.Size = new System.Drawing.Size(121, 20);
            this.NumberNUD.TabIndex = 21;
            this.NumberNUD.ValueChanged += new System.EventHandler(this.NumberNUD_ValueChanged);
            // 
            // TextTB
            // 
            this.TextTB.AcceptsReturn = true;
            this.TextTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextTB.Location = new System.Drawing.Point(77, 169);
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(121, 20);
            this.TextTB.TabIndex = 20;
            this.TextTB.TextChanged += new System.EventHandler(this.TextTB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tekst";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // VersionTB
            // 
            this.VersionTB.AcceptsReturn = true;
            this.VersionTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VersionTB.Location = new System.Drawing.Point(77, 221);
            this.VersionTB.Name = "VersionTB";
            this.VersionTB.Size = new System.Drawing.Size(121, 20);
            this.VersionTB.TabIndex = 17;
            this.VersionTB.TextChanged += new System.EventHandler(this.VersionTB_TextChanged);
            // 
            // SetCB
            // 
            this.SetCB.DataSource = this.setBindingSource;
            this.SetCB.DisplayMember = "name";
            this.SetCB.FormattingEnabled = true;
            this.SetCB.Location = new System.Drawing.Point(77, 142);
            this.SetCB.Name = "SetCB";
            this.SetCB.Size = new System.Drawing.Size(121, 21);
            this.SetCB.TabIndex = 16;
            this.SetCB.ValueMember = "id";
            this.SetCB.SelectedIndexChanged += new System.EventHandler(this.SetCB_SelectedIndexChanged);
            // 
            // RarityCB
            // 
            this.RarityCB.DataSource = this.rarityBindingSource;
            this.RarityCB.DisplayMember = "name";
            this.RarityCB.FormattingEnabled = true;
            this.RarityCB.Location = new System.Drawing.Point(77, 115);
            this.RarityCB.Name = "RarityCB";
            this.RarityCB.Size = new System.Drawing.Size(121, 21);
            this.RarityCB.TabIndex = 15;
            this.RarityCB.ValueMember = "id";
            this.RarityCB.SelectedIndexChanged += new System.EventHandler(this.RarityCB_SelectedIndexChanged);
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataMember = "Rarity";
            this.rarityBindingSource.DataSource = this.dBDataSet;
            this.rarityBindingSource.CurrentChanged += new System.EventHandler(this.rarityBindingSource_CurrentChanged);
            // 
            // ImmageTB
            // 
            this.ImmageTB.Location = new System.Drawing.Point(77, 62);
            this.ImmageTB.Name = "ImmageTB";
            this.ImmageTB.Size = new System.Drawing.Size(121, 20);
            this.ImmageTB.TabIndex = 14;
            this.ImmageTB.TextChanged += new System.EventHandler(this.ImmageTB_TextChanged);
            // 
            // ArtistCB
            // 
            this.ArtistCB.DataSource = this.artistBindingSource;
            this.ArtistCB.DisplayMember = "name";
            this.ArtistCB.FormattingEnabled = true;
            this.ArtistCB.Location = new System.Drawing.Point(77, 88);
            this.ArtistCB.Name = "ArtistCB";
            this.ArtistCB.Size = new System.Drawing.Size(121, 21);
            this.ArtistCB.TabIndex = 13;
            this.ArtistCB.ValueMember = "id";
            this.ArtistCB.SelectedIndexChanged += new System.EventHandler(this.ArtistCB_SelectedIndexChanged);
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.dBDataSet;
            this.artistBindingSource.CurrentChanged += new System.EventHandler(this.artistBindingSource_CurrentChanged);
            // 
            // LanguageCB
            // 
            this.LanguageCB.DataSource = this.languageBindingSource;
            this.LanguageCB.DisplayMember = "name";
            this.LanguageCB.FormattingEnabled = true;
            this.LanguageCB.Location = new System.Drawing.Point(77, 35);
            this.LanguageCB.Name = "LanguageCB";
            this.LanguageCB.Size = new System.Drawing.Size(121, 21);
            this.LanguageCB.TabIndex = 12;
            this.LanguageCB.ValueMember = "id";
            this.LanguageCB.SelectedIndexChanged += new System.EventHandler(this.LanguageCB_SelectedIndexChanged);
            // 
            // BaseCB
            // 
            this.BaseCB.DataSource = this.cardBaseBindingSource;
            this.BaseCB.DisplayMember = "name";
            this.BaseCB.FormattingEnabled = true;
            this.BaseCB.Location = new System.Drawing.Point(77, 8);
            this.BaseCB.Name = "BaseCB";
            this.BaseCB.Size = new System.Drawing.Size(121, 21);
            this.BaseCB.TabIndex = 11;
            this.BaseCB.ValueMember = "id";
            this.BaseCB.SelectedIndexChanged += new System.EventHandler(this.BaseCB_SelectedIndexChanged);
            // 
            // cardBaseBindingSource
            // 
            this.cardBaseBindingSource.DataMember = "CardBase";
            this.cardBaseBindingSource.DataSource = this.dBDataSet;
            this.cardBaseBindingSource.CurrentChanged += new System.EventHandler(this.cardBaseBindingSource_CurrentChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Wersja";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Numer";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dodatek";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unikatowość";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Artysta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zdjęcie";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Język";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bazowa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(23, 373);
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
            this.buttonEdit.Location = new System.Drawing.Point(23, 337);
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
            this.buttonAdd.Location = new System.Drawing.Point(23, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSetBindingSource
            // 
            this.dBDataSetBindingSource.DataSource = this.dBDataSet;
            this.dBDataSetBindingSource.Position = 0;
            this.dBDataSetBindingSource.CurrentChanged += new System.EventHandler(this.dBDataSetBindingSource_CurrentChanged);
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // cardBaseTableAdapter
            // 
            this.cardBaseTableAdapter.ClearBeforeFill = true;
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // rarityTableAdapter
            // 
            this.rarityTableAdapter.ClearBeforeFill = true;
            // 
            // Card_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 413);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Card_List";
            this.Text = "Card_List";
            this.Load += new System.EventHandler(this.Card_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonFiltrate;
        private System.Windows.Forms.Panel panel2;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private DBDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.BindingSource setBindingSource;
        private DBDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private DBDataSetTableAdapters.LanguageTableAdapter languageTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.CheckBox checkBoxFrom;
        private System.Windows.Forms.CheckBox checkBoxTo;
        private System.Windows.Forms.NumericUpDown numericUpDownCMC;
        private System.Windows.Forms.CheckBox checkBoxCMC;
        private System.Windows.Forms.TextBox VersionTB;
        private System.Windows.Forms.ComboBox SetCB;
        private System.Windows.Forms.ComboBox RarityCB;
        private System.Windows.Forms.TextBox ImmageTB;
        private System.Windows.Forms.ComboBox ArtistCB;
        private System.Windows.Forms.ComboBox LanguageCB;
        private System.Windows.Forms.ComboBox BaseCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cardBaseBindingSource;
        private DBDataSetTableAdapters.CardBaseTableAdapter cardBaseTableAdapter;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private DBDataSetTableAdapters.ArtistTableAdapter artistTableAdapter;
        private System.Windows.Forms.BindingSource rarityBindingSource;
        private DBDataSetTableAdapters.RarityTableAdapter rarityTableAdapter;
        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumberNUD;
    }
}
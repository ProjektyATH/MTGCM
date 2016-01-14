namespace MTGCM.Forms
{
    partial class CardBase_List
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new MTGCM.DBDataSet();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.setBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ImmageTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.checkBoxLanguage = new System.Windows.Forms.CheckBox();
            this.checkBoxSet = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistTableAdapter = new MTGCM.DBDataSetTableAdapters.ArtistTableAdapter();
            this.languageTableAdapter = new MTGCM.DBDataSetTableAdapters.LanguageTableAdapter();
            this.rarityTableAdapter = new MTGCM.DBDataSetTableAdapters.RarityTableAdapter();
            this.setTableAdapter = new MTGCM.DBDataSetTableAdapters.SetTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
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
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox9);
            this.panel2.Controls.Add(this.comboBox8);
            this.panel2.Controls.Add(this.comboBox7);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TextTB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.ImmageTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Location = new System.Drawing.Point(857, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 604);
            this.panel2.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.AcceptsReturn = true;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Location = new System.Drawing.Point(71, 417);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Wersja";
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Location = new System.Drawing.Point(71, 391);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Numer";
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Location = new System.Drawing.Point(71, 364);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Opis";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(71, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 33;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Obraz";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Zestaw";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Rzadkość";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Artysta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Język";
            // 
            // comboBox9
            // 
            this.comboBox9.DataSource = this.languageBindingSource;
            this.comboBox9.DisplayMember = "name";
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(71, 230);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 36;
            this.comboBox9.ValueMember = "id";
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.setBindingSource;
            this.comboBox8.DisplayMember = "name";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(71, 337);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 35;
            this.comboBox8.ValueMember = "id";
            // 
            // setBindingSource
            // 
            this.setBindingSource.DataMember = "Set";
            this.setBindingSource.DataSource = this.dBDataSet;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.rarityBindingSource;
            this.comboBox7.DisplayMember = "name";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(71, 310);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 34;
            this.comboBox7.ValueMember = "id";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataMember = "Rarity";
            this.rarityBindingSource.DataSource = this.dBDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.artistBindingSource;
            this.comboBox6.DisplayMember = "name";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(71, 283);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 33;
            this.comboBox6.ValueMember = "id";
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataMember = "Artist";
            this.artistBindingSource.DataSource = this.dBDataSet;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(121, 204);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(74, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sumaryczny Koszt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Koszt Many";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Wytrzymałość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Moc";
            // 
            // TextTB
            // 
            this.TextTB.AcceptsReturn = true;
            this.TextTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextTB.Location = new System.Drawing.Point(74, 91);
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(118, 20);
            this.TextTB.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tekst";
            // 
            // ImmageTB
            // 
            this.ImmageTB.Location = new System.Drawing.Point(74, 65);
            this.ImmageTB.Name = "ImmageTB";
            this.ImmageTB.Size = new System.Drawing.Size(118, 20);
            this.ImmageTB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nazwa";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(23, 571);
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
            this.buttonEdit.Location = new System.Drawing.Point(23, 535);
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
            this.buttonAdd.Location = new System.Drawing.Point(23, 499);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBoxLanguage);
            this.panel1.Controls.Add(this.comboBoxSet);
            this.panel1.Controls.Add(this.checkBoxLanguage);
            this.panel1.Controls.Add(this.checkBoxSet);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.checkBoxName);
            this.panel1.Controls.Add(this.buttonFiltrate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 604);
            this.panel1.TabIndex = 4;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(5, 462);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(61, 17);
            this.checkBox6.TabIndex = 37;
            this.checkBox6.Text = "Zestaw";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(5, 512);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(59, 17);
            this.checkBox7.TabIndex = 37;
            this.checkBox7.Text = "Wersja";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DisplayMember = "name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(14, 535);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(144, 21);
            this.comboBox5.TabIndex = 36;
            this.comboBox5.ValueMember = "name";
            // 
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(14, 485);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(144, 21);
            this.comboBox4.TabIndex = 36;
            this.comboBox4.ValueMember = "name";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 409);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(58, 17);
            this.checkBox5.TabIndex = 35;
            this.checkBox5.Text = "Artysta";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(14, 435);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 21);
            this.comboBox3.TabIndex = 34;
            this.comboBox3.ValueMember = "name";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 351);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 17);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "Rzadkość";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(0, 302);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "Koszt many";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(19, 276);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown4.TabIndex = 31;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(19, 227);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown3.TabIndex = 30;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 253);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Wytrzymałość";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Moc";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 377);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "name";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "name";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DisplayMember = "name";
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(14, 177);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(144, 21);
            this.comboBoxLanguage.TabIndex = 6;
            this.comboBoxLanguage.ValueMember = "name";
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.DisplayMember = "name";
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Location = new System.Drawing.Point(14, 127);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(144, 21);
            this.comboBoxSet.TabIndex = 5;
            this.comboBoxSet.ValueMember = "name";
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
            this.checkBoxName.Size = new System.Drawing.Size(85, 17);
            this.checkBoxName.TabIndex = 1;
            this.checkBoxName.Text = "Nazwa karty";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 604);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // artistTableAdapter
            // 
            this.artistTableAdapter.ClearBeforeFill = true;
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // rarityTableAdapter
            // 
            this.rarityTableAdapter.ClearBeforeFill = true;
            // 
            // setTableAdapter
            // 
            this.setTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(74, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 20);
            this.textBox6.TabIndex = 47;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(101, 139);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(91, 20);
            this.textBox7.TabIndex = 48;
            // 
            // CardBase_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CardBase_List";
            this.Text = "CardBase_List";
            this.Load += new System.EventHandler(this.CardBase_List_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ImmageTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.ComboBox comboBoxSet;
        private System.Windows.Forms.CheckBox checkBoxLanguage;
        private System.Windows.Forms.CheckBox checkBoxSet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private DBDataSetTableAdapters.ArtistTableAdapter artistTableAdapter;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private DBDataSetTableAdapters.LanguageTableAdapter languageTableAdapter;
        private System.Windows.Forms.BindingSource rarityBindingSource;
        private DBDataSetTableAdapters.RarityTableAdapter rarityTableAdapter;
        private System.Windows.Forms.BindingSource setBindingSource;
        private DBDataSetTableAdapters.SetTableAdapter setTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}
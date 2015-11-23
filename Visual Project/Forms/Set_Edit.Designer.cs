namespace MTGCM.Forms
{
    partial class Set_Edit
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
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAbbrev = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAbbrev = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.radioCore = new System.Windows.Forms.RadioButton();
            this.radioSpecial = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelBlock = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCore = new System.Windows.Forms.Label();
            this.labelSpecial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(88, 46);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 13);
            this.labelId.TabIndex = 28;
            this.labelId.Text = "oldID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nowe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stare:";
            // 
            // labelAbbrev
            // 
            this.labelAbbrev.AutoSize = true;
            this.labelAbbrev.Location = new System.Drawing.Point(88, 106);
            this.labelAbbrev.Name = "labelAbbrev";
            this.labelAbbrev.Size = new System.Drawing.Size(40, 13);
            this.labelAbbrev.TabIndex = 24;
            this.labelAbbrev.Text = "oldAbb";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "oldNam";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(244, 77);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(144, 20);
            this.txt.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "skrót:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(24, 361);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(302, 361);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 17;
            this.btEdit.Text = "Zatwierdź";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "symbol:";
            // 
            // txtAbbrev
            // 
            this.txtAbbrev.Location = new System.Drawing.Point(244, 103);
            this.txtAbbrev.Name = "txtAbbrev";
            this.txtAbbrev.Size = new System.Drawing.Size(144, 20);
            this.txtAbbrev.TabIndex = 30;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(244, 129);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(144, 20);
            this.txtSymbol.TabIndex = 31;
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(244, 205);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(144, 20);
            this.txtBlock.TabIndex = 32;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(244, 166);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(144, 20);
            this.datePicker.TabIndex = 33;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(244, 231);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(144, 20);
            this.txtTotal.TabIndex = 34;
            // 
            // radioCore
            // 
            this.radioCore.AutoSize = true;
            this.radioCore.Location = new System.Drawing.Point(244, 271);
            this.radioCore.Name = "radioCore";
            this.radioCore.Size = new System.Drawing.Size(14, 13);
            this.radioCore.TabIndex = 35;
            this.radioCore.TabStop = true;
            this.radioCore.UseVisualStyleBackColor = true;
            // 
            // radioSpecial
            // 
            this.radioSpecial.AutoSize = true;
            this.radioSpecial.Location = new System.Drawing.Point(244, 294);
            this.radioSpecial.Name = "radioSpecial";
            this.radioSpecial.Size = new System.Drawing.Size(14, 13);
            this.radioSpecial.TabIndex = 36;
            this.radioSpecial.TabStop = true;
            this.radioSpecial.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "data wydania:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "nr bloku:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "ilość kart:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "główny:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "specjalny:";
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(91, 132);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(41, 13);
            this.labelSymbol.TabIndex = 42;
            this.labelSymbol.Text = "oldSym";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(91, 172);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 13);
            this.labelDate.TabIndex = 43;
            this.labelDate.Text = "label12";
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Location = new System.Drawing.Point(88, 208);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(41, 13);
            this.labelBlock.TabIndex = 44;
            this.labelBlock.Text = "label13";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(88, 234);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 13);
            this.labelTotal.TabIndex = 45;
            this.labelTotal.Text = "label14";
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Location = new System.Drawing.Point(88, 273);
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(41, 13);
            this.labelCore.TabIndex = 46;
            this.labelCore.Text = "label15";
            // 
            // labelSpecial
            // 
            this.labelSpecial.AutoSize = true;
            this.labelSpecial.Location = new System.Drawing.Point(88, 296);
            this.labelSpecial.Name = "labelSpecial";
            this.labelSpecial.Size = new System.Drawing.Size(41, 13);
            this.labelSpecial.TabIndex = 47;
            this.labelSpecial.Text = "label16";
            // 
            // Set_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 405);
            this.Controls.Add(this.labelSpecial);
            this.Controls.Add(this.labelCore);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelBlock);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSymbol);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioSpecial);
            this.Controls.Add(this.radioCore);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.txtAbbrev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAbbrev);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdit);
            this.Name = "Set_Edit";
            this.Text = "Set_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAbbrev;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbbrev;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton radioCore;
        private System.Windows.Forms.RadioButton radioSpecial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCore;
        private System.Windows.Forms.Label labelSpecial;
    }
}
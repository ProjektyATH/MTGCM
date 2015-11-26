namespace MTGCM.Forms
{
    partial class CardBase_Edit
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
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.txtCmc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToughness = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFlavor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelFlavor = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelToughness = new System.Windows.Forms.Label();
            this.labelMana = new System.Windows.Forms.Label();
            this.labelCmc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(114, 46);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 13);
            this.labelId.TabIndex = 58;
            this.labelId.Text = "oldID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Nowe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Stare:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(114, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 53;
            this.labelName.Text = "oldNam";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "nazwa:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(48, 418);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(312, 418);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 48;
            this.btEdit.Text = "Zatwierdź";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // txtCmc
            // 
            this.txtCmc.Location = new System.Drawing.Point(266, 359);
            this.txtCmc.Name = "txtCmc";
            this.txtCmc.Size = new System.Drawing.Size(42, 20);
            this.txtCmc.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "sumaryczny koszt:";
            // 
            // txtMana
            // 
            this.txtMana.Location = new System.Drawing.Point(266, 324);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(144, 20);
            this.txtMana.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "koszt many:";
            // 
            // txtToughness
            // 
            this.txtToughness.Location = new System.Drawing.Point(266, 288);
            this.txtToughness.Name = "txtToughness";
            this.txtToughness.Size = new System.Drawing.Size(42, 20);
            this.txtToughness.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "wytrzymałość:";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(266, 262);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(42, 20);
            this.txtPower.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "moc:";
            // 
            // txtFlavor
            // 
            this.txtFlavor.Location = new System.Drawing.Point(266, 187);
            this.txtFlavor.Multiline = true;
            this.txtFlavor.Name = "txtFlavor";
            this.txtFlavor.Size = new System.Drawing.Size(144, 58);
            this.txtFlavor.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "flavor tekst:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(266, 109);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(144, 57);
            this.txtText.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "tekst:";
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(114, 112);
            this.labelText.MaximumSize = new System.Drawing.Size(144, 57);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(144, 57);
            this.labelText.TabIndex = 80;
            this.labelText.Text = "label11";
            // 
            // labelFlavor
            // 
            this.labelFlavor.Location = new System.Drawing.Point(114, 190);
            this.labelFlavor.MaximumSize = new System.Drawing.Size(144, 57);
            this.labelFlavor.Name = "labelFlavor";
            this.labelFlavor.Size = new System.Drawing.Size(144, 57);
            this.labelFlavor.TabIndex = 81;
            this.labelFlavor.Text = "label11";
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(114, 265);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(43, 13);
            this.labelPower.TabIndex = 82;
            this.labelPower.Text = "oldNam";
            // 
            // labelToughness
            // 
            this.labelToughness.AutoSize = true;
            this.labelToughness.Location = new System.Drawing.Point(114, 291);
            this.labelToughness.Name = "labelToughness";
            this.labelToughness.Size = new System.Drawing.Size(43, 13);
            this.labelToughness.TabIndex = 83;
            this.labelToughness.Text = "oldNam";
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Location = new System.Drawing.Point(114, 331);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(43, 13);
            this.labelMana.TabIndex = 84;
            this.labelMana.Text = "oldNam";
            // 
            // labelCmc
            // 
            this.labelCmc.AutoSize = true;
            this.labelCmc.Location = new System.Drawing.Point(114, 366);
            this.labelCmc.Name = "labelCmc";
            this.labelCmc.Size = new System.Drawing.Size(43, 13);
            this.labelCmc.TabIndex = 85;
            this.labelCmc.Text = "oldNam";
            // 
            // CardBase_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 463);
            this.Controls.Add(this.labelCmc);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.labelToughness);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.labelFlavor);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.txtCmc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToughness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFlavor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdit);
            this.Name = "CardBase_Edit";
            this.Text = "CardBase_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox txtCmc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToughness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFlavor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelFlavor;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelToughness;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.Label labelCmc;
    }
}
namespace MTGCM.Forms
{
    partial class CardBase_Add
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToughness = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCmc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(12, 280);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 51;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(223, 280);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 50;
            this.btAdd.Text = "Zatwierdź";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "nazwa:";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(117, 70);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(144, 57);
            this.txtText.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "tekst:";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(117, 142);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(42, 20);
            this.txtPower.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "moc:";
            // 
            // txtToughness
            // 
            this.txtToughness.Location = new System.Drawing.Point(117, 168);
            this.txtToughness.Name = "txtToughness";
            this.txtToughness.Size = new System.Drawing.Size(42, 20);
            this.txtToughness.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "wytrzymałość:";
            // 
            // txtMana
            // 
            this.txtMana.Location = new System.Drawing.Point(117, 204);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(144, 20);
            this.txtMana.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "koszt many:";
            // 
            // txtCmc
            // 
            this.txtCmc.Location = new System.Drawing.Point(117, 239);
            this.txtCmc.Name = "txtCmc";
            this.txtCmc.Size = new System.Drawing.Size(42, 20);
            this.txtCmc.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "sumaryczny koszt:";
            // 
            // CardBase_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 317);
            this.Controls.Add(this.txtCmc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtToughness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Name = "CardBase_Add";
            this.Text = "CardBase_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToughness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCmc;
        private System.Windows.Forms.Label label7;
    }
}
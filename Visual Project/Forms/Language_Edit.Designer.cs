namespace MTGCM.Forms
{
    partial class Language_Edit
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new MTGCM.DBDataSet();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.userTableAdapter = new MTGCM.DBDataSetTableAdapters.UserTableAdapter();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAbbrev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAbbrev1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.dBDataSet;
            // 
            // txtAbbrev
            // 
            this.txtAbbrev.Location = new System.Drawing.Point(264, 109);
            this.txtAbbrev.Name = "txtAbbrev";
            this.txtAbbrev.Size = new System.Drawing.Size(144, 20);
            this.txtAbbrev.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nowe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Stare:";
            // 
            // labelAbbrev1
            // 
            this.labelAbbrev1.AutoSize = true;
            this.labelAbbrev1.Location = new System.Drawing.Point(108, 112);
            this.labelAbbrev1.Name = "labelAbbrev1";
            this.labelAbbrev1.Size = new System.Drawing.Size(40, 13);
            this.labelAbbrev1.TabIndex = 55;
            this.labelAbbrev1.Text = "oldAbb";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(108, 86);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(43, 13);
            this.labelName1.TabIndex = 54;
            this.labelName1.Text = "oldNam";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(264, 83);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(144, 20);
            this.txtLanguage.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "skrót:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(55, 153);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(333, 153);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 48;
            this.btEdit.Text = "Zatwierdź";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
            // 
            // Language_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 405);
            this.Controls.Add(this.txtAbbrev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAbbrev1);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdit);
            this.Name = "Language_Edit";
            this.Text = "Language_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.TextBox txtAbbrev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAbbrev1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
    }
}
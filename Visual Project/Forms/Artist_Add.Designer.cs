﻿namespace MTGCM.Forms
{
    partial class Artist_Add
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
            this.txtImie_Naz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
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
            // txtImie_Naz
            // 
            this.txtImie_Naz.Location = new System.Drawing.Point(113, 39);
            this.txtImie_Naz.Name = "txtImie_Naz";
            this.txtImie_Naz.Size = new System.Drawing.Size(120, 20);
            this.txtImie_Naz.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imie Nazwisko";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(32, 141);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(195, 141);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Dodaj";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Artist_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 203);
            this.Controls.Add(this.txtImie_Naz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Name = "Artist_Add";
            this.Text = "Artist_Add";
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
        private System.Windows.Forms.TextBox txtImie_Naz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdd;


    }
}
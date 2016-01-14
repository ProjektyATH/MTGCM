﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MTGCM.Forms
{
    public partial class Set_List : Form
    {
        int id;
        Set s = new Set();
        public Set_List()
        {
            InitializeComponent();
            Filtrate();
        }
        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Sets = from s in db.Set

                            select new
                            {
                                Lp = s.id,
                                Nazwa = s.name,  
                                Skrot = s.abbrev,
                                Symbol = s.symbol,
                                Data_wydania = s.relase_date,
                                Blok=s.Block.name,
                                Suma_Kart = s.cards_total,
                                Typ_Zestawu = s.SetType.name
                               

                            };

               if (checkBoxName.Checked)
               {
                   Sets = Sets.Where(s => s.Nazwa.Contains(textBoxName.Text));
               }
                
                if (checkBox1.Checked)
               {
                   Sets = Sets.Where(s => s.Symbol.Contains(textBox1.Text));
               }

                if (checkBox2.Checked)
                {
                    Sets = Sets.Where(s => s.Suma_Kart == numericUpDownCMC.Value);
                }
               

                //if (checkBoxBlok.Checked)
                //{
               //   Sets = Sets.Where(s => s.Jezyk == comboBoxLanguage.SelectedValue);
                //}

                dataGridView1.DataSource = Sets.ToList();
            }


        }

        private void buttonFiltrate_Click(object sender, EventArgs e)
        {
            Filtrate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new DBEntities())
            {
                s = new Set();
               
                s.name = ImmageTB.Text;
                s.abbrev = textBox2.Text;
                s.symbol = textBox2.Text;
                s.relase_date = dateTimePicker2.Value.Date;
                s.fk_block_id = Convert.ToInt32(comboBox2.SelectedValue);
                s.cards_total = Convert.ToInt32(numericUpDown1.Value);
                s.fk_type_id = Convert.ToInt32(comboBox3.SelectedValue);
                db.Set.Add(s);
                db.SaveChanges();
                Filtrate();
            }
        }

        private void Set_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.CardType' table. You can move, or remove it, as needed.
            this.cardTypeTableAdapter.Fill(this.dBDataSet.CardType);
            // TODO: This line of code loads data into the 'dBDataSet.Block' table. You can move, or remove it, as needed.
            this.blockTableAdapter.Fill(this.dBDataSet.Block);
            // TODO: This line of code loads data into the 'dBDataSet.CardType' table. You can move, or remove it, as needed.
            this.cardTypeTableAdapter.Fill(this.dBDataSet.CardType);
            // TODO: This line of code loads data into the 'dBDataSet.Block' table. You can move, or remove it, as needed.
            this.blockTableAdapter.Fill(this.dBDataSet.Block);

        }

    }
}

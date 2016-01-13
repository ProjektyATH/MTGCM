using System;
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
    public partial class CardBase_List : Form
    {

        int id;
        CardBase cb = new CardBase();
        public CardBase_List()
        {
            InitializeComponent();
            Filtrate();
        }

        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var CardBases = from cb in db.CardBase


                            select new
                            {
                                Lp = cb.id,
                                Nazwa = cb.name,
                                Tekst = cb.text,
                                Moc = cb.power,
                                Wytrzymalosc = cb.toughness,
                                Koszt_Many = cb.mana_cost,
                                Sumaryczny_koszt = cb.cmc

                            };


                if (checkBoxName.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Nazwa.Contains(textBoxName.Text));
                }

                //if (checkBoxSet.Checked)
                //{
                //    Cards = Cards.Where(c => c.Dodatek == comboBoxSet.SelectedValue);
                //}

                //if (checkBoxLanguage.Checked)
                //{
                //    Cards = Cards.Where(c => c.Jezyk == comboBoxLanguage.SelectedValue);
                //}



                dataGridView1.DataSource = CardBases.ToList();
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
                cb = new CardBase();

                cb.name = ImmageTB.Text;
                cb.text = TextTB.Text;
                cb.power = Convert.ToInt32(numericUpDownCMC);
                cb.toughness = Convert.ToInt32(numericUpDown1);
                cb.mana_cost = textBox1.Text;
                cb.cmc = Convert.ToInt32(numericUpDown2);

                db.CardBase.Add(cb);
                db.SaveChanges();
                Filtrate();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz edytować kartę o numerze id " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var db = new DBEntities())
                    {
                        cb.name = ImmageTB.Text;
                        cb.text = TextTB.Text;
                        cb.power = Convert.ToInt32(numericUpDownCMC);
                        cb.toughness = Convert.ToInt32(numericUpDown1);
                        cb.mana_cost = textBox1.Text;
                        cb.cmc = Convert.ToInt32(numericUpDown2);
                        db.Entry(cb).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                Filtrate();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć kartę o numerze id " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var db = new DBEntities())
                    {
                        db.Entry(cb).State = EntityState.Deleted;

                        db.SaveChanges();
                    }
                }
                Filtrate();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new DBEntities())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    cb = (from CB in db.CardBase
                          where CB.id == id
                          select CB).First();

                    ImmageTB.Text = cb.name;
                    TextTB.Text = cb.text;
                    numericUpDownCMC.Value = Convert.ToInt64(cb.power);
                    numericUpDown1.Value = Convert.ToInt32(cb.toughness);
                    textBox1.Text = cb.mana_cost;
                    numericUpDown2.Value = Convert.ToInt32(cb.cmc);

                    db.Entry(cb).State = EntityState.Modified;
                    db.SaveChanges();
                }


            }
        }
    }
}

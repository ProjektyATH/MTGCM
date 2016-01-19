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
    public partial class OwnedCard_List : Form
    {
         int id;
         OwnedCard o = new OwnedCard();
        public OwnedCard_List()
        {
            InitializeComponent();
            Filtrate();
        }

        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var OwnedCards = from o in db.OwnedCard

                           select new
                           {
                               Lp = o.id,
                               Karta = o.CardBase.name,
                               Talia = o.Deck.name,
                               Foliowana = o.foil,
                               Podpisana = o.signed,
                               Stan = o.condition,
                               Altered = o.altered,
                               Tag = o.tags,
                               Komentarza = o.comment
                             
                               
                           };

                if (checkBox4.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Karta == comboBox1.SelectedValue);
                }

                if (checkBox2.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Talia == comboBox2.SelectedValue);
                }

                if (checkBox1.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Stan == numericUpDownCMC.Value);
                }

                if (checkBox3.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Foliowana == radioButtonFoil.Checked);
                }
                if (checkBox5.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Podpisana == radioButtonSigned.Checked);
                }
                if (checkBox6.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Altered == radioButtonAltered.Checked);
                }
                if (checkBoxName.Checked)
                {
                    OwnedCards = OwnedCards.Where(o => o.Tag.Contains(textBoxName.Text));
                }


                dataGridView1.DataSource = OwnedCards.ToList();
            }


        }

        private void buttonFiltrate_Click(object sender, EventArgs e)
        {
            Filtrate();
        }

        private void OwnedCard_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Deck' table. You can move, or remove it, as needed.
            this.deckTableAdapter.Fill(this.dBDataSet.Deck);
            // TODO: This line of code loads data into the 'dBDataSet.CardBase' table. You can move, or remove it, as needed.
            this.cardBaseTableAdapter.Fill(this.dBDataSet.CardBase);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new DBEntities())
            {
                o = new OwnedCard();

                                o.fk_user_id = 0;
                                o.fk_card_id = Convert.ToInt32(comboBox3.SelectedValue);
                                o.fk_deck_id = Convert.ToInt32(comboBox4.SelectedValue);
                                o.foil = checkBox9.Checked;
                                o.signed = checkBox8.Checked;
                                o.altered = checkBox7.Checked;
                                o.condition = Convert.ToInt32(numericUpDown1.Value);
                                o.tags = textBox1.Text;
                                o.comment = textBox2.Text;

                                db.OwnedCard.Add(o);
                                db.SaveChanges();
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

                    o = (from O in db.OwnedCard
                         where O.id == id
                         select O).First();

                 
                    comboBox3.SelectedValue = o.fk_card_id;
                    comboBox4.SelectedValue = o.fk_deck_id;
                    checkBox9.Checked = o.foil.Value;
                    checkBox8.Checked = o.signed.Value;
                    checkBox7.Checked = o.altered.Value;
                    numericUpDown1.Value =Convert.ToInt32(o.condition);
                    textBox1.Text = o.tags;
                    textBox2.Text = o.comment;

                    db.Entry(o).State = EntityState.Modified;
                    db.SaveChanges();
                }

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

                      
                        o.fk_user_id = 0;
                        o.fk_card_id = Convert.ToInt32(comboBox3.SelectedValue);
                        o.fk_deck_id = Convert.ToInt32(comboBox4.SelectedValue);
                        o.foil = checkBox9.Checked;
                        o.signed = checkBox8.Checked;
                        o.altered = checkBox7.Checked;
                        o.condition = Convert.ToInt32(numericUpDown1.Value);
                        o.tags = textBox1.Text;
                        o.comment = textBox2.Text;


                        db.Entry(o).State = EntityState.Modified;
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
                        db.Entry(o).State = EntityState.Deleted;

                        db.SaveChanges();
                    }
                }
                Filtrate();
            }
        }
    }


}

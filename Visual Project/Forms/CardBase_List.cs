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
                                    Moc = cb.power.ToLower(),
                                    Wytrzymalosc = cb.toughness.ToLower(),
                                    Koszt_Many = cb.mana_cost,
                                    Sumaryczny_koszt = cb.cmc,
                                    Artysta = cb.Artist.name,
                                    Zestaw = cb.Set.name,
                                    Rzadkosc = cb.Rarity.name,
                                    Jezyk = cb.Language.name,
                                    wersja = cb.version.ToString() + " " + cb.number



                                };


                if (checkBoxName.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Nazwa.Contains(textBoxName.Text));
                }



                if (checkBoxLanguage.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Jezyk == comboBoxLanguage.SelectedValue);
                }

                if (checkBox1.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Moc.Contains(textBox8.Text));
                }

                if (checkBox2.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Wytrzymalosc.Contains(textBox9.Text));
                }

                if (checkBox3.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Koszt_Many.Contains(comboBox1.Text));
                }

                if (checkBox4.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Rzadkosc.Contains(comboBox2.Text));
                }

                if (checkBox5.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Artysta.Contains(comboBox3.Text));
                }

                if (checkBox6.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.Zestaw.Contains(comboBox4.Text));
                }

                if (checkBox7.Checked)
                {
                    CardBases = CardBases.Where(cb => cb.wersja.Contains(comboBox5.Text));
                }

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
                cb.oracle_text = TextTB.Text;
                cb.power = textBox6.Text;
                cb.toughness = textBox7.Text;
                cb.mana_cost = textBox1.Text;
                cb.cmc = numericUpDown2.Value;
                cb.fk_language_id = Convert.ToInt32(comboBox9.SelectedValue);
                cb.image = textBox2.Text;
                cb.fk_artist_id = Convert.ToInt32(comboBox6.SelectedValue);
                cb.fk_rarity_id = Convert.ToInt32(comboBox7.SelectedValue);
                cb.fk_set_id = Convert.ToInt32(comboBox8.SelectedValue);
                cb.flavor_text = textBox3.Text;
                cb.number = textBox4.Text;
                cb.version = Convert.ToInt32(textBox5.Text);

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
                        cb.oracle_text = TextTB.Text;
                        cb.power = textBox6.Text;
                        cb.toughness = textBox7.Text;
                        cb.mana_cost = textBox1.Text;
                        cb.cmc = numericUpDown2.Value;
                        cb.fk_language_id = Convert.ToInt32(comboBox9.SelectedValue);
                        cb.image = textBox2.Text;
                        cb.fk_artist_id = Convert.ToInt32(comboBox6.SelectedValue);
                        cb.fk_rarity_id = Convert.ToInt32(comboBox7.SelectedValue);
                        cb.fk_set_id = Convert.ToInt32(comboBox8.SelectedValue);
                        cb.flavor_text = textBox3.Text;
                        cb.number = textBox4.Text;
                        cb.version = Convert.ToInt32(textBox5.Text);






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



        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CardBase_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.dBDataSet.Set);
            // TODO: This line of code loads data into the 'dBDataSet.Rarity' table. You can move, or remove it, as needed.
            this.rarityTableAdapter.Fill(this.dBDataSet.Rarity);
            // TODO: This line of code loads data into the 'dBDataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.dBDataSet.Language);
            // TODO: This line of code loads data into the 'dBDataSet.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.dBDataSet.Artist);
            // TODO: This line of code loads data into the 'dBDataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.dBDataSet.Language);

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new DBEntities())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    
                    var tmpcb = from CB in db.CardBase
                             where CB.id == Convert.ToInt64( id)
                             select CB;

                    cb = tmpcb.First();

                    ImmageTB.Text = cb.name;
                    TextTB.Text = cb.oracle_text;
                    textBox6.Text = cb.power;
                    textBox7.Text = cb.toughness;
                    textBox1.Text = cb.mana_cost;
                    numericUpDown2.Value = cb.cmc.Value;
                    comboBox9.Text = Convert.ToString(cb.fk_language_id);
                    textBox2.Text = cb.image;
                    comboBox6.Text = Convert.ToString(cb.fk_artist_id);
                    comboBox7.Text = Convert.ToString(cb.fk_rarity_id);
                    comboBox8.Text = Convert.ToString(cb.fk_set_id);
                    textBox3.Text = Convert.ToString(cb.flavor_text);
                    textBox4.Text = cb.number;
                    textBox5.Text = Convert.ToString(cb.version);


                    db.Entry(cb).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
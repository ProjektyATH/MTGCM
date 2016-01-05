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
    public partial class Card_List : Form
    {
        int id;
        Card c = new Card();
        public Card_List()
        {
            InitializeComponent();
            Filtrate();

        }

        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Cards = from c in db.Card

                            select new
                            {
                                Lp = c.id,
                                Nazwa = c.CardBase.name,
                                Dodatek = c.Set.name,
                                Koszt_many = c.CardBase.mana_cost,
                                Jezyk = c.Language.name,
                                Data_wydania = c.Set.relase_date,
                                Sumaryczny_koszt = c.CardBase.cmc

                            };

                if (checkBoxName.Checked)
                {
                    Cards = Cards.Where(c => c.Nazwa.Contains(textBoxName.Text));
                }

                if (checkBoxSet.Checked)
                {
                    Cards = Cards.Where(c => c.Dodatek == comboBoxSet.SelectedValue);
                }

                if (checkBoxLanguage.Checked)
                {
                    Cards = Cards.Where(c => c.Jezyk == comboBoxLanguage.SelectedValue);
                }

                if (checkBoxFrom.Checked)
                {
                    Cards = Cards.Where(c => c.Data_wydania >= dateTimePickerFrom.Value);
                }

                if (checkBoxTo.Checked)
                {
                    Cards = Cards.Where(c => c.Data_wydania <= dateTimePickerTo.Value);
                }

                if (checkBoxCMC.Checked)
                {
                    Cards = Cards.Where(c => c.Sumaryczny_koszt == numericUpDownCMC.Value);
                }

                dataGridView1.DataSource = Cards.ToList();
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
                c = new Card();
                c.fk_base_id = Convert.ToInt32(BaseCB.SelectedValue);
                c.fk_language_id = Convert.ToInt32(LanguageCB.SelectedValue);
                c.artwork = ImmageTB.Text;
                c.fk_artist_id = Convert.ToInt32(ArtistCB.SelectedValue);
                c.fk_rarity_id = Convert.ToInt32(RarityCB.SelectedValue);
                c.fk_set_id = Convert.ToInt32(SetCB.SelectedValue);
                c.flavor_text = TextTB.Text;
                c.number = Convert.ToInt64(NumberNUD.Value);
                c.version = VersionTB.Text;

                db.Card.Add(c);
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
                        c.fk_base_id = Convert.ToInt32(BaseCB.SelectedValue);
                        c.fk_language_id = Convert.ToInt32(LanguageCB.SelectedValue);
                        c.artwork = ImmageTB.Text;
                        c.fk_artist_id = Convert.ToInt32(ArtistCB.SelectedValue);
                        c.fk_rarity_id = Convert.ToInt32(RarityCB.SelectedValue);
                        c.fk_set_id = Convert.ToInt32(SetCB.SelectedValue);
                        c.flavor_text = TextTB.Text;
                        c.number = Convert.ToInt64(NumberNUD.Value);
                        c.version = VersionTB.Text;
                        db.Entry(c).State = EntityState.Modified;
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
                          db.Entry(c).State = EntityState.Deleted;
                         
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

                    c = (from C in db.Card
                         where C.id == id
                         select C).First();

                    BaseCB.SelectedValue = c.fk_base_id;
                    LanguageCB.SelectedValue = c.fk_language_id;
                    ImmageTB.Text = c.artwork;
                    ArtistCB.SelectedValue = c.fk_artist_id;
                    RarityCB.SelectedValue = c.fk_rarity_id;
                    SetCB.SelectedValue = c.fk_set_id;
                    TextTB.Text = c.flavor_text;
                    NumberNUD.Value = (int)c.number;
                    VersionTB.Text = c.version;
                }
            }
        }




        private void Card_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Rarity' table. You can move, or remove it, as needed.
            this.rarityTableAdapter.Fill(this.dBDataSet.Rarity);
            // TODO: This line of code loads data into the 'dBDataSet.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.dBDataSet.Artist);
            // TODO: This line of code loads data into the 'dBDataSet.CardBase' table. You can move, or remove it, as needed.
            this.cardBaseTableAdapter.Fill(this.dBDataSet.CardBase);
            // TODO: This line of code loads data into the 'dBDataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.dBDataSet.Language);
            // TODO: This line of code loads data into the 'dBDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.dBDataSet.Set);
            // TODO: This line of code loads data into the 'dBDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.dBDataSet.Set);
            // TODO: This line of code loads data into the 'dBDataSet.Card' table. You can move, or remove it, as needed.
            this.cardTableAdapter.Fill(this.dBDataSet.Card);

        }

    }
}

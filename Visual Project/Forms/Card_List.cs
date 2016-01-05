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
        int id,index;

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
                                    Koszt_many=c.CardBase.mana_cost,
                                    Jezyk = c.Language.name,
                                    Data_wydania = c.Set.relase_date,
                                    Sumaryczny_koszt=c.CardBase.cmc

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
            DBEntities db = new DBEntities();
            Card c = new Card
            {

                fk_base_id = Convert.ToInt32(BaseCB.SelectedValue),
                fk_language_id = Convert.ToInt32(LanguageCB.SelectedValue),
                artwork = ImmageTB.Text,
                fk_artist_id = Convert.ToInt32(ArtistCB.SelectedValue),
                fk_rarity_id = Convert.ToInt32(RarityCB.SelectedValue),
                fk_set_id = Convert.ToInt32(SetCB.SelectedValue),
                flavor_text = TextTB.Text,
                number = Convert.ToInt32(NumberNUD.Value),
                version = VersionTB.Text
            };

            db.Card.Add(c);
            db.SaveChanges();
            Filtrate();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
             
                Filtrate();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika numer " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                }
                Filtrate();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.RowCount != 0)
                id = Convert.ToInt32(dataGridView1.SelectedRows[e.RowIndex].Cells[0].Value);

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

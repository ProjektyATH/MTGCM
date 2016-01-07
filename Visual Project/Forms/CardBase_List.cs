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
                                //Moc = cb.power,
                                //Wytrzymalosc = cb.toughness,
                                Koszt_Many = cb.mana_cost,
                                Sumaryczny_koszt = cb.cmc

                            };

                //if (checkBoxName.Checked)
                //{
                //    CardBases = CardBases.Where(cb => cb.Nazwa.Contains(textBoxName.Text));
                //}

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
    }
}

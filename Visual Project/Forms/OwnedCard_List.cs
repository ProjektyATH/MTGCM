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
                               Altered  = o.altered,
                               Tag = o.tags,
                              


                           };

                //if (checkBoxName.Checked)
                //{
                //    Sets = Sets.Where(s => s.Nazwa.Contains(textBoxName.Text));
                //}

                //if (checkBox1.Checked)
                //{
                //    Sets = Sets.Where(s => s.Symbol.Contains(textBox1.Text));
                //}

                //if (checkBox5.Checked)
                //{
                //    Sets = Sets.Where(s => s.Skrot.Contains(textBox4.Text));
                //}

                //if (checkBox2.Checked)
                //{
                //    Sets = Sets.Where(s => s.Suma_Kart == numericUpDownCMC.Value);
                //}

                //if (checkBox3.Checked)
                //{
                //    Sets = Sets.Where(s => s.Data_wydania == dateTimePicker1.Value.Date);
                //}
                //if (checkBox4.Checked)
                //{
                //    Sets = Sets.Where(s => s.Typ_Zestawu == comboBox1.SelectedValue);
                //}

                //if (checkBox4.Checked)
                //{
                //    Sets = Sets.Where(s => s.Blok == comboBoxBlok.SelectedValue);
                //}


                dataGridView1.DataSource = OwnedCards.ToList();
            }


        }

        private void buttonFiltrate_Click(object sender, EventArgs e)
        {
            Filtrate();
        }
    }


}

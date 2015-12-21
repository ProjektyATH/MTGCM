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


        public Card_List()
        {
            InitializeComponent();
            Filtrate();
        }

        private void Filtrate()
        {

            using (var dc = new DBEntities())
            {

                var Cards = from c in dc.Card

                                select new
                                {
                                    Lp = c.id,
                                    Nazwa = c.CardBase.name,
                                    Dodatek = c.Set.name,
                                    Jezyk = c.Language.name,
                                    Data_wydania = c.Set.relase_date

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
               
                dataGridView1.DataSource = Cards.ToList();
            }
            //var DB = new DBEntities();
            //DB.Card.Load();
            //dataGridView1.DataSource = DB.Card.Local.ToBindingList();

        }
        private void Card_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.dBDataSet.Language);
            // TODO: This line of code loads data into the 'dBDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.dBDataSet.Set);
            // TODO: This line of code loads data into the 'dBDataSet.Set' table. You can move, or remove it, as needed.
            this.setTableAdapter.Fill(this.dBDataSet.Set);

            Filtrate();

            // TODO: This line of code loads data into the 'dBDataSet.Card' table. You can move, or remove it, as needed.
            this.cardTableAdapter.Fill(this.dBDataSet.Card);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtrate();
        }
    }
}

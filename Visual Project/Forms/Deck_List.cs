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
    public partial class Deck_List : Form
    {
        int id;
        Deck d = new Deck();
        public Deck_List()
        {
            InitializeComponent();
            Filtrate();
        }
        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Decks = from d in db.Deck

                            select new
                            {
                                Lp = d.id,
                                Nazwa = d.name,
                                Tag = d.tags

                            };

                if (checkBoxName.Checked)
                {
                    Decks = Decks.Where(d => d.Nazwa.Contains(textBoxName.Text));
                }


                dataGridView1.DataSource = Decks.ToList();
            }

        }

        private void buttonFiltrate_Click(object sender, EventArgs e)
        {
            Filtrate();
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
                        db.Entry(d).State = EntityState.Deleted;

                        db.SaveChanges();
                    }
                }
                Filtrate();
            }
        }

        private void buttonArtist_Click(object sender, EventArgs e)
        {
            using (var db = new DBEntities())
            {
                d = new Deck();

                d.name = NazwaArtysty.Text;
                d.tags = comboBox1.Text;
                d.fk_user_id = 0;

                db.Deck.Add(d);
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
                        d.name = NazwaArtysty.Text;
                        d.tags = comboBox1.Text;
                        d.fk_user_id = 1;

                        db.Entry(d).State = EntityState.Modified;
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

                    d = (from D in db.Deck
                         where D.id == id
                         select D).First();

                    NazwaArtysty.Text = d.name;
                    comboBox1.Text = d.tags;


                    db.Entry(d).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
    
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
    public partial class Rarity_List : Form
    {
        int id;
        Rarity r = new Rarity();
        public Rarity_List()
        {
           
            InitializeComponent();
            Filtrate();
        }

        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Raritys = from r in db.Rarity

                            select new
                            {
                                Lp = r.id,
                                Nazwa = r.name,
                                Kolor = r.color,
                               

                            };

                if (checkBoxName.Checked)
                {
                    Raritys = Raritys.Where(r => r.Nazwa.Contains(textBoxName.Text));
                }

               // if (checkBoxSet.Checked)
               // {
           //         Cards = Cards.Where(c => c.Dodatek == comboBoxSet.SelectedValue);
            //    }


                dataGridView1.DataSource = Raritys.ToList();
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
                r = new Rarity();
                r.name = ImmageTB.Text;             
                r.color = TextTB.Text;
               
                db.Rarity.Add(r);
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
                        r.name = ImmageTB.Text;
                        r.color = TextTB.Text;
               
                        db.Entry(r).State = EntityState.Modified;
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
                DialogResult result = MessageBox.Show("Czy na pewno chcesz edytować kartę o numerze id " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var db = new DBEntities())
                    {
                       
                        r.name = ImmageTB.Text;
                        r.color = TextTB.Text;
                        db.Entry(r).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                Filtrate();
            }
        }
       

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new DBEntities())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    r = (from R in db.Rarity
                         where R.id == id
                         select R).First();

                      r.color=TextTB.Text;
                      r.color=textBox1.Text;
                      db.Entry(r).State = EntityState.Modified;
                      db.SaveChanges();

                }
            }
        }
    }
}

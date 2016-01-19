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
    public partial class Block_List : Form
    {
        int id;
        Block b = new Block();
        public Block_List()
        {
            InitializeComponent();
            Filtrate();
        }
        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Blocks = from b in db.Block

                            select new
                            {
                                Lp = b.id,
                                Nazwa = b.name,
                               
                              

                            };

                if (checkBoxName.Checked)
                {
                    Blocks = Blocks.Where(b => b.Nazwa.Contains(textBoxName.Text));
                }


                dataGridView1.DataSource = Blocks.ToList();
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
                b = new Block();
                
                b.name = ImmageTB.Text;
                

                db.Block.Add(b);
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
                        b.name = ImmageTB.Text;
                        db.Entry(b).State = EntityState.Modified;
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
                        db.Entry(b).State = EntityState.Deleted;

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

                   b= (from B in db.Block
                         where B.id == id
                         select B).First();
                  ImmageTB.Text = b.name ;
                    db.Entry(b).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
        }

    }
}

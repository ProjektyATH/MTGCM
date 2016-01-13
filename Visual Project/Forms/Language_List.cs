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
    public partial class Language_List : Form
    {
        int id;
        Language l = new Language();
        public Language_List()
        {
            InitializeComponent();
            Filtrate();
        }

        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Languages = from l in db.Language

                                select new
                                {
                                    Lp = l.id,
                                    Nazwa = l.name,
                                    Skrot = l.abbrev,


                                };

                if (checkBoxName.Checked)
                {
                    Languages = Languages.Where(l => l.Nazwa.Contains(textBoxName.Text));
                }

                if (checkBoxSet.Checked)
                {

                    Languages = Languages.Where(l => l.Skrot.Contains(Skrot.Text));
                }



                dataGridView1.DataSource = Languages.ToList();
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
                l = new Language();

                l.name = ImmageTB.Text;
                l.abbrev = abbrev.Text;

                db.Language.Add(l);
                db.SaveChanges();
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
                        db.Entry(l).State = EntityState.Deleted;

                        db.SaveChanges();
                    }
                }
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
                        l.name = ImmageTB.Text;
                        l.abbrev = abbrev.Text;

                        db.Entry(l).State = EntityState.Modified;
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

                    l = (from L in db.Language
                         where L.id == id
                         select L).First();

                    ImmageTB.Text = l.name;
                    abbrev.Text = l.abbrev;
                    db.Entry(l).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
        }
    }
}
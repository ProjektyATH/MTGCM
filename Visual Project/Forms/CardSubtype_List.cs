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
    public partial class CardSubtype_List : Form
    {
        int id;
        CardSubtype cs = new CardSubtype();
        public CardSubtype_List()
        {
            InitializeComponent();
            Filtrate();
        }
        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var CardSubtypes = from cs in db.CardSubtype

                            select new
                            {
                                Lp = cs.id,
                                Nazwa = cs.name,

                            };

                if (checkBoxName.Checked)
                {
                    CardSubtypes = CardSubtypes.Where(cs => cs.Nazwa.Contains(textBoxName.Text));
                }


                dataGridView1.DataSource = CardSubtypes.ToList();
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
                cs = new CardSubtype();
              
                cs.name = ImmageTB.Text;
                

                db.CardSubtype.Add(cs);
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
                        cs.name = ImmageTB.Text;

                        db.Entry(cs).State = EntityState.Modified;
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
                        db.Entry(cs).State = EntityState.Deleted;

                        db.SaveChanges();
                    }
                }
                Filtrate();
            }
        }
    }
}

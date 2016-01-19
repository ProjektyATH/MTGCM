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
    public partial class SetType_List : Form
    {
        int id;
        SetType st = new SetType();
        public SetType_List()
        {
            InitializeComponent();
            Filtrate();
        }

        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var SetTypes = from st in db.SetType

                              select new
                              {
                                  Lp = st.id,
                                  Nazwa = st.name,

                              };

                if (checkBoxName.Checked)
                {
                    SetTypes = SetTypes.Where(st =>st.Nazwa.Contains(textBoxName.Text));
                }


                dataGridView1.DataSource = SetTypes.ToList();
            }


        }

        private void buttonFiltrate_Click(object sender, EventArgs e)
        {
            Filtrate();
        }

        private void buttonArtist_Click(object sender, EventArgs e)
        {
            using (var db = new DBEntities())
            {
                st = new SetType();

                st.name = ImmageTB.Text;

                db.SetType.Add(st);
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
                        st.name = ImmageTB.Text;

                        db.Entry(st).State = EntityState.Modified;
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
                        db.Entry(st).State = EntityState.Deleted;

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

                    st = (from ST in db.SetType
                         where ST.id == id
                         select ST).First();

                    ImmageTB.Text = st.name;
                    db.Entry(st).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}

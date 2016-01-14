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
    public partial class Set_List : Form
    {
        int id;
        Set s = new Set();
        public Set_List()
        {
            InitializeComponent();
            Filtrate();
        }
        private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Sets = from s in db.Set

                           select new
                           {
                               Lp = s.id,
                               Nazwa = s.name,
                               Skrot = s.abbrev,
                               Symbol = s.symbol,
                               Data_wydania = s.relase_date,
                               Blok = s.Block.name,
                               Suma_Kart = s.cards_total,
                               Typ_Zestawu = s.SetType.name


                           };

                if (checkBoxName.Checked)
                {
                    Sets = Sets.Where(s => s.Nazwa.Contains(textBoxName.Text));
                }

                if (checkBox1.Checked)
                {
                    Sets = Sets.Where(s => s.Symbol.Contains(textBox1.Text));
                }

                if (checkBox2.Checked)
                {
                    Sets = Sets.Where(s => s.Suma_Kart == numericUpDownCMC.Value);
                }


                //if (checkBoxBlok.Checked)
                //{
                //   Sets = Sets.Where(s => s.Jezyk == comboBoxLanguage.SelectedValue);
                //}

                dataGridView1.DataSource = Sets.ToList();
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
                s = new Set();

                s.name = ImmageTB.Text;
                s.abbrev = textBox2.Text;
                s.symbol = textBox2.Text;
                s.relase_date = dateTimePicker2.Value.Date;
                s.fk_block_id = Convert.ToInt32(comboBox2.SelectedValue);
                s.cards_total = Convert.ToInt32(numericUpDown1.Value);
                s.fk_type_id = Convert.ToInt32(comboBox3.SelectedValue);
                db.Set.Add(s);
                db.SaveChanges();
                Filtrate();
            }
        }

        private void Set_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.CardType' table. You can move, or remove it, as needed.
            this.cardTypeTableAdapter.Fill(this.dBDataSet.CardType);
            // TODO: This line of code loads data into the 'dBDataSet.Block' table. You can move, or remove it, as needed.
            this.blockTableAdapter.Fill(this.dBDataSet.Block);
            // TODO: This line of code loads data into the 'dBDataSet.CardType' table. You can move, or remove it, as needed.
            this.cardTypeTableAdapter.Fill(this.dBDataSet.CardType);
            // TODO: This line of code loads data into the 'dBDataSet.Block' table. You can move, or remove it, as needed.
            this.blockTableAdapter.Fill(this.dBDataSet.Block);

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

                        s.name = ImmageTB.Text;
                        s.abbrev = textBox2.Text;
                        s.symbol = textBox2.Text;
                        s.relase_date = dateTimePicker2.Value.Date;
                        s.fk_block_id = Convert.ToInt32(comboBox2.SelectedValue);
                        s.cards_total = Convert.ToInt32(numericUpDown1.Value);
                        s.fk_type_id = Convert.ToInt32(comboBox3.SelectedValue);


                        db.Entry(s).State = EntityState.Modified;
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

                    s = (from S in db.Set
                         where S.id == id
                         select S).First();

                    ImmageTB.Text = s.name;
                    textBox2.Text = s.abbrev ;
                    textBox3.Text = s.symbol;
                    dateTimePicker2.Value = s.relase_date.Value;
                    comboBox2.SelectedValue = s.fk_block_id;
                    numericUpDown1.Value = s.cards_total.Value;
                    comboBox3.SelectedValue = s.fk_type_id;

                    db.Entry(s).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
        }
    }
}

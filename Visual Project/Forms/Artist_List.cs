﻿using System;
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
    public partial class Artist_List : Form
    {
        int id;
        Artist a = new Artist();
        public Artist_List()
        {
            InitializeComponent();
            Filtrate();
        }

     private void Filtrate()
        {

            using (var db = new DBEntities())
            {

                var Artists = from a in db.Artist

                            select new
                            {
                                Lp = a.id,
                                Nazwa = a.name,
                               
                            };

                if (checkBoxName.Checked)
                {
                    Artists = Artists.Where(a => a.Nazwa.Contains(textBoxName.Text));
                }

              
                dataGridView1.DataSource = Artists.ToList();
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
             a = new Artist();

             a.name = textBox1.Text;
                
             db.Artist.Add(a);
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
                     db.Entry(a).State = EntityState.Deleted;

                     db.SaveChanges();
                 }
             }
             Filtrate();
         }
     }

     private void Artist_List_Load(object sender, EventArgs e)
     {
       
     

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
                     a.name = textBox1.Text;

                     db.Entry(a).State = EntityState.Modified;
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

                 a = (from A in db.Artist
                      where A.id == id
                      select A).First();

                 textBox1.Text = a.name;
                 db.Entry(a).State = EntityState.Modified;
                 db.SaveChanges();
             }
         }
     }
 

    }
}

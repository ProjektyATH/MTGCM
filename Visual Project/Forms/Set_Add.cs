using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace MTGCM.Forms
{
    public partial class Set_Add : Form
    {
        string connString = "Data Source = DB.db; Version = 3";

        public Set_Add()
        {
            InitializeComponent();
        }

       

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                INSERT INTO [Set] (name, abbrev, symbol, relase_date, fk_block_id, cards_total, is_core, is_special)
                                VALUES (@name, @abbrev, @symbol, @relase_date, @fk_block_id, @cards_total, @is_core, @is_special)
                                ";
                if (txtName.Text==null ||txtAbbrev.Text==null||txtBlock.Text==""||txtTotal.Text=="")
                {
                    MessageBox.Show("Pola nie mogą być puste!");
                }else
                {
                    try
                    {
                        command.Parameters.Add(new SQLiteParameter("@name", txtName.Text));
                        command.Parameters.Add(new SQLiteParameter("@abbrev", txtAbbrev.Text));
                        command.Parameters.Add(new SQLiteParameter("@symbol", txtSymbol.Text));
                        command.Parameters.Add(new SQLiteParameter("@relase_date", datePicker.Value));
                        command.Parameters.Add(new SQLiteParameter("@fk_block_id", Convert.ToInt32(txtBlock.Text)));
                        command.Parameters.Add(new SQLiteParameter("@cards_total", Convert.ToInt32(txtTotal.Text)));
                        command.Parameters.Add(new SQLiteParameter("@is_core", radioCore.Checked));
                        command.Parameters.Add(new SQLiteParameter("@is_special", radioSpecial.Checked));
                        command.ExecuteNonQuery();
                        conn.Close();

                        this.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Zły format!");

                    }
            

                }
                
               
            }
        }
    }
}

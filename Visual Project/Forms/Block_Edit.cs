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
    public partial class Block_Edit : Form
    {
        int id;
        string connString = "Data Source = DB.db; Version = 3";

        public Block_Edit(int id_)
        {
            InitializeComponent();
            id = id_;

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM Block WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            
                            labelName.Text = rdr.GetValue(1).ToString();
                            txtImieNazw.Text = rdr.GetValue(1).ToString();

                        }
                    }
                }
                conn.Close();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                UPDATE [Block] SET 
                                name = @name                              
                                WHERE id = @id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.Parameters.Add(new SQLiteParameter("@name", txtImieNazw.Text));
                command.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

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
     
    public partial class User_Edit : Form
    {
        int id;
        string connString = "Data Source = DB.db; Version = 3";



        public User_Edit(int id_)
        {
            InitializeComponent();
            id = id_;

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM User WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            labelId.Text = rdr.GetValue(0).ToString();
                            labelLogin.Text = rdr.GetValue(1).ToString();
                            txtLogin.Text = rdr.GetValue(1).ToString();
                            labelPassword.Text = rdr.GetValue(2).ToString();
                            txtPassword.Text = rdr.GetValue(2).ToString();
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
                                UPDATE User
                                SET
                                name = @nam,
                                password = @pass
                                WHERE id = @id
                                ";

                    command.Parameters.Add(new SQLiteParameter("@id", id));
                    command.Parameters.Add(new SQLiteParameter("@nam", txtLogin.Text));
                    command.Parameters.Add(new SQLiteParameter("@pass", txtPassword.Text));


                    command.ExecuteNonQuery();
                    conn.Close();

                    this.Close();
                }
            
        }
    }
}

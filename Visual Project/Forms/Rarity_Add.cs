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
    public partial class Rarity_Add : Form
    {
        string connString = "Data Source = DB.db; Version = 3";

        public Rarity_Add()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                INSERT INTO User (name, password)
                                VALUES (@login, @password)
                                ";

                command.Parameters.Add(new SQLiteParameter("@login", txtLogin.Text));
                command.Parameters.Add(new SQLiteParameter("@password", txtPassword.Text));
                command.Parameters.Add(new SQLiteParameter("@color", txtPassword.Text));


                command.ExecuteNonQuery();
                conn.Close();

                this.Close();

            }
        }
    }
}

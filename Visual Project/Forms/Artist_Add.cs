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
    public partial class Artist_Add : Form
    {
        string connString = "Data Source = DB.db; Version = 3";

        public Artist_Add()
        {
            InitializeComponent();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                INSERT INTO Artist (name)
                                VALUES (@name)
                                ";

                command.Parameters.Add(new SQLiteParameter("@name", txtImie_Naz.Text));


                command.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }


        }
    }
}
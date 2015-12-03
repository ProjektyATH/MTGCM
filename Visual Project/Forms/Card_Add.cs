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
    public partial class Card_Add : Form
    {
        string connString = "Data Source = DB.db; Version = 3";

        public Card_Add()
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
                                INSERT INTO [Card] (fk_base_id, fk_language_id, artwork, fk_artist_id, fk_rarity_id, fk_set_id, flavor_text, number, version )
                                VALUES (@fk_base_id, @fk_language_id, @artwork, @fk_artist_id, @fk_rarity_id, @fk_set_id, @flavor_text, @number, @version )
                                ";

                if (txtBase.Text == "" || txtLanguage.Text == "" || txtPicture.Text == null || txtArtist.Text == "" || txtRarity.Text == "" || txtSet.Text == "" || txtFlavor.Text == null || txtNumber.Text == "" || txtVersion.Text==null)
                {
                    MessageBox.Show("Pola nie mogą być puste!");
                }
                else
                {
                   
                    command.Parameters.Add(new SQLiteParameter("@fk_base_id", Convert.ToInt32(txtBase.Text)));
                    command.Parameters.Add(new SQLiteParameter("@fk_language_id", Convert.ToInt32(txtLanguage.Text)));
                    command.Parameters.Add(new SQLiteParameter("@artwork", txtPicture.Text));
                    command.Parameters.Add(new SQLiteParameter("@fk_artist_id", Convert.ToInt32(txtArtist.Text)));
                    command.Parameters.Add(new SQLiteParameter("@fk_rarity_id", Convert.ToInt32(txtRarity.Text)));
                    command.Parameters.Add(new SQLiteParameter("@fk_set_id", Convert.ToInt32(txtSet.Text)));
                    command.Parameters.Add(new SQLiteParameter("@flavor_text", txtFlavor.Text));
                    command.Parameters.Add(new SQLiteParameter("@number", Convert.ToInt32(txtNumber.Text)));
                    command.Parameters.Add(new SQLiteParameter("@version", txtVersion.Text));
                    command.ExecuteNonQuery();
                   
                    
                }
              
                conn.Close();

                this.Close();

            }
        }
    }
}

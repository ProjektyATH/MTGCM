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

    public partial class Card_Edit : Form
    {
        int id;
        string connString = "Data Source = DB.db; Version = 3";

        string Check(bool bo)
        {
            if (bo)
            {
                return "tak";
            }
            else return "nie";
        }

        public Card_Edit(int id_)
        {
            InitializeComponent();
            id = id_;

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM [Card] WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            labelId.Text = rdr.GetValue(0).ToString();

                            labelBase.Text = rdr.GetValue(1).ToString();
                            txtBase.Text = rdr.GetValue(1).ToString();

                            labelLanguage.Text = rdr.GetValue(2).ToString();
                            txtLanguage.Text = rdr.GetValue(2).ToString();

                            labelPicture.Text = rdr.GetValue(3).ToString();
                            txtPicture.Text = rdr.GetValue(3).ToString();

                            labelArtist.Text = rdr.GetValue(4).ToString();
                            txtArtist.Text = rdr.GetValue(4).ToString();

                            labelRarity.Text = rdr.GetValue(5).ToString();
                            txtRarity.Text = rdr.GetValue(5).ToString();

                            labelSet.Text = rdr.GetValue(6).ToString();
                            txtSet.Text = rdr.GetValue(6).ToString();

                            labelFlavor.Text = rdr.GetValue(7).ToString();
                            txtFlavor.Text = rdr.GetValue(7).ToString();

                            labelNumber.Text = rdr.GetValue(8).ToString();
                            txtNumber.Text = rdr.GetValue(8).ToString();

                            labelVersion.Text = rdr.GetValue(9).ToString();
                            txtVersion.Text = rdr.GetValue(9).ToString();
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
                                UPDATE [Card] SET 
                                fk_base_id = @fk_base_id,
                                fk_language_id = @fk_language_id, 
                                artwork = @artwork,
                                fk_artist_id = @fk_artist_id, 
                                fk_rarity_id = @fk_rarity_id,
                                fk_set_id = @fk_set_id,
                                flavor_text = @flavor_text,
                                number = @number,
                                version = @version
                                WHERE id = @id";
                command.Parameters.Add(new SQLiteParameter("@fk_base_id", Convert.ToInt32(txtBase.Text)));
                command.Parameters.Add(new SQLiteParameter("@fk_language_id", Convert.ToInt32(txtLanguage.Text)));
                command.Parameters.Add(new SQLiteParameter("@artwork", txtPicture.Text));
                command.Parameters.Add(new SQLiteParameter("@fk_artist_id", Convert.ToInt32(txtArtist.Text)));
                command.Parameters.Add(new SQLiteParameter("@fk_rarity_id", Convert.ToInt32(txtRarity.Text)));
                command.Parameters.Add(new SQLiteParameter("@fk_set_id", Convert.ToInt32(txtSet.Text)));
                command.Parameters.Add(new SQLiteParameter("@flavor_text", txtFlavor.Text));
                command.Parameters.Add(new SQLiteParameter("@number", Convert.ToInt32(txtNumber.Text)));
                command.Parameters.Add(new SQLiteParameter("@version", txtVersion.Text));
                command.Parameters.Add(new SQLiteParameter("@id", id));

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


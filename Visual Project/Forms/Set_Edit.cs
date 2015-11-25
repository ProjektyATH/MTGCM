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

    public partial class Set_Edit : Form
    {
        int id;
        string connString = "Data Source = DB.db; Version = 3";

        string Check (bool bo)
        {
            if (bo)
            {
                return "tak";
            }
            else return "nie";
        }

        public Set_Edit(int id_)
        {
            InitializeComponent();
            id = id_;

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM [Set] WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            labelId.Text = rdr.GetValue(0).ToString();

                            labelName.Text = rdr.GetValue(1).ToString();
                            txtName.Text = rdr.GetValue(1).ToString();

                            labelAbbrev.Text = rdr.GetValue(2).ToString();
                            txtAbbrev.Text = rdr.GetValue(2).ToString();

                            labelSymbol.Text = rdr.GetValue(3).ToString();
                            txtSymbol.Text = rdr.GetValue(3).ToString();

                            labelDate.Text = rdr.GetValue(4).ToString();
                            datePicker.Value = rdr.GetDateTime(4);

                            labelBlock.Text = rdr.GetValue(5).ToString();
                            txtBlock.Text = rdr.GetValue(5).ToString();

                            labelTotal.Text = rdr.GetValue(6).ToString();
                            txtTotal.Text = rdr.GetValue(6).ToString();

                            labelCore.Text = Check(Convert.ToBoolean(rdr.GetValue(7)));
                            radioCore.Checked = Convert.ToBoolean(rdr.GetValue(7));

                            labelSpecial.Text = Check(Convert.ToBoolean(rdr.GetValue(8)));
                            radioSpecial.Checked = Convert.ToBoolean(rdr.GetValue(8));

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
                                UPDATE [Set] SET 
                                name = @name,
                                abbrev = @abbrev,
                                symbol = @symbol, 
                                relase_date = @relase_date, 
                                fk_block_id = @fk_block_id, 
                                cards_total = @cards_total, 
                                is_core = @is_core,
                                is_special = @is_special
                                WHERE id = @id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
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
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}

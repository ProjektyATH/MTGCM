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

    public partial class CardBase_Edit : Form
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

        public CardBase_Edit(int id_)
        {
            InitializeComponent();
            id = id_;

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM [CardBase] WHERE id=@id";
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

                            labelText.Text = rdr.GetValue(2).ToString();
                            txtText.Text = rdr.GetValue(2).ToString();

                            labelPower.Text = rdr.GetValue(3).ToString();
                            txtPower.Text = rdr.GetValue(3).ToString();

                            labelToughness.Text = rdr.GetValue(4).ToString();
                            txtToughness.Text = rdr.GetValue(4).ToString();

                            labelMana.Text = rdr.GetValue(5).ToString();
                            txtMana.Text = rdr.GetValue(5).ToString();

                            labelCmc.Text = rdr.GetValue(6).ToString();
                            txtCmc.Text = rdr.GetValue(6).ToString();
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
                                UPDATE [CardBase] SET 
                                name = @name,
                                text = @text, 
                                power = @power,
                                toughness = @toughness, 
                                mana_cost = @mana_cost,
                                cmc = @cmc
                                WHERE id = @id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.Parameters.Add(new SQLiteParameter("@name", txtName.Text));
                command.Parameters.Add(new SQLiteParameter("@text", txtText.Text));            
                command.Parameters.Add(new SQLiteParameter("@power", Convert.ToInt32(txtPower.Text)));
                command.Parameters.Add(new SQLiteParameter("@toughness", Convert.ToInt32(txtToughness.Text)));
                command.Parameters.Add(new SQLiteParameter("@mana_cost", txtMana.Text));
                command.Parameters.Add(new SQLiteParameter("@cmc", Convert.ToInt32(txtCmc.Text)));


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

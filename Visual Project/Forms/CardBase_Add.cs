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
    public partial class CardBase_Add : Form
    {
        string connString = "Data Source = DB.db; Version = 3";

        public CardBase_Add()
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
                                INSERT INTO [CardBase] (name, text, power, toughness, mana_cost, cmc)
                                VALUES (@name, @text,  @power, @toughness, @mana_cost, @cmc)
                                ";
                if (txtName.Text == null || txtText.Text == null || txtPower.Text == "" ||txtToughness.Text == "" || txtMana.Text == null || txtCmc.Text==null)
                {
                    MessageBox.Show("Pola nie mogą być puste!");
                }
                else
                {
                    command.Parameters.Add(new SQLiteParameter("@name", txtName.Text));
                    command.Parameters.Add(new SQLiteParameter("@text", txtText.Text));
                    command.Parameters.Add(new SQLiteParameter("@power", Convert.ToInt32(txtPower.Text)));
                    command.Parameters.Add(new SQLiteParameter("@toughness", Convert.ToInt32(txtToughness.Text)));
                    command.Parameters.Add(new SQLiteParameter("@mana_cost", txtMana.Text));
                    command.Parameters.Add(new SQLiteParameter("@cmc", txtCmc.Text));
                    command.ExecuteNonQuery();
                }
                
               

              
                conn.Close();

                this.Close();

            }
        }
    }
}

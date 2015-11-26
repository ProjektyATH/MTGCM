﻿using System;
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
    public partial class Artist_List : Form
    {

        string connString = "Data Source = DB.db; Version = 3";
        DataTable table_DT = new DataTable();
        int id;
        int index;

        private void Odswierz()
        {
            table_DT.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM [Artist];", conn);
                adapter.Fill(table_DT); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dataGridView1.DataSource = table_DT; // Przypisujemy dane z DataTabla do naszego GridView      
            dataGridView1.ClearSelection();
        }

        private void EditArtist()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Artist_Edit objSet_Edit = new Artist_Edit(id);
                objSet_Edit.ShowDialog();
                Odswierz();
            }

        }

        private void AddArtist()
        {

            Artist_Add objSet_Add = new Artist_Add();
            objSet_Add.ShowDialog();
            Odswierz();

        }

        private void DeleteArtist()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.RowCount != 0) index = dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć artyste numer " + id + "? \n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command = new SQLiteCommand(conn);
                        command.CommandText = "DELETE FROM [Artist] WHERE id = @id";
                        command.Parameters.Add(new SQLiteParameter("@id", id));
                        command.ExecuteNonQuery();
                        conn.Close();
                        Odswierz();
                        if (dataGridView1.RowCount != 0)
                        {
                            if (index == dataGridView1.RowCount) dataGridView1.CurrentCell = dataGridView1.Rows[index - 1].Cells[0];
                            else dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
                        }
                    }
            }
        }
        public Artist_List()
        {
            InitializeComponent();
            Odswierz();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddArtist();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditArtist();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteArtist();
        }
    }
}

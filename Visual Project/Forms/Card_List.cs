using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace MTGCM.Forms
{
    public partial class Card_List : Form
    {
        

        public Card_List()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh() 
        {
           var DB = new DBEntities();
            DB.Card.Load();
            dataGridView1.DataSource = DB.Card.Local.ToBindingList();
           
        }
        private void Card_List_Load(object sender, EventArgs e)
        {

            Refresh();

            // TODO: This line of code loads data into the 'dBDataSet.Card' table. You can move, or remove it, as needed.
            this.cardTableAdapter.Fill(this.dBDataSet.Card);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}

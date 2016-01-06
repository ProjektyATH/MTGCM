using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGCM
{
    public partial class MainWindow : Form
    {
       
        private void OpenChild<TForm>()
            where TForm : Form, new()
        {
            TForm objChild = new TForm();
            objChild.MdiParent = this;
            objChild.Show();
            objChild.WindowState = FormWindowState.Maximized;
        }

        private void CloseChildren()
        {
            Form[] children = this.MdiChildren;
            foreach (Form chform in children)
                chform.Close();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

       
            private void Card_TSMI_Click(object sender, EventArgs e)
        {
            CloseChildren();
            OpenChild<Forms.Card_List>();
        }

            private void importerToolStripMenuItem_Click(object sender, EventArgs e)
            {
                CloseChildren();
                OpenChild <Forms.Import>();
            }       

        //private void User_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.User_List>();
           
        //}

        //private void OwnedCard_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.OwnedCard_List>();
        //}

        //private void Deck_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.Deck_List>();
        //}

        //private void CardBase_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.CardBase_List>();
        //}

        

        //private void Set_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.Set_List>();
        //}

        //private void Block_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.Block_List>();
        //}

        //private void Rarity_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.Rarity_List>();
        //}

        //private void Type_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.CardType_List>();
        //}

        //private void Subtype_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.CardSubtype_List>();
        //}

        //private void Language_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.Language_List>();
        //}

        //private void Artist_TSMI_Click(object sender, EventArgs e)
        //{
        //    CloseChildren();
        //    OpenChild<Forms.Artist_List>();
        //}

    }
}



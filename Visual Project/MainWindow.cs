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

        private void User_TSMI_Click(object sender, EventArgs e)
        {
            CloseChildren();
            Forms.User_List chUser = new Forms.User_List();
            chUser.MdiParent = this;
            chUser.Show();
        }

    }
}

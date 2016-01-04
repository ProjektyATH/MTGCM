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
    public partial class Card_Edit : Form
    {
        int id;

        public Card_Edit(int id_)
        {
            InitializeComponent();
            id = id_;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.Entity;

namespace MTGCM.Forms
{
    public partial class Import : Form
    {
        string path, text;

        public Import()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = path = openFileDialog1.FileName;
            textBox2.Text = text = System.IO.File.ReadAllText(@path);

            List<JClasses.JSet> sets = JsonConvert.DeserializeObject<List<JClasses.JSet>>(text);

            foreach (var s in sets)
            {
                
            }
            
        }
    }
}

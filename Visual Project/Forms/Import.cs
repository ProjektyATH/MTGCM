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
           
            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    List<JClasses.JSet> sets = JsonConvert.DeserializeObject<List<JClasses.JSet>>(text);
                    using (var db = new DBEntities())
                    {
                        var S = from s in db.Sets
                                select s;


                        foreach (var s in sets)
                        {
                            var tmp = S.Where(c=>c.name.Contains(s.name));
                            if (tmp == null)
                            {
                                Set Tmp = new Set();
                                Tmp.abbrev = s.code;
                                Tmp.name = s.name;
                                Tmp.relase_date = Convert.ToDateTime(s.releaseDate);

                                db.Sets.Add(Tmp);
                                db.SaveChanges();

                            }
                        }
                    }
                    break;  
                default:
                    break;
            }
            
            
        }
    }
}

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
           
           
            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    textBox2.Text = text = System.IO.File.ReadAllText(@path);
                    List<JClasses.JSet> sets1 = JsonConvert.DeserializeObject<List<JClasses.JSet>>(text);
                    using (var db = new DBEntities())
                    {
                        var S = from s in db.Set
                                select s;


                        foreach (var s in sets1)
                        {
                            var tmp = S.Where(c=>c.name.Contains(s.name));
                            if (tmp.Count() == 0)
                            {
                                Set Tmp = new Set();

                                
                                Tmp.symbol = s.code;
                                Tmp.name = s.name;
                                Tmp.relase_date = Convert.ToDateTime(s.releaseDate);


                                db.Set.Add(Tmp);
                                db.SaveChanges();

                            }
                        }
                    }
                    break;  

                case 1:
                    textBox2.Text = text = "[" + System.IO.File.ReadAllText(@path) + "]";
                    List<JClasses.JSet> sets2 = JsonConvert.DeserializeObject<List<JClasses.JSet>>(text);
                    using (var db = new DBEntities())
                    {
                        var S = from s in db.Set
                                select s;


                        foreach (var s in sets2)
                        {
                            var tmps = S.Where(c=>c.name.Contains(s.name));
                            if (tmps.Count() == 0)
                            {
                                Set TmpS = new Set();

                                TmpS.abbrev = s.gathererCode;
                                TmpS.symbol = s.code;
                                TmpS.is_core = (s.type == "core") ? true : false;
                                TmpS.is_special = (s.type == "core") ? false : true;
                                TmpS.name = s.name;
                                TmpS.relase_date = Convert.ToDateTime(s.releaseDate);

                                var tmpb = from b in db.Block
                                           where b.name == s.block
                                           select b;
                                if (s.block != null)
                                {
                                    if (tmpb.Count() == 0)
                                    {
                                        Block TmpB = new Block();

                                        TmpB.name = s.block;

                                        db.Block.Add(TmpB);
                                        db.SaveChanges();
                                    }

                                    Block tmp = (from b in db.Block
                                                 where b.name == s.block
                                                 select b).First();

                                    TmpS.fk_block_id = tmp.id;
                                }
                                TmpS.cards_total = s.cards.Count();

                                db.Set.Add(TmpS);
                                db.SaveChanges();
                            }

                                var CB = from cb in db.CardBase
                                        select cb;
                                var C = from c in db.CardBase
                                         select c;
                                foreach (var card in s.cards)
                                {

                                    var tmpcb = CB.Where(cb => cb.name == card.name);
                                    if (tmpcb.Count() == 0)
                                    {
                                        
                                    }

                                    var tmpc = C.Where(c => c.name == card.name);
                                    if (tmpc.Count() == 0)
                                    {

                                    }


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

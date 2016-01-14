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

            try
            {
                switch (checkedListBox1.SelectedIndex)
                {
                    case 0:
                        textBox2.Text = text = System.IO.File.ReadAllText(@path);
                        List<Json> sets1 = JsonConvert.DeserializeObject<List<Json>>(text);
                        using (var db = new DBEntities())
                        {
                            var S = from s in db.Set
                                    select s;


                            foreach (var s in sets1)
                            {
                                var tmp = S.Where(c => c.name.Contains(s.name));
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
                        textBox2.Text = text = System.IO.File.ReadAllText(@path);
                        wstaw(text);
                        break;
                    case 2:
                        textBox2.Text = text = "[" + System.IO.File.ReadAllText(@path) + "]";
                        wstaw(text);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                 MessageBox.Show("Sprawdź czy dobrze wybrałeś typ pliku lub czy plik jest prawidłowy", "Ważne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        void wstaw(string text)
        {
            List<Json> sets2 = JsonConvert.DeserializeObject<List<Json>>(text);
           
            using (var db = new DBEntities())
            {
                logTB.Text += "Wczytano plik JSON do obiektu \r\n";

                var S = from s in db.Set
                        select s;

                int sety = sets2.Count;
                int Sety = 1;
                foreach (var s in sets2)
                {
                    logTB.Text += "     rozpoczęto dodawanie zestawu " + Sety + "/" + sety + "  \r\n";
                    logTB.Refresh();
                    var tmps = S.Where(c => c.name.Contains(s.name));
                    if (tmps.Count() == 0)
                    {
                        Set TmpS = new Set();

                        TmpS.abbrev = (s.code == null) ? s.code : s.gathererCode;
                        TmpS.symbol = s.code;
                        TmpS.name = s.name;
                        TmpS.relase_date = Convert.ToDateTime(s.releaseDate);

                        if (s.block != null)
                        {
                            var tmpb = from b in db.Block
                                       where b.name == s.block
                                       select b;


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
                    int karty = s.cards.Count;
                    int Karty = 1;
                    foreach (var card in s.cards)
                    {
                        
                        var tmpc = CB.Where(cb => cb.name == card.name);
                        var tmpcb = tmpc.Where(cb => cb.Set.symbol == s.gathererCode);
                        if (tmpcb.Count() == 0)
                        {
                            CardBase TmpCB = new CardBase();

                            TmpCB.name = card.name;
                            TmpCB.image = card.imageName;
                            TmpCB.cmc = card.cmc;
                            TmpCB.mana_cost = card.manaCost;
                            TmpCB.number = card.number;
                            TmpCB.version = card.multiverseid;
                            TmpCB.power = card.power;
                            TmpCB.toughness = card.toughness;
                            TmpCB.oracle_text = card.text;
                            TmpCB.flavor_text = card.flavor;
                            TmpCB.fk_language_id = 0;

                            TmpCB.fk_set_id = (from r in db.Set
                                               where r.symbol == s.code
                                               select r).First().id;

                            if (card.artist != null)
                            {
                                var tmpa = from a in db.Artist
                                           where a.name == card.artist
                                           select a;


                                if (tmpa.Count() == 0)
                                {
                                    Artist TmpA = new Artist();

                                    TmpA.name = card.artist;

                                    db.Artist.Add(TmpA);
                                    db.SaveChanges();
                                }

                                Artist tmp = (from a in db.Artist
                                              where a.name == card.artist
                                              select a).First();

                                TmpCB.fk_artist_id = tmp.id;
                            }

                            if (card.rarity != null)
                            {
                                var tmpr = from r in db.Rarity
                                           where r.name == card.rarity
                                           select r;


                                if (tmpr.Count() == 0)
                                {
                                    Rarity TmpR = new Rarity();

                                    TmpR.name = card.rarity;

                                    db.Rarity.Add(TmpR);
                                    db.SaveChanges();
                                }

                                Rarity tmp = (from r in db.Rarity
                                              where r.name == card.rarity
                                              select r).First();

                                TmpCB.fk_rarity_id = tmp.id;
                            }

                            db.CardBase.Add(TmpCB);
                            db.SaveChanges();
                            logTB.Text += "          dodano kartę " + Karty + "/" + karty + "  \r\n";
                            logTB.Refresh();
                            Karty ++;
                        }
                    }
                    logTB.Text += "     zestaw " + Sety + "/" + sety + " został dodany  \r\n";
                    logTB.Refresh();
                    
                    Sety++;
                }
            }
        }
    }


}

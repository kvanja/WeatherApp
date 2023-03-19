using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;
using System.Globalization;

namespace Vremenska_Prognoza {
    public partial class winIzaberiGrad : Form {
        public winIzaberiGrad() {
            InitializeComponent();
            Lista = new List<String>();
            sec = 0;
            n = 0;
            DohvatiSveGradove();
        }
        //izabran item iz comboboxa dodjeljuje se varijabli grad tako da se kasnije može proslijediti novoj formi u konstruktoru, ako se izabere grad ne dobiva se upozorenje
        private void cmBxIzaberiGrad_SelectedIndexChanged(object sender, EventArgs e) {
            grad = cmBxIzaberiGrad.SelectedItem.ToString();
            lblUpozorenje.Visible = false;
        }

        //kada se klikne na button "Uredu" ulazimo u novu formu
        private void btnPotvrde_Click(object sender, EventArgs e) {
            if (!File.Exists(putanja)) { //ako ne postoji file na putanji radi se novi file na toj putanji, upisuje se odabrani grad te se zatvara file
                ZapisiUFile(grad);
            }
            else if (File.ReadAllText(putanja) != grad) { // ako postoji file na putanji, čitamo sve iz filea te ako je različito od trenutnog grada, briše se sve iz filea, te se upisuje novo odabrani grad, zatvara se file
                File.WriteAllText(putanja, string.Empty);
                ZapisiUFile(grad);
            }
            if (grad == null) { // ako nije odabran grad pokreće se timer na 3 sekunde te se lblUpozorenje postavlja na visable koje na 3 sekunde pokazuje poruku da se mora odabrati grad
                timer1.Start();
                lblUpozorenje.Visible = true;
                return;
            }
            Close();//zatvara se trenutni prozor
            ThreadnoviProzor = new Thread(PokreniNoviProzor);//otvaranje i pokretanje novog prozora u novoj dretvi
            ThreadnoviProzor.SetApartmentState(ApartmentState.STA);
            ThreadnoviProzor.Start();
        }

        private void PokreniNoviProzor() { //funkcija koja pokreće novi prozor
            winPrognoza prognozaZaDanas = new winPrognoza(grad);
            prognozaZaDanas.Show();
            Application.Run();
        }

        private void Timer_Tick(object sender, EventArgs e) { //timer se pokreće na 3 sekunde te se varijabli sec dodjeljuje sekunda da bi znali kada prođe 3 sec
            if (sec == 3) {
                timer1.Stop();
                lblUpozorenje.Visible = false;
                sec = 0;
            }
            sec++;
        }

        protected static void bla() {
            throw new NotImplementedException();
        }

        private void ZapisiUFile(string grad) { // zmetoda koja zapisuje u file
            file = new StreamWriter(putanja);
            file.Write(grad);
            file.Close();
        }

        //kada se u menuStripu klikne na izađi, izlazi se iz aplikacije
        private void izađiToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //u menuStripu na klik o programu izbacuje tko je napravio program, te koja je verzija programa
        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Aplikaciju su izradili Andrej Lovrić i Kristijan Vanja \n\n\n\t\t\t\tVerzija: 1.0");
        }

        //funkcija za minimiziranje prozora
        private void minimiziraj(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        public void DohvatiSveGradove() {
            while (reader.Read()) {
                if (reader.NodeType == XmlNodeType.Text) {
                    bool isNumeric = float.TryParse(reader.Value, out n);
                    if (!isNumeric) {
                        if (char.IsUpper(reader.Value[0]) && reader.Value.Length > 2) {
                            Lista.Add(reader.Value);
                        }
                    }
                }
            }
            foreach(String s in Lista) {
                cmBxIzaberiGrad.Items.Add(s);
            }
        }

        private XmlReader reader = XmlReader.Create("http://vrijeme.hr/hrvatska_n.xml");
        public List<String> Lista { get; set; }
        private float n;

        public string grad; // za potrebe konstruktora za sljedeću formu
        private int sec; // za potrebe timera
        private string putanja = ".\\Grad.txt"; //putanja txt filea
        private StreamWriter file; // za potrebe zapisivanja u file
        private Thread ThreadnoviProzor; // za potrebe otvaranja novog prozora
    }
}

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

namespace Vremenska_Prognoza {
    public partial class winPrognoza : Form {
        public winPrognoza(string imeGrada) {
            InitializeComponent();
            lblImeGrada.Text = imeGrada; // imeGrada se koristi tako da znamo za koji grad želimo vidjeti temperaturu
            Datum = DateTime.Now; // koristi se da bi znali koji je danas datum, pomoću ćega ćemo vidjeti tempraturu
            lblDatum.Text = Datum.ToString();
            d = new DohvacanjePodataka(lblImeGrada.Text);
            wd = d.DohvatiPodatkeZaJedanGrad();

            //slika pozadine se mijenja ovisno o godišnjem dobu i boju nekih tekstova ovisno o boji pozadine
            if (Datum.Month == 3 && Datum.Day >= 21 || Datum.Month < 7 && Datum.Day < 31 && Datum.Month < 7 && Datum.Day < 21) {
                BackgroundImage = Properties.Resources.spring;
                PostaviCrnuBojuLblImeGrada();
            }
            else if (Datum.Month == 6 && Datum.Day >= 21 || Datum.Month < 10 && Datum.Day < 31 && Datum.Month < 10 && Datum.Day < 23) {
                BackgroundImage = Properties.Resources.summer;
            }
            else if (Datum.Month == 9 && Datum.Day >= 23 || Datum.Month < 13 && Datum.Day < 31 && Datum.Month < 13 && Datum.Day < 22) {
                BackgroundImage = Properties.Resources.fall;
            }
            else {
                BackgroundImage = Properties.Resources.winter;
                PostaviCrnuBojuMenua();
            }
            //Poziv funkcije koja postavlja podatke u labele i pictureboxove
            PostaviPodatke();
        }

        //zbog različitih slika na svakom godišnjem dobu dodao sam metodu kojom mijenjam text u labeli lblImeGrada tako da se u svkaom godišnjem dobu lijepo vidi
        private void PostaviCrnuBojuLblImeGrada() {
            lblImeGrada.ForeColor = Color.Black;
        }
        //Postavlja crnu boju menua na pozadini za zimu
        private void PostaviCrnuBojuMenua() {
            izađiToolStripMenuItem.ForeColor = Color.Black;
            oProgramu.ForeColor = Color.Black;
        }

        //na klik slike strijelice putem novog threada vraćamo se u formu gdje odabiremo grad za koji želimo vidjet itemperaturu
        private void pctrBxNazad_Click(object sender, EventArgs e) {
            File.WriteAllText(putanja, string.Empty);
            Close();
            ThreadOtvoriProzor = new Thread(PokreniNoviProzor);
            ThreadOtvoriProzor.SetApartmentState(ApartmentState.STA);
            ThreadOtvoriProzor.Start();
        }

        //funkcija koja otvara novu formu
        private void PokreniNoviProzor() {
            winIzaberiGrad izaberiGrad = new winIzaberiGrad();
            izaberiGrad.Show();
            Application.Run(izaberiGrad);
            Close();
        }
        //izlaženje iz programa putem menua
        private void izađiToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }
        //kada se klikne na programu izbaciti će se poruka ko je napravio program
        private void oProgramu_Click_1(object sender, EventArgs e) {
            MessageBox.Show("Aplikaciju su izradili Andrej Lovrić i Kristijan Vanja \n\n\n\t\t\t\tVerzija: 1.0");
        }
        //kada se u menustripu klikne na ___ minimizira se prozor
        private void minimiziraj_Click_1(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        //funkcija za postavljanje svega u labele i pictureboxove
        private void PostaviPodatke() {
            lblTemperatura.Text = wd.VratiTemp().ToString() + " °C";
            //ako je temperatura veća od 30 stupnjeva postavi text crveno,da se zna jelte!
            if (wd.VratiTemp() > 30) {
                lblTemperatura.ForeColor = Color.Red;
                pctrBxVisokaTemp.BackgroundImage = Properties.Resources.visokaTemp;
            }
            lblTlak.Text = wd.VratiTlak() + " hPa";
            lblVlaga.Text = wd.VratiVlagu() + " kg/m3";
            lblSmjerVjetra.Text = wd.VratiSmjerVjetra();
            lblBrzinaVjetra.Text = wd.VratiBrzinuVjetra() + " km/h";
            lblVrijeme.Text = wd.VratiVrijeme();
            ProvjeriVrijeme();
        }

        public void ProvjeriVrijeme() {
            if (wd.VratiVrijeme() == "vedro") {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.Sunčano2;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (wd.VratiVrijeme().Contains("kiša")) {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.kišovito;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (wd.VratiVrijeme().Contains("promjenjivo")) {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.promijenjivo_sa_naoblakom;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (wd.VratiVrijeme() == "pretežno vedro") {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.sunčanoNaoblaka;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (wd.VratiVrijeme() == "oblačno") {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.oblačno;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (wd.VratiVrijeme() == "umjereno oblačno" || wd.VratiVrijeme() == "pretežno oblačno") {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.sunčanoNaoblaka;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (wd.VratiVrijeme().Contains("snijeg")) {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.snijeg;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else {
                pctrBoxVrijeme.BackgroundImage = Properties.Resources.Sunčano2;
                pctrBoxVrijeme.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private string putanja = ".\\Grad.txt"; //putanja text filea u kojem je zapisan zadnji grad koji smo koristili
        private Thread ThreadOtvoriProzor; // thread za novi prozor tako da možemo ugasiti trenutni
        private DateTime Datum { get; set; }
        private DohvacanjePodataka d;
        private WeatherData wd;
    }
}

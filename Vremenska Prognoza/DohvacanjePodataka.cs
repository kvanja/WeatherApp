using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace Vremenska_Prognoza {

    class DohvacanjePodataka : winIzaberiGrad {

        public DohvacanjePodataka(string imeGrada) {
            ImeGrada = imeGrada;
            wd = new WeatherData(imeGrada);
        }

        public DohvacanjePodataka() {
            wd = new WeatherData(ImeGrada);
        }

        public WeatherData DohvatiPodatkeZaJedanGrad() {
            while (reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Text:
                        if (reader.Value != "") {
                            if (reader.Value == ImeGrada) {
                                Console.WriteLine("Podatci za " + ImeGrada + "su: ");
                                for (int i = 0; i < 48; i++) {
                                    reader.Read();
                                    if (i == 13) {
                                        Console.WriteLine("Temperatura je: " + reader.Value);
                                        if (reader.Value == "-") {
                                            wd.Temperatura = 0;
                                        }
                                        wd.Temperatura = double.Parse(reader.Value, System.Globalization.CultureInfo.InvariantCulture);
                                    }
                                    if (i == 17) {
                                        Console.WriteLine("Vlaga je: " + reader.Value);
                                        if (reader.Value == "-") {
                                            wd.Vlaga = "Trenutno nema podataka";
                                        }
                                        else {
                                            wd.Vlaga = reader.Value;
                                        }
                                    }
                                    if (i == 21) { // dodjeljivanje podatka za tlak objektu wd varijabli tlak;
                                        Console.WriteLine("Tlak je: " + reader.Value);
                                        if (reader.Value == "-") {
                                            wd.Tlak = "Trenutno nema podataka";
                                        }
                                        else {
                                            wd.Tlak = reader.Value;
                                        }
                                    }
                                    if (i == 29) {
                                        if (reader.Value == "S") {
                                            wd.SmjerVjetra = "Smjer vjetra: Jug";
                                        }
                                        else if (reader.Value == "SW") {
                                            wd.SmjerVjetra = "Smjer vjetra: Jugozapad";
                                        }
                                        else if (reader.Value == "SE") {
                                            wd.SmjerVjetra = "Smjer vjetra: Jugoistok";
                                        }
                                        else if (reader.Value == "W") {
                                            wd.SmjerVjetra = "Smjer vjetra: Zapad";
                                        }
                                        else if (reader.Value == "N") {
                                            wd.SmjerVjetra = "Smjer vjetra: Sjever";
                                        }
                                        else if (reader.Value == "NW") {
                                            wd.SmjerVjetra = "Smjer vjetra: Sjeverozapad";
                                        }
                                        else if (reader.Value == "NE") {
                                            wd.SmjerVjetra = "Smjer vjetra: Sjeveristok";
                                        }
                                        else if (reader.Value == "E") {
                                            wd.SmjerVjetra = "Smjer vjetra: Istok";
                                        }
                                        else {
                                            wd.SmjerVjetra = "Nema vjetra";
                                        }
                                    }
                                    if (i == 33) {
                                        Console.WriteLine("Vjetar brzina: " + reader.Value);
                                        wd.BrzinaVjetra = reader.Value;
                                    }
                                    if (i == 37) {
                                        Console.WriteLine("Vrijeme će biti: " + reader.Value);
                                        wd.Vrijeme = reader.Value;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                }
            }
            return wd;
        }

        public string VratiImeGrada() {
            return ImeGrada;
        }

        private XmlReader reader = XmlReader.Create("http://vrijeme.hr/hrvatska_n.xml");
        string ImeGrada { get; set; }
        private WeatherData wd;
    }
}

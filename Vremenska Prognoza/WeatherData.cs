using System;

namespace Vremenska_Prognoza
{
    [Serializable()]
    class WeatherData {

        public WeatherData(string grad, WeatherData bla) {
            ImeGrada = grad;
        }
        public WeatherData(string grad) {
            ImeGrada = grad;
        }

        public double VratiTemp() {
            return Temperatura;
        }

        public string VratiVlagu() {
            return Vlaga;
        }

        public string VratiTlak() {
            return Tlak;
        }

        public string VratiSmjerVjetra() {
            return SmjerVjetra;
        }

        public string VratiBrzinuVjetra() {
            return BrzinaVjetra;
        }
        public string VratiVrijeme() {
            return Vrijeme;
        }




        [System.Xml.Serialization.XmlElement("GradIme")]
        public string ImeGrada { get; set; }

        [System.Xml.Serialization.XmlElement("Temp")]
        public double Temperatura { get; set; }

        [System.Xml.Serialization.XmlElement("Vlaga")]
        public string Vlaga { get; set; }

        [System.Xml.Serialization.XmlElement("Tlak")]
        public string Tlak { get; set; }

        [System.Xml.Serialization.XmlElement("VjetarSmjer")]
        public string SmjerVjetra { get; set; }

        [System.Xml.Serialization.XmlElement("VjetarBrzina")]
        public string BrzinaVjetra { get; set; }

        [System.Xml.Serialization.XmlElement("VrijemeBude")]
        public string Vrijeme { get; set; }

    }
}

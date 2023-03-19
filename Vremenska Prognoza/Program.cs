using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vremenska_Prognoza {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            string putanja = ".\\Grad.txt";//putanja tekstualne datoteke tako da znamo koji prozor se otvara
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ako file na putanji ne postoji ili ako file postoji a ne piše ništa u njemu otvorit će se prvi prozor gdje se odabire grad
            if (!File.Exists(putanja) || File.ReadAllText(putanja) == "") {
                Application.Run(new winIzaberiGrad());
            }
            else { // inače se otvara prognoza za danas sa zadnje odabranim gradom
                string grad = File.ReadAllText(putanja);
                Application.Run(new winPrognoza(grad));
                new DohvacanjePodataka();
                new WeatherData(grad);
            }
            
        }
    }
}

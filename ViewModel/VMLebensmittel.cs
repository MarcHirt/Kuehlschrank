using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class VMLebensmittel
    {
        private Lebensmittel lebensmittel;

        public VMLebensmittel(string bezeichnung, double verderb, double idealtemperatur, double multiplikator, double gefrierpunkt)
        {
            lebensmittel = new Lebensmittel(bezeichnung, verderb, idealtemperatur, multiplikator, gefrierpunkt);
        }
    }
}

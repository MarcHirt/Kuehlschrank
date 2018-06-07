using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lebensmittel
    {
        private double essbarkeit = 100;
        private double verderb;
        private string bezeichnung;
        private double idealtemperatur;
        private double multiplikator;
        private double gefrierpunkt;

        public Lebensmittel(string bezeichnung, double verderb, double idealtemperatur, double multiplikator, double gefrierpunkt)
        {
            Bezeichnung = bezeichnung;
            Verderb = verderb;
            Idealtemperatur = idealtemperatur;
            Multiplikator = multiplikator;
            Gefrierpunkt = gefrierpunkt;
        }


        public double Essbarkeit
        {
            get
            {
                return essbarkeit;
            }

            set
            {
                essbarkeit = value;
            }
        }

        public double Verderb
        {
            get
            {
                return verderb;
            }

            set
            {
                verderb = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public double Idealtemperatur
        {
            get
            {
                return idealtemperatur;
            }

            set
            {
                idealtemperatur = value;
            }
        }

        public double Multiplikator
        {
            get
            {
                return multiplikator;
            }

            set
            {
                multiplikator = value;
            }
        }

        public double Gefrierpunkt
        {
            get
            {
                return gefrierpunkt;
            }

            set
            {
                gefrierpunkt = value;
            }
        }
    }
}

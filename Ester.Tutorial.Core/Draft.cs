using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ester.Tutorial.Core
{
    public class Draft
    {
        #region Fields
        private string abonnementsNummer;
        private string name;
        private string fakturaNummer;
        private string note;
        private double beloeb;
        #endregion

        #region Constructors
        public Draft() { }
        public Draft(string abo, string name, string fakt, string note, double kr)
        {
            this.abonnementsNummer = abo;
            this.name = name;
            this.fakturaNummer = fakt;
            this.note = note;
            this.beloeb = kr;
        }
        #endregion

        #region Events

        #endregion

        #region Methods

        #endregion

        #region Properties
        public string AbonnementsNummer { get => abonnementsNummer; set => abonnementsNummer = value; }
        public string Name { get => name; set => name = value; }
        public string FakturaNummer { get => fakturaNummer; set => fakturaNummer = value; }
        public string Note { get => note; set => note = value; }
        public double Beloeb { get => beloeb; set => beloeb = value; }
        #endregion
    }
}

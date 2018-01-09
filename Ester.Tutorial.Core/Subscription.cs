using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ester.Tutorial.Core
{
    public class Subscription
    {
        #region Fields
        private string amount;
        private string cancelled;
        private string credit;
        private string debit;
        private string description;
        private string id;
        private string next;
        private string reminder;
        private string startDate;
        private string stopDate;
        #endregion

        #region Constructors
        public Subscription() { }
        public Subscription(string desc, string id, string start, string stop, string kr, string nxt, string deb = null, string kred = null, string rem = null, string cancel = null)
        {
            this.description = desc;
            this.id = id;
            this.startDate = start;
            this.stopDate = stop;
            this.debit = deb;
            this.credit = kred;
            this.amount = kr;
            this.next = nxt;
            this.reminder = rem;
            this.cancelled = cancel;
        }
        #endregion

        #region Events

        #endregion

        #region Methods

        #endregion

        #region Properties
        public string Beløb { get => amount; set => amount = value; }
        public string Beskrivelse { get => description; set => description = value; }
        public string Debit { get => debit; set => debit = value; }
        public string Id { get => id; set => id = value; }
        public string Kredit { get => credit; set => credit = value; }
        public string Næste { get => next; set => next = value; }
        public string Opsagt { get => cancelled; set => cancelled = value; }
        public string Rykker { get => reminder; set => reminder = value; }
        public string StartDato { get => startDate; set => startDate = value; }
        public string StopDato { get => stopDate; set => stopDate = value; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ester.Tutorial.Core
{
    public class Subscriber : Person
    {
        #region Fields
        private string subscriberNumber;
        #endregion

        #region Constructors
        public Subscriber() { }
        public Subscriber(string sub, string name, string adr, string zip, string town, string cntr, string place = null, string phPref = null, string phone = null, string cPref = null, string cell = null, string mail = null) : base(name, adr, zip, town, cntr, place, phPref, phone, cPref, cell, mail)
        {
            this.subscriberNumber = sub;
            base.Name = name;
            base.Address = adr;
            base.Place = place;
            base.Zip = zip;
            base.Town = town;
            base.Country = cntr;
            base.PhonePrefix = phPref;
            base.Phone = phone;
            base.CellPhonePrefix = cPref;
            base.CellPhone = cell;
            base.EMailAddress = mail;
        }
        #endregion

        #region Events

        #endregion

        #region Methods
        public override string ToString() { return (SubscriberNumber + Environment.NewLine + Name + Environment.NewLine + Address + Environment.NewLine + Environment.NewLine + Zip + " " + Town + Environment.NewLine + PhonePrefix + "-" + Phone + " - " + CellPhonePrefix + "-" + CellPhone + Environment.NewLine +  EMailAddress); }
        #endregion

        #region Properties
        public string SubscriberNumber { get => subscriberNumber; set => subscriberNumber = value; }
        #endregion

    }
}

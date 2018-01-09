using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ester.Tutorial.Core
{
    public class Person
    {
        #region Fields
        private string address;
        private string cellPhone;
        private string cellPhonePrefix;
        private string country;
        private string eMailAddress;
        private string name;
        private string phone;
        private string phonePrefix;
        private string place;
        private string town;
        private string zip;
        #endregion

        #region Constructors
        public Person() { }
        public Person(string name, string adr, string zip, string town, string cntr, string place = null, string phPref = null, string phone = null, string cPref = null, string cell = null, string mail = null)
        {
            this.name = name;
            this.address = adr;
            this.place = place;
            this.zip = zip;
            this.town = town;
            this.country = cntr;
            this.phonePrefix = phPref;
            this.phone = phone;
            this.cellPhonePrefix = cPref;
            this.cellPhone = cell;
            this.eMailAddress = mail;
        }
        #endregion

        #region Events

        #endregion

        #region Methods

        #endregion

        #region Properties
        public string Address { get => address; set => address = value; }
        public string CellPhone { get => cellPhone; set => cellPhone = value; }
        public string CellPhonePrefix { get => cellPhonePrefix; set => cellPhonePrefix = value; }
        public string Country { get => country; set => country = value; }
        public string EMailAddress { get => eMailAddress; set => eMailAddress = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string PhonePrefix { get => phonePrefix; set => phonePrefix = value; }
        public string Place { get => place; set => place = value; }
        public string Town { get => town; set => town = value; }
        public string Zip { get => zip; set => zip = value; }
        #endregion
    }

}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ester.Tutorial.Core;

namespace Ester.Tutorial.GUI
{
    /// <summary>
    /// Interaction logic for UpdateSubscriberWindow.xaml
    /// </summary>
    public partial class UpdateSubscriberWindow : Window
    {
        #region Fields
        Window callWindow = new Window();
        ObservableCollection<Subscriber> callBizz = new ObservableCollection<Subscriber>();
        private string subscriberID;
        #endregion

        #region Window
        public UpdateSubscriberWindow(object w, object b, string id)
        {
            InitializeComponent();
            callWindow = (Window)w;
            callBizz = (ObservableCollection<Subscriber>)b;
            subscriberID = id;
            UpdateTextBoxes(subscriberID, callBizz);
        }
        #endregion

        #region Buttons
        private void ButtonUpdateSubscriber_Click(object sender, RoutedEventArgs e)
        {
            {
                if (textBoxName.Text != "" && textBoxAddress.Text != "" && textBoxZip.Text != "" && textBoxTown.Text != "" && textBoxCountry.Text != "")
                {
                    Subscriber newSub = new Subscriber();
                    newSub.SubscriberNumber = textBoxSubscriberNumber.Text;
                    newSub.Name = textBoxName.Text;
                    newSub.Address = textBoxAddress.Text;
                    newSub.Place = textBoxPlace.Text;
                    newSub.Zip = textBoxZip.Text;
                    newSub.Town = textBoxTown.Text;
                    newSub.PhonePrefix = textBoxPhonePrefix.Text;
                    newSub.Phone = textBoxPhone.Text;
                    newSub.CellPhonePrefix = textBoxCellPhonePrefix.Text;
                    newSub.CellPhone = textBoxCellPhone.Text;
                    newSub.EMailAddress = textBoxEMail.Text;
                    (callWindow as MainWindow).UpdateExistingSubscriber(newSub);
                    UpdateTextBoxes(newSub);
                }
                else
                {
                    MessageBox.Show("Navn, Adresse, Postnr., By & Land skal udfyldes.");
                }
            }
        }
        #endregion

        #region Methods
        private void UpdateTextBoxes(string s, ObservableCollection<Subscriber> subs)
        {
            Subscriber sub = GetSubscriber(s, subs);
            textBoxSubscriberNumber.Text = sub.SubscriberNumber;
            textBoxName.Text = sub.Name;
            textBoxAddress.Text = sub.Address;
            textBoxPlace.Text = sub.Place;
            textBoxZip.Text = sub.Zip;
            textBoxTown.Text = sub.Town;
            textBoxPhonePrefix.Text = sub.PhonePrefix;
            textBoxPhone.Text = sub.Phone;
            textBoxCellPhonePrefix.Text = sub.CellPhonePrefix;
            textBoxCellPhone.Text = sub.CellPhone;
            textBoxCountry.Text = sub.Country;
            textBoxEMail.Text = sub.EMailAddress;
        }
        private void UpdateTextBoxes(Subscriber sub)
        {
            textBoxSubscriberNumber.Text = sub.SubscriberNumber;
            textBoxName.Text = sub.Name;
            textBoxAddress.Text = sub.Address;
            textBoxPlace.Text = sub.Place;
            textBoxZip.Text = sub.Zip;
            textBoxTown.Text = sub.Town;
            textBoxPhonePrefix.Text = sub.PhonePrefix;
            textBoxPhone.Text = sub.Phone;
            textBoxCellPhonePrefix.Text = sub.CellPhonePrefix;
            textBoxCellPhone.Text = sub.CellPhone;
            textBoxCountry.Text = sub.Country;
            textBoxEMail.Text = sub.EMailAddress;
        }
        private Subscriber GetSubscriber(string s, ObservableCollection<Subscriber> subs)
        {
            Subscriber subr = new Subscriber();
            foreach (Subscriber su in subs)
            {
                if (su.SubscriberNumber == s)
                {
                    subr = su;
                }
            }
            return subr;
        }
        #endregion

        #region Properties
        public string SubscriberID { get => subscriberID; set => subscriberID = value; }
        #endregion

    }
}

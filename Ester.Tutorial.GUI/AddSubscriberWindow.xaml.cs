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
    /// Interaction logic for AddSubscriberWindow.xaml
    /// </summary>
    public partial class AddSubscriberWindow : Window
    {
        #region Fields
        Window callWindow = new Window();
        Subscriber newSub = new Subscriber();
        private int nextSubscriberId;
        #endregion

        #region window
        public AddSubscriberWindow(object w, int next)
        {
            InitializeComponent();
            callWindow = (Window)w;
            nextSubscriberId = next;
            textBoxSubscriberNumber.Text = nextSubscriberId.ToString();
        }
        #endregion

        #region Buttons
        private void ButtonCreateNew_Click(object sender, RoutedEventArgs e)
        {
            {
                if (textBoxName.Text != "" && textBoxAddress.Text != "" && textBoxZip.Text != "" && textBoxTown.Text != "" && textBoxCountry.Text != "")
                {
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
                    (callWindow as MainWindow).AddSubscriber(newSub);
                    nextSubscriberId = nextSubscriberId + 1;
                    textBoxSubscriberNumber.Text = nextSubscriberId.ToString();
                    textBoxName.Text = "";
                    textBoxAddress.Text = "";
                    textBoxPlace.Text = "";
                    textBoxZip.Text = "";
                    textBoxTown.Text = "";
                    textBoxPhonePrefix.Text = "";
                    textBoxPhone.Text = "";
                    textBoxCellPhonePrefix.Text = "";
                    textBoxCellPhone.Text = "";
                    textBoxEMail.Text = "";
                }
                else
                {
                    MessageBox.Show("Navn, Adresse, Postnr., By & Land skal udfyldes.");
                }
            }
        }
        #endregion

        #region Properties
        public int NextSubscriberId { get => nextSubscriberId; set => nextSubscriberId = value; }
        #endregion
    }
}

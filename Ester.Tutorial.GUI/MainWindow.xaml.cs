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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ester.Tutorial.Core;
using Ester.Tutorial.DataAccess;

namespace Ester.Tutorial.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        Window callWindow = new Window();
        ObservableCollection<Subscriber> subscribers = new ObservableCollection<Subscriber>();
        ObservableCollection<Subscription> subscriptions = new ObservableCollection<Subscription>();
        ObservableCollection<Comment> comments = new ObservableCollection<Comment>();
        private string currentUser;
        private int nextSubscriberId = 400004;
        GUIMockUpDb MWMD = new GUIMockUpDb();
        #endregion

        #region Window
        public MainWindow(object w, string user)
        {
            InitializeComponent();
            callWindow = (Window)w;
            currentUser = user;
            subscriptions = MWMD.MockUpSubscriptionDB();
            comments = MWMD.MockUpCommentsDB();
            subscribers = MWMD.MockUpSubscriberDB();
            dataGridSubscriptions.ItemsSource = subscriptions;
            dataGridComments.ItemsSource = comments;
        }
        #endregion

        #region Buttons
        private void ButtonAbonnementskørsler_Click(object sender, RoutedEventArgs e)
        {
            ExecutionWindow ew = new ExecutionWindow(this);
            ew.Activate();
            ew.Owner = this;
            System.Threading.Thread.Sleep(5000);
            ew.Show();
        }
        private void ButtonCreateNew_Click(object sender, RoutedEventArgs e)
        {
            AddSubscriberWindow asw = new AddSubscriberWindow(this, nextSubscriberId);
            asw.Activate();
            asw.Owner = this;
            asw.Show();
        }
        private void ButtonDoer_Click(object sender, RoutedEventArgs e)
        {
            callWindow.Show();
            this.Close();
        }
        private void ButtonRegistrationDraft_Click(object sender, RoutedEventArgs e)
        {
            DraftWindow dw = new DraftWindow(this, subscribers);
            dw.Activate();
            dw.Show();
        }
        private void ButtonTypeComment_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxComment.Text != "")
            {
                Comment com = new Comment(textBoxComment.Text, currentUser);
                comments.Add(com);
                textBoxComment.Text = "";
            }
            else
            {
                MessageBox.Show("Der er ikke indtastet nogen bemærkning.");
            }
        }
        private void ButtonUpdateSubscriber_Click(object sender, RoutedEventArgs e)
        {
            UpdateSubscriberWindow usw = new UpdateSubscriberWindow(this, subscribers, textBoxSubscriberNumber.Text);
            usw.Activate();
            usw.Owner = this;
            usw.Show();
        }
        #endregion

        #region Events
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            callWindow.Show();
        }
        private void TextBoxSubscriberNumber_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SearchWindow1 sw = new SearchWindow1(this);
            sw.Activate();
            sw.Owner = this;
            sw.Show();
        }
        #endregion

        #region Methods
        public void AddSubscriber(Subscriber sub)
        {
            try
            {
                foreach (Subscriber s in subscribers)
                {
                    if (s.Name == sub.Name || s.Address == sub.Address || s.Zip == sub.Zip)
                    {
                        string message = "Ny Abonnent:" + Environment.NewLine + sub.ToString() + Environment.NewLine + Environment.NewLine + "Eksisterende Abonnent:" + Environment.NewLine + s.ToString() + Environment.NewLine + Environment.NewLine + "Prøver du at opdatere denne existerende abonnent?";
                        System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(message, "Tilføj eller Opdater", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            sub.SubscriberNumber = s.SubscriberNumber;
                            UpdateExistingSubscriber(sub);
                            return;
                        }
                    }
                    subscribers.Add(sub);
                    UpdateTextBoxes(sub);
                    MessageBox.Show("Abonnent tilføjet");
                    nextSubscriberId = nextSubscriberId + 1;
                }
            }
            catch (Exception)
            {
            }
        }
        public void CheckSearchResult(string num)
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                if (subscribers[i].SubscriberNumber == num)
                {
                    UpdateTextBoxes(subscribers[i]);
                    return;
                }
            }
            MessageBox.Show("Søgningen gav intet resultat.");
        }
        public void UpdateExistingSubscriber(Subscriber sub)
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                if (subscribers[i].SubscriberNumber == sub.SubscriberNumber)
                {
                    subscribers[i] = sub;
                    UpdateTextBoxes(subscribers[i]);
                    MessageBox.Show("Abonnent opdateret");
                    return;
                }
            }

            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Abonnenten blev ikke fundet. Ønsker du i stedet at tilføje som ny abonnent?", "Tilføj eller Opdater", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                AddSubscriber(sub);
            }
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
        #endregion

        #region Properties
        public int NextSubscriberId { get => nextSubscriberId; set => nextSubscriberId = value; }
        #endregion

    }
}

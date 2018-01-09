using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for DraftWindow.xaml
    /// </summary>
    public partial class DraftWindow : Window
    {
        #region Fields
        Window callWindow = new Window();
        ObservableCollection<Draft> drafts = new ObservableCollection<Draft>();
        ObservableCollection<Subscriber> callBizz = new ObservableCollection<Subscriber>();
        #endregion

        #region Window
        public DraftWindow(object w, ObservableCollection<Subscriber> sub)
        {
            InitializeComponent();
            callBizz = sub;
            callWindow = (Window)w;
            dataGridDrafts.DataContext = drafts;
            dataGridDrafts.ItemsSource = drafts;
        }
        #endregion

        #region Buttons
        private void ButtonAccounting_Click(object sender, RoutedEventArgs e)
        {
            if (drafts.Count > 0)
            {
                MessageBox.Show("Ønsker du at udskrive bilag?");
                MessageBox.Show("Ønsker du at bogføre nu?");
                System.Diagnostics.Process.Start(@"C:\CodeMappe\S2\Ester.Tutorial\Ester.Tutorial.GUI\Properties\templatekassekladde.pdf");
                drafts.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Der er ingen poster at bogføre.");
            }
        }

        private void ButtonAddRow_Click(object sender, RoutedEventArgs e)
        {
            AddTextBoxDataToDrafts();
            ClearTextBoxes();
        }
        #endregion

        #region Events
        private void DataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Sadman");
            //TextboxUpdate(dataGrid, switchActivated);
            //buttonSave.IsEnabled = false;
            //buttonEdit.IsEnabled = true;
        }
        private void TextBoxSubscriberNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (Subscriber s in callBizz)
            {
                if (textBoxSubscriberNumber.Text == s.SubscriberNumber)
                {
                    textBoxName.Text = s.Name;
                    break;
                }
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        //public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        private void AddTextBoxDataToDrafts()
        {
            Draft d = new Draft(textBoxSubscriberNumber.Text, textBoxName.Text, textBoxInvoiceNumber.Text, textBoxNote.Text, Convert.ToDouble(textBoxBeloeb.Text));
            drafts.Add(d);
        }
        private void ClearTextBoxes()
        {
            textBoxSubscriberNumber.Text = "";
            textBoxName.Text = "";
            textBoxInvoiceNumber.Text = "";
            textBoxNote.Text = "";
            textBoxBeloeb.Text = "";
        }
        #endregion
    }
}

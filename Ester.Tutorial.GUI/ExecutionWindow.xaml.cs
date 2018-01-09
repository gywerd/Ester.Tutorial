using System;
using System.Collections.Generic;
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

namespace Ester.Tutorial.GUI
{

    /// <summary>
    /// Interaction logic for ExecutionWindow.xaml
    /// </summary>
    public partial class ExecutionWindow : Window
    {
        #region Fields
        string vejledning = "Rækkefølge Fakturaer:" + Environment.NewLine + "1) Faktura Mail og Brev" + Environment.NewLine + "2) Forlængelser" + Environment.NewLine + "3) Faktura Mail og Brev" + Environment.NewLine + "4) Rykkere";
        Window callWindow = new Window();
        bool mailPressed = false;
        #endregion

        #region Window
        public ExecutionWindow(object w)
        {
            InitializeComponent();
            callWindow = (Window)w;
            textboxOrderOfExecution.Text = vejledning;
        }
        #endregion

        #region Buttons
        private void ButtonDoer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonInvoice_Click(object sender, RoutedEventArgs e)
        {
            if (mailPressed && Convert.ToInt32(textBoxInvoice.Text) > 0)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Ønsker du at udskrive faktura?", "Lav Faktura", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Threading.Thread.Sleep(5000);
                    MessageBox.Show("Nu skal der være fortrykt papir i printeren.");
                    System.Threading.Thread.Sleep(5000);
                    textBoxInvoice.Text = "0";

                }
            }
            else if (!mailPressed && Convert.ToInt32(textBoxInvoice.Text) > 0)
            {
                MessageBox.Show("Du skal først maile fakturaer.");
            }
            else
            {
                MessageBox.Show("Der er ingen fakturaer at sende");
            }
        }
        private void ButtonMailInvoice_Click(object sender, RoutedEventArgs e)
        {
            if (!mailPressed && Convert.ToInt32(textBoxInvoice.Text) > 0)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Ønsker du at udskrive faktura?", "Lav Faktura", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Threading.Thread.Sleep(15000);
                    textBoxInvoice.Text = "3";
                    mailPressed = true;
                }
            }
            else
            {
                MessageBox.Show("Der er ingen fakturaer at sende");
            }
        }
        private void ButtonProlonging_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxInvoice.Text == "0" && Convert.ToInt32(textBoxProlonging.Text) > 0)
            {
                System.Threading.Thread.Sleep(5000);
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Ønsker du at forlænge abonnement?", "Forlængelse af abonnement", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Threading.Thread.Sleep(5000);
                    textBoxProlonging.Text = "0";
                    textBoxInvoice.Text = "5";
                }
            }
            else
            {
                MessageBox.Show("Du skal først fakturere klargjorte ordrer.");
            }
        }
        private void ButtonReminder_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProlonging.Text == "0" && textBoxInvoice.Text == "0" && Convert.ToInt32(textBoxReminder.Text) > 0)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Ønsker du at lave rykkere?", "Lav Rykkere", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Threading.Thread.Sleep(5000);
                    System.Windows.Forms.DialogResult result2 = System.Windows.Forms.MessageBox.Show("Ønsker du at udskrive bilag?", "Udskriv bilag", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                    if (result2 == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Threading.Thread.Sleep(5000);
                        textBoxReminder.Text = "0";
                    }
                }
            }
            else if (textBoxProlonging.Text != "0" || textBoxInvoice.Text != "0" && Convert.ToInt32(textBoxReminder.Text) > 0)
            {
                MessageBox.Show("Du skal udsende fakturaer, før du laver rykkere.");
            }
            else
            {
                MessageBox.Show("Der er ingen rykkere at sende.");
            }

        }
        private void ButtonRepInvoice_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonRepReminder_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonShow1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonShow2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonShow3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonShow4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonShow5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(textBoxStop.Text) > 0)
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Ønsker du at køre en stopkørsel ?", "Stopkørsel", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Threading.Thread.Sleep(5000);
                    System.Windows.Forms.DialogResult result2 = System.Windows.Forms.MessageBox.Show("Er stopkørselbilag printet", "Udskriv bilag", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
                    if (result2 == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Threading.Thread.Sleep(5000);
                        textBoxStop.Text = "0";
                    }
                }
            }
            else
            {
                MessageBox.Show("Der er ingen abonnementer at stoppe.");
            }

        }
        #endregion
    }
}

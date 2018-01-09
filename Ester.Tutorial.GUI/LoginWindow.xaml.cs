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
using Ester.Tutorial.DataAccess;


namespace Ester.Tutorial.GUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        #region Fields
        ObservableCollection<UserCredentials> users = new ObservableCollection<UserCredentials>();
        GUIMockUpDb GMUD = new GUIMockUpDb();
        #endregion

        #region Window
        public LoginWindow()
        {
            InitializeComponent();
            users = GMUD.MockUpCredentialsDB();
        }
        #endregion

        #region Buttons
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            if (UserCredentials.IsValid(textBoxBruger.Text, passwordBoxAdgangskode.Password, users))
            {
                MainWindow main = new MainWindow(this, UserCredentials.GetUser(textBoxBruger.Text, users));
                main.Activate();
                passwordBoxAdgangskode.Password = "";
                this.Hide();
                main.Show();
            }
            else
            {
                System.Windows.MessageBox.Show("Forkert brugernavn eller adgangskode");
            }
        }
        #endregion

        #region Events
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
        }
        #endregion

    }
}

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
    /// Interaction logic for SearchWindow1.xaml
    /// </summary>
    public partial class SearchWindow1 : Window
    {
        #region Fields
        Window callWindow = new Window();
        private string returnValue1;
        #endregion

        #region Window
        public SearchWindow1(object w)
        {
            InitializeComponent();
            callWindow =(Window)w;
        }
        #endregion

        #region Buttons
        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            this.returnValue1 = textBoxSubscriberNumber.Text;
            (callWindow as MainWindow).CheckSearchResult(returnValue1);
            this.Close();
        }
        #endregion

        #region Methods
        #endregion

        #region Properties
        public string ReturnValue1 { get => returnValue1; }
        #endregion
    }
}

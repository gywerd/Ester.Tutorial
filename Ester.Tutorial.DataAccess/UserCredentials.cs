using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ester.Tutorial.DataAccess
{
    public class UserCredentials
    {
        #region Field
        private string userName;
        private string password;
        private string userInitials;
        #endregion

        #region Constructors
        public UserCredentials() { }
        public UserCredentials(string user, string pass, string init = "")
        {
            this.userName = user;
            this.password = pass;
            this.userInitials = init;
        }
        #endregion

        #region Methods
        public static bool IsValid(string user, string pass, ObservableCollection<UserCredentials> users)
        {
            UserCredentials userc = new UserCredentials(user, pass);
            bool ret = false;
            foreach (UserCredentials usercs in users)
            {
                if (userc.UserName.Equals(usercs.UserName) && userc.Password.Equals(usercs.Password))
                {
                    ret = true;
                    return ret;
                }
             }
            return ret;
        }

        public static string GetUser(string name, ObservableCollection<UserCredentials> users)
        {
            foreach (UserCredentials u in users)
            {
                if (u.UserName.Equals(name))
                {
                    return u.UserInitials;
                }
            }
            return "";
        }
        #endregion

        #region Properties
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string UserInitials { get => userInitials; set => userInitials = value; }
        #endregion
    }
}

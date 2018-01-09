using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ester.Tutorial.Core;

namespace Ester.Tutorial.DataAccess
{
    public class GUIMockUpDb
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Events

        #endregion

        #region Methods
        public ObservableCollection<Comment> MockUpCommentsDB()
        {
            ObservableCollection<Comment> com = new ObservableCollection<Comment>();
            Comment com1 = new Comment(new DateTime(2017, 2, 3), "Genoprettet abonnement", "TH");
            Comment com2 = new Comment(new DateTime(2015, 1, 6), "Genuds U52 ub - mail til PP - kd er utilfreds", "DG");
            Comment com3 = new Comment(new DateTime(2015, 1, 2), "U52 ub - mail til PP", "DG");
            Comment com4 = new Comment(new DateTime(2014, 12, 3), "PBS opr jf tlf", "CH");
            com.Add(com1);
            com.Add(com2);
            com.Add(com3);
            com.Add(com3);
            return com;
        }
        public ObservableCollection<UserCredentials> MockUpCredentialsDB()
        {
            {
                ObservableCollection<UserCredentials> users = new ObservableCollection<UserCredentials>();
                UserCredentials user1 = new UserCredentials("Admin", "Admin", "ADM");
                UserCredentials user2 = new UserCredentials("Daniel", "0412", "DG");
                UserCredentials user3 = new UserCredentials("Troels", "1234", "TH");
                UserCredentials user4 = new UserCredentials("Kis", "1234", "KI");
                users.Add(user1);
                users.Add(user2);
                users.Add(user3);
                users.Add(user4);
                return users;
            }
        }
        public ObservableCollection<Subscriber> MockUpSubscriberDB()
        {
            ObservableCollection<Subscriber> sub = new ObservableCollection<Subscriber>();
            Subscriber sub1 = new Subscriber("400000", "Jens Pedersen", "Højgårdsvej 1", "8832", "Skals", "Denmark", "Neder Skringstrup", "+45", "86697777", "+45", "21436587", "jens@pedersen.mail.dk");
            Subscriber sub2 = new Subscriber("400001", "Peder Larsen", "Højgårdsvej 3", "8832", "Skals", "Denmark", "Neder Skringstrup", "+45", "86698888", "+45", "43658721", "peder@famlarsen.dk");
            Subscriber sub3 = new Subscriber("400002", "Lars Hansen", "Højgårdsvej 5", "8832", "Skals", "Denmark", "Neder Skringstrup", "+45", "86699999", "+45", "65872143", "hansen.lars@yahoo.dk");
            Subscriber sub4 = new Subscriber("400003", "Hans Jensen", "Højgårdsvej 7", "8832", "Skals", "Denmark", "Neder Skringstrup", "+45", "86690000", "+45", "87214365", "hans.jensen@gmail.com");
            sub.Add(sub1);
            sub.Add(sub2);
            sub.Add(sub3);
            sub.Add(sub3);
            return sub;
        }
        public ObservableCollection<Subscription> MockUpSubscriptionDB()
        {
            ObservableCollection<Subscription> sub = new ObservableCollection<Subscription>();
            Subscription sub1 = new Subscription("Perioderegulering", "TH", "03-02-2017", "02-12-2017", "0,00", "2");
            Subscription sub2 = new Subscription("Normal Helårlig", "sys", "03-12-2016", "02-12-2017", "623,00", "2", "03-12-2016", "31-01-2017", "02-01-2017", "31-01-2017");
            Subscription sub3 = new Subscription("Normal Helårlig", "sys", "03-12-2015", "02-12-2016", "623,00", "2", "03-12-2016", "02-12-2016");
            Subscription sub4 = new Subscription("Normal Helårlig", "ADM", "03-12-2014", "02-12-2015", "623,00", "2", "03-12-2015", "30-11-2015");
            sub.Add(sub1);
            sub.Add(sub2);
            sub.Add(sub3);
            sub.Add(sub4);
            return sub;
        }
        #endregion

        #region Properties

        #endregion
    }
}

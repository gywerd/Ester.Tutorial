using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ester.Tutorial.Core
{
    public class Comment
    {
        #region Fields
        private string id;
        private DateTime commentTimeStamp = new DateTime();
        private string commentText;
        #endregion

        #region Constructors
        public Comment() { }
        public Comment(string text, string id)
        {
            this.commentTimeStamp = DateTime.Now;
            this.commentText = text;
            this.id = id;
        }
        public Comment(DateTime time, string text, string id)
        {
            this.commentTimeStamp = time;
            this.commentText = text;
            this.id = id;
        }
        public Comment(Comment c)
        {
            this.commentTimeStamp = c.Tidspunkt;
            this.commentText = c.Bemærkning;
            this.id = c.Id;
        }
        #endregion

        #region Events

        #endregion

        #region Methods

        #endregion

        #region Properties
        public string Id { get => id; set => id = value; }
        public DateTime Tidspunkt { get => commentTimeStamp; set => commentTimeStamp = value; }
        public string Bemærkning { get => commentText; set => commentText = value; }
        #endregion    }
    }
}
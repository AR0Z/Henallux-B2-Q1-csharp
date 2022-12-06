using System;
using System.Text;

namespace Labo2
{
    public class Post
    {
        #region attributes

        public const int INC_LIKEDBY_SIZE = 3;
        
        private User author;
        private string contents;
        private DateTime date;
        private User[] likedBy;

        #endregion

        #region constructors

        public Post(User author, string contents, DateTime date)
        {
            this.author = author;
            this.contents = contents;
            this.date = date;
            likedBy = new User[INC_LIKEDBY_SIZE];
            
            author.AddPost(this);
        }
        
        public Post(User author, string contents) : this(author, contents, DateTime.Now) {}

        #endregion

        public void AddLike(User user)
        {
            if (likedBy[likedBy.Length - 1] != null)
            {
                Array.Resize(ref likedBy, likedBy.Length + INC_LIKEDBY_SIZE);
            }

            likedBy[NbrLike] = user;
        }
        
        public void AddLike(params User[] userList)
        {
            Array.Resize(ref likedBy, likedBy.Length + userList.Length);
            Array.Copy(userList, 0, likedBy,NbrLike - 1, userList.Length);
        }

        public int NbrLike
        {
            get
            {
                int i = 0;

                while (likedBy[i] != null)
                {
                    i++;
                }

                return i;
            }
        }

        public string Contents
        {
            get
            {
                return contents;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(contents + " de " + author.Login + " le " + date + "\n like par : ");
            foreach (User user in likedBy)
            {
                output.Append(user?.Login + " ");
            }

            return output.ToString();
        }
    }
}
using System;

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
            author.AddPost();

            this.contents = contents;
            this.date = date;
            likedBy = new User[INC_LIKEDBY_SIZE];
        }
        
        public Post(User author, string contents) : this(author, contents, DateTime.Now) {}

        #endregion

        public void AddLike(User user)
        {
            
        }
    }
}
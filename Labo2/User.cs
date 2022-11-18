using System;

namespace Labo2
{
    public class User
    {
        #region attributes
        private string login;
        private int password;
        private DateTime joinDate;
        private int postCount = 0;
        private int spacesPosted = 0;
        private int digitsPosted = 0;
        #endregion

        #region constructors
        public User(string login, string password, DateTime joinDate)
        {
            this.login = login;
            Password = password;
            this.joinDate = joinDate;
        }
        
        public User(string login, string password) : this(login, password, DateTime.Now) { }
        
        public User(string login, string password, int dateAAAAMMJJ) : this(login, password, DateTime.ParseExact(dateAAAAMMJJ.ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)) {}
        #endregion

        public void AddPost(Post post)
        {
            // spaceCount;
            //int digitCount;
            //ForumUtils.Count(post.Contents, out spaceCount, out digitCount);
            //spacesPosted += spaceCount;
            //digitsPosted += digitCount;

            ForumUtils.CountAndUpdate(post.Contents, ref spacesPosted, ref digitsPosted); 
            postCount++;
        }

        public bool ValidatePassword(string password)
        {
            return this.password == Encode(password);
        }

        public int Encode(string password)
        {
            int sommeChar = 0;
            foreach (char character in password)
            {
                sommeChar += character;
            }

            return sommeChar % 997;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (ForumUtils.ValidLogin(value))
                    login = value;
            }
        }

        public string JoinDate
        {
            get
            {
                return joinDate.ToString("yyyymmdd");
            }
            set
            {
                joinDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        
        public int PostCount
        {
            get
            {
                return postCount;
            }
        }

        public String Password
        {
            set
            {
                password = Encode(value);
            }
        }
        public override string ToString()
        {
            return Login + "(password: " + password + "), " + JoinDate + " - " + postCount + " post" + (postCount >= 2 ? "s ":" ") + spacesPosted + " space" + (spacesPosted >= 2 ? "s ":" ") + digitsPosted + " digit" + (digitsPosted >= 2 ? "s ":" ");
        }
    }
}
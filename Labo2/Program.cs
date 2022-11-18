using System;

namespace Labo2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User("Aroz", "test");
            Post post1 = new Post(user1, "test");

            User user2 = new User("Aroz2", "test");
            User user3 = new User("Aroz3", "test");
            User user4 = new User("Aroz4", "test");

            post1.AddLike(user1);
            post1.AddLike(user2);
            post1.AddLike(user3);
            post1.AddLike(user4);

            User u1 = new User("u1", "u1");
            User u2 = new User("u2", "u2");
            User u3 = new User("u3", "u3");
            User u4 = new User("u4", "u4");
            
            post1.AddLike(u1,u2,u3,u4);

            Console.WriteLine(post1);
            
            User u = new User("Mélusine", "12345");
            // 0 post, 0 space, 0 digit
            Console.WriteLine(u);
            Post p1 = new Post(u, "Un deux trois");
            // 1 post, 2 spaces, 0 digit
            Console.WriteLine(u);
            Post p2 = new Post(u, "456");
            // 2 posts, 2 spaces, 3 digits
            Console.WriteLine(u);
        }
        
        static void AssertBool (string test, bool expected, bool observed)
        {
            Console.WriteLine("Test: " + test);
            Console.WriteLine("Expected: " + expected + ", observed: " + observed);
            Console.WriteLine(expected == observed ? "Ok!" : "KO !!!");
            Console.WriteLine();
        }
        static void TestValidLogin()
        {
            AssertBool("Herbert", true, ForumUtils.ValidLogin("Herbert"));
            AssertBool("empty string", false, ForumUtils.ValidLogin(""));
            AssertBool("fart", false, ForumUtils.ValidLogin("fart"));
            AssertBool("FART", false, ForumUtils.ValidLogin("FART"));
            AssertBool("FaRt", false, ForumUtils.ValidLogin("FaRt"));
        }
    }
}
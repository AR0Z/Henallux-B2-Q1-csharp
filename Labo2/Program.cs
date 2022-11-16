using System;

namespace Labo2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User("aroz", "test");
            Post post1 = new Post(user1, "test");
            
            post1.AddLike(user1);
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
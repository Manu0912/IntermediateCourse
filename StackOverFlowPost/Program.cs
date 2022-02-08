using StackOverFlow;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StackOverflowPost stackOverflowPost = new();
            int option = 0;
            string flag = "s";

            while(flag == "s")
            {
                Console.WriteLine("Like or Dislike? 0/1");
                option = Int32.Parse(Console.ReadLine());
                if (option == 0)
                {
                    stackOverflowPost.GiveLike();
                }
                else
                {
                    stackOverflowPost.GiveDislike();
                }

                Console.WriteLine("Continue? s/n");
                flag = Console.ReadLine();
            }

            Console.WriteLine("Likes: " + stackOverflowPost.Likes);
            Console.WriteLine("Dislikes: " + stackOverflowPost.Dislikes);
            
        }

    }
}
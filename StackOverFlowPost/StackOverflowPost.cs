using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{
    public class StackOverflowPost
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime CreationDate;
        public int Likes { get; private set; }
        public int Dislikes { get; private set; }

        public StackOverflowPost()
        {
            CreationDate = DateTime.Now;
            Likes = 0;
            Dislikes = 0;
        }

        public StackOverflowPost(string title, string description)
        {
            CreationDate = DateTime.Now;
            Title = title;
            Description = description;
            Likes = 0;
            Dislikes = 0;
        }

        public void GiveLike()
        {
            Likes++;
        }

        public void GiveDislike()
        {
            Dislikes++;
        }

    }
}

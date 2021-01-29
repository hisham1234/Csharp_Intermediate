using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow
{

    public class Post
    {
        private int vote;
        public string Title { get; set; }

        public void UpVote()
        {
            vote += 1;
        }

        public void DownVote()
        {
            vote -= 1;
        }
        public int getVote()
        {
            return vote;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post { Title = "test" };
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            
            Console.WriteLine(post.getVote() );
        }
    }
}

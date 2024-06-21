using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime _data { get; set; }

        string key;
        int up = 3;
        int down = 7;   
        public void Content(string title, string description)
        {
            Title = title;
            Description = description;
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            _data = DateTime.Now;
            Console.WriteLine(_data);
            Console.WriteLine("--------------current votes---------------");
            Console.WriteLine("up-votes:"+up+" down-votes:"+down);
            Console.WriteLine();
            Console.WriteLine("Press 'u' for up-vote or 'd' for down-vote");
            string key = Console.ReadLine();
            if (key == "u")
            {
                up++;
            }
            else if (key == "d")
            {
                down++;
            }
            Console.WriteLine("--------------current votes---------------");
            Console.WriteLine("up-votes:" + up + "  down-votes:" + down);
            


        }
       

    }
}

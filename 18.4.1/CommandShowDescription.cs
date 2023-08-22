using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Converter;

namespace _18._4._1
{
    public class CommandShowDescription : Command
    {
        public override async void Run()
        {
            Console.WriteLine("Enter video id:");
            string id = Console.ReadLine();
            if (id != null)
            {
                var client = new YoutubeExplode.YoutubeClient();
                var info = client.Videos.GetAsync(id);
                Console.WriteLine(info.Result);
            }
            else
            {
                Console.WriteLine($"Something wrong with entered video id!");
            }
        }

        public override void Cancel()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace _18._4._1
{
    public class CommandDownloadFile : Command
    {
        public override async void Run()
        {
            Console.WriteLine("Enter video id:");
            string id = Console.ReadLine();
            if (id != null)
            {
                string outputFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var client = new YoutubeExplode.YoutubeClient();
                try
                {
                    await client.Videos.DownloadAsync(id, outputFilePath);
                    Console.WriteLine("Download started");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
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

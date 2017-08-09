using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Football> ballclub = new Dictionary<int, Football>();

            Football fb1 = new Football();
            fb1.TeamId = 1000;
            fb1.TeamName = "Browns";
            fb1.Division = "North";
            fb1.Conference = "AFC";
            fb1.NetWorth = 1000000;

            Football fb2 = new Football();
            fb2.TeamId = 2000;
            fb2.TeamName = "Colts";
            fb2.Division = "South";
            fb2.Conference = "AFC";
            fb2.NetWorth = 2000000;

            ballclub.Add(fb1.TeamId, fb1);
            ballclub.Add(fb2.TeamId, fb2);

            foreach (var item in ballclub)
            {
                Football kick = item.Value;
                kick.PrintClub2();

            }
            Console.ReadLine();

            foreach (KeyValuePair<int, Football> item in ballclub)
            {
                Football fb = item.Value;
                fb.PrintClub();

            }

            Console.ReadLine();
            
        }
    }
}

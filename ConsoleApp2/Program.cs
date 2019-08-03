using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Client = new Client();
            //Console.WriteLine("ClientID:");
            //string clientID = Console.ReadLine();
            //Console.WriteLine("ClientPW:");
            //string clientPW = Console.ReadLine();
            Client.Connect("x", "y");
            Visuals.VisualPlay visualPlay = new Visuals.VisualPlay(Client.Instance);
            visualPlay.ShowDialog();
            

            //Console.Read();
            //Client.SendCMD("play:10000.6");
            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    Client.SendCMD(s);
            //}
        }
    }
}

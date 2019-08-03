using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientServerCommonLibrary;
using PokerClient;

namespace ConsoleApp2.Visuals
{
    
    public partial class Table : Form
    {

        bool init = false;
        public Table()
        {
            InitializeComponent();
            timer1.Start();
        }
        int initSeat = 0;
        public int NextSeat()//TODO: MODIFI TO 2 -> 6-9 seats
        {
            initSeat++;
            {
                if(initSeat > 5)
                {
                    initSeat = 0;
                }
            }
            return initSeat;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
                initSeat = Client.Instance.tableSeat;
                seat5.clientID = NextSeat();
                seat6.clientID = NextSeat();               
                seat1.clientID = NextSeat();
                seat2.clientID = NextSeat();
                seat3.clientID = NextSeat();
            
            
            //seat1.clientID = Client.Instance.tableSeat + -3;
            //TODO: REFRESH TABLE ONLINE...
            //OR INITIALIZE AND REFRESH WHIT CLIENTI DATA...
        }

        private void Table_Load(object sender, EventArgs e)
        {
            PokerClient.Table.Clienti.Add(new ClientBase());
            PokerClient.Table.Clienti.Add(new ClientBase());
            PokerClient.Table.Clienti.Add(new ClientBase());
            PokerClient.Table.Clienti.Add(new ClientBase());
            PokerClient.Table.Clienti.Add(new ClientBase());
            PokerClient.Table.Clienti.Add(new ClientBase());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2.Visuals
{
    public partial class Seat : UserControl
    {
        public int clientID = 0;
        public Seat()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            label1.Text = PokerClient.Table.Clienti[clientID]?.Name;
            panel1.Visible = (bool)PokerClient.Table.Clienti[clientID]?.isTurn;
            label2.Text = PokerClient.Table.Clienti[clientID]?.onhandBet.ToString();
            //label1.Text = PokerClient.Table.Clienti[clientID]?.card1.to;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

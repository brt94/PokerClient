using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokerClient;

namespace ConsoleApp2.Visuals
{
    public partial class PlayerSeat : UserControl
    {
        public PlayerSeat()
        {
          
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Enabled = Client.Instance.isTurn;
            button4.Visible = !Client.Instance.isActive;
            //if (masa.bigBet > masa.tableConfig.bigblind)
            trackBar1.Minimum = 50; //Client.Instance.bigBet + Client.Instance.tableConfig.bigblind;
            trackBar1.Maximum = 10000;//Client.Instance..Money;
            //var call =  masa.bigBet - client.onhandBet;
            //if (call == 0)
            //{
            //    button1.Visible = false;
            //    button2.Text = "CHECK";
            //}
            //else
            //{
            //    button1.Visible = true;
            //    button2.Text = "CALL(" + (masa.bigBet - client.onhandBet) + ")";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.Fold();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // if (client != null)
                Client.Call(Client.Instance.tablebigBet - Client.Instance.onhandBet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (client != null)
            Client.Bet(trackBar1.Value - Client.Instance.onhandBet);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button3.Text = "Bet(" + trackBar1.Value + ")";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client.SetActive();
        }
    }
}

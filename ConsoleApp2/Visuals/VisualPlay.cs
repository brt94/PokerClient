using PokerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2.Visuals
{
    public partial class VisualPlay : Form
    {
        ClientServerCommonLibrary.ClientBase self;
        public VisualPlay(ClientServerCommonLibrary.ClientBase instance)
        {
            self = instance;
            InitializeComponent();
        }

        private void VisualPlay_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = self?.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Client.SendCMD("play:10000.6");
            Table table = new Table();
            table.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.SendCMD("changename:"+textBox1.Text+":");
        }
    }
}

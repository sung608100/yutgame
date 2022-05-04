using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace yutgame
{
    public partial class Form1 : Form
    {
        int num;

        bool is_server = false;

        Socket server_socket;

        Dictionary<string, Socket> connected_clients = new Dictionary<string, Socket>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int yutnum = rand.Next(16);
            if(yutnum == 1) // 빽도
            {
                num = -1;
            }
            else if (1 < yutnum && yutnum <= 4) //도
            {
                num = 1;
            }
            else if (4 < yutnum && yutnum <= 10) //개
            {
                num = 2;
            }
            else if (10 < yutnum && yutnum <= 14)
            {
                num = 3;
            }
            else if (14 < yutnum && yutnum <= 15)
            {
                num = 4;
            }
            else if (yutnum == 16)
            {
                num = 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

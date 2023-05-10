using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPdenemesi77
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream=default(NetworkStream);
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCON_Click_1(object sender, EventArgs e)
        {
            clientSocket.Connect(txtIP.Text, Int32.Parse(txPORT.Text));
            Thread ctThread = new Thread(getMessage);
            ctThread.Start();

        }

        private void getMessage()
        {
            string returnData;
            while(true)
            {
                serverStream=clientSocket.GetStream();
                var buffsize = clientSocket.ReceiveBufferSize;
                byte[] instream=new byte[buffsize];
                serverStream.Read(instream,0,buffsize);
                returnData=System.Text.Encoding.ASCII.GetString(instream);
                this.Invoke(new MethodInvoker(delegate ()
                {
                    string[] datas = returnData.Split('*');
                    
                    txtIN.Text = datas[0];

                }));

            }
           
        }

        private void btnSEND_Click(object sender, EventArgs e)
        {
            byte[] outstream = Encoding.ASCII.GetBytes(txtSEND.Text);
            serverStream.Write(outstream, 0, outstream.Length);
            serverStream.Flush();
        }
    }
}

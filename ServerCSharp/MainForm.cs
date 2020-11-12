using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ServerCSharp
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {

        TcpListener listener;

        Thread tcpThread;

        public MainForm()
        {
            InitializeComponent();
            listener = new TcpListener(IPAddress.Any, 8000);

            ClientAccepted += listener_ClientAccepted;


            ThreadStart threadStart = new ThreadStart(AcceptClient);
            tcpThread = new Thread(threadStart);
        }

        private void RunServer()
        {
            try
            { 
                listener.Start();
                txtRunInfo.Text = "서버가 실행중입니다.";
            }
            catch (SocketException e)
            {
                txtRunInfo.Text = "서버실행 실패! 에러코드: " + e.SocketErrorCode;
            }
            tcpThread.Start();
        }

        private void AcceptClient()
        {
            TcpClient tcpClient = listener.AcceptTcpClient();
            ClientAccepted(tcpClient,EventArgs.Empty);
        }

        private void StopServer()
        {
            listener.Stop();
            txtRunInfo.Text = "서버실행을 중단하였습니다.";
        }


        #region 이벤트

        private event EventHandler ClientAccepted;

        private void listener_ClientAccepted(object sender, EventArgs e)
        {
            //txtClientResult
        }

        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            RunServer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();
        }
    }
}
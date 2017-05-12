using Leap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapMotion_visualizer
{
    public partial class DataDisplayer : Form
    {
        private int frameCounter = 0;
        private Controller controller;
        //Declare and Initialize the IP Adress
        static IPAddress ipAd = IPAddress.Parse("172.17.2.89");
        //Declare and Initilize the Port Number;
        static int PortNumber = 8888;
        /* Initializes the Listener */
        TcpListener ServerListener = new TcpListener(ipAd, PortNumber);
        TcpClient clientSocket = default(TcpClient);

        public DataDisplayer(Controller c)
        {
            this.controller = c;
            InitializeComponent();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
        }

        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            
            Frame frame = eventArgs.frame;
            Hand rightHand = null;
            Hand leftHand = null;
            if (frame.Hands.Count > 0)
            {
                List<Hand> hands = frame.Hands;
                for (int i = 0; i < hands.Count; i++)
                {
                    if (hands[i].IsLeft)
                    {
                        leftHand = hands[i];
                    }
                    else
                    {
                        rightHand = hands[i];
                    }
                }
                if (true) { 
                    if (rightHand != null)
                    {
                        #region Right Hand Yaw, Pitch, Roll
                        float yaw = rightHand.Direction.Yaw;
                        float pitch = - rightHand.Direction.Pitch;
                        float roll = - rightHand.PalmNormal.Roll;

                        lblRightHand_yaw.Text = ToDegrees(yaw).ToString();
                        lblRightHand_roll.Text = ToDegrees(roll).ToString();
                        lblRightHand_pitch.Text = ToDegrees(pitch).ToString();
                        #endregion
                    }

                    if (leftHand != null)
                    {
                        #region Left Hand Yaw, Pitch, Roll
                        float yaw = leftHand.Direction.Yaw;
                        float pitch = -leftHand.Direction.Pitch;
                        float roll = -leftHand.PalmNormal.Roll;

                        lblLeftHand_yaw.Text = ToDegrees(yaw).ToString();
                        lblLeftHand_roll.Text = ToDegrees(roll).ToString();
                        lblLeftHand_pitch.Text = ToDegrees(pitch).ToString();
                        #endregion
                    }

                    frameCounter = 0;
                }

                frameCounter++;
            }
        }

        float ToDegrees(float Radian)
        {
            float Degrees;
            Degrees = Radian * 180 / (float)Math.PI;
            return Degrees;
        }

        private void THREAD_MOD(string teste)
        {
            txtStatus.Text += Environment.NewLine + teste;
        }

        private void btStartSocket_Click(object sender, EventArgs e)
        {
            Thread ThreadingServer = new Thread(StartServer);
            ThreadingServer.Start();
        }

        private void StartServer()
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            ServerListener.Start();
            Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
            clientSocket = ServerListener.AcceptTcpClient();
            Invoke(DelegateTeste_ModifyText, "Server ready!");

            while (true)
            {
                try
                {

                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[20];
                    networkStream.Read(bytesFrom, 0, 20);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    string serverResponse = "Received!";
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();

                }
                catch
                {
                    ServerListener.Stop();
                    ServerListener.Start();
                    Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
                    clientSocket = ServerListener.AcceptTcpClient();
                    Invoke(DelegateTeste_ModifyText, "Server ready!");
                }

            }
        }

        private void btStopSocket_Click(object sender, EventArgs e)
        {
            try
            {

                ServerListener.Stop();

            }
            catch
            {
                ServerListener.Stop();
                ServerListener.Start();
                Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
                clientSocket = ServerListener.AcceptTcpClient();
                Invoke(DelegateTeste_ModifyText, "Server ready!");
            }
        }
    }
}

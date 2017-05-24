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
using Eneter.Messaging.MessagingSystems.TcpMessagingSystem;
using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;

namespace LeapMotion_visualizer
{

    public partial class DataDisplayer : Form
    {
        private int frameCounter = 0;
        private Controller controller;
        //Declare and Initialize the IP Adress
        //static IPAddress ipAd = IPAddress.Parse("172.17.2.89");
        ////Declare and Initilize the Port Number;
        //static int PortNumber = 8888;
        ///* Initializes the Listener */
        //TcpListener ServerListener = new TcpListener(ipAd, PortNumber);
        //TcpClient clientSocket = default(TcpClient);
        private static IDuplexTypedMessageReceiver<MyResponse, MyRequest> myReceiver;
        TypedRequestReceivedEventArgs<MyRequest> e = null;

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
                        float yaw = ToDegrees(rightHand.Direction.Yaw);
                        float pitch = ToDegrees(- rightHand.Direction.Pitch);
                        float roll = ToDegrees(- rightHand.PalmNormal.Roll);

                        lblRightHand_yaw.Text = yaw.ToString();
                        lblRightHand_roll.Text = roll.ToString();
                        lblRightHand_pitch.Text = pitch.ToString();

                        if (e != null)
                        {
                            MyResponse aResponse = new MyResponse();
                            aResponse.Yaw = yaw;
                            aResponse.Pitch = pitch;
                            aResponse.Roll = roll;
                            // Send the response message back to the client.
                            myReceiver.SendResponseMessage(e.ResponseReceiverId, aResponse);
                        }
                        
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
            StartServer();
            //Thread ThreadingServer = new Thread(StartServer);
            //ThreadingServer.Start();
        }

        private void StartServer()
        {
            // Create message receiver receiving 'MyRequest' and receiving 'MyResponse'.
            IDuplexTypedMessagesFactory aReceiverFactory = new DuplexTypedMessagesFactory();
            myReceiver = aReceiverFactory.CreateDuplexTypedMessageReceiver<MyResponse, MyRequest>();

            // Subscribe to handle messages.
            myReceiver.MessageReceived += OnMessageReceived;

            // Create TCP messaging.
            IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory();
            IDuplexInputChannel anInputChannel =
               aMessaging.CreateDuplexInputChannel("tcp://0.0.0.0:8060/");

            // Attach the input channel and start to listen to messages.
            myReceiver.AttachDuplexInputChannel(anInputChannel);

            txtStatus.Text = ("The service is running. To stop press enter.");
            

            
            
        }

        // It is called when a message is received.
        private void OnMessageReceived(object sender, TypedRequestReceivedEventArgs<MyRequest> e)
        {
            this.e = e;
        }

        private void btStopSocket_Click(object sender, EventArgs e)
        {
            // Detach the input channel and stop listening.
            // It releases the thread listening to messages.
            myReceiver.DetachDuplexInputChannel();
        }
    }

    // Request message type
    public class MyRequest
    {
        public string Text { get; set; }
    }

    // Response message type
    public class MyResponse
    {
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public float Roll { get; set; }

    }
}

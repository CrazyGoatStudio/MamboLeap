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
using LeapMotion_visualizer.Modificadores;

namespace LeapMotion_visualizer
{

    public partial class DataDisplayer : Form
    {

        #region Variables 
        private int frameCounter = 0;
        private Controller controller;
        private static IDuplexTypedMessageReceiver<MyResponse, MyRequest> myReceiver;
        TypedRequestReceivedEventArgs<MyRequest> e = null;
        private bool isClientConnected;
        public DataDisplayer(Controller c)
        {
            this.controller = c;
            InitializeComponent();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            btStartSocket.Enabled = true;
            btStopSocket.Enabled = false;
        }
        #endregion

        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            #region Deteccion de manos
            Frame frame = eventArgs.frame;
            Hand rightHand = null;
            Hand leftHand = null;
            float yawR = 0, pitchR = 0, rollR = 0;
            float yawL = 0, pitchL = 0, rollL = 0;
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
                if (true)
                {
                    if (rightHand != null)
                    {
                        #region Right Hand Yaw, Pitch, Roll
                        yawR = ToDegrees(rightHand.Direction.Yaw);
                        pitchR = ToDegrees(-rightHand.Direction.Pitch);
                        rollR = ToDegrees(-rightHand.PalmNormal.Roll);

                        lblRightHand_yaw.Text = yawR.ToString();
                        lblRightHand_roll.Text = rollR.ToString();
                        lblRightHand_pitch.Text = pitchR.ToString();
                        #endregion
                    }

                    if (leftHand != null)
                    {
                        #region Left Hand Yaw, Pitch, Roll
                        yawL = ToDegrees(leftHand.Direction.Yaw);
                        pitchL = ToDegrees(- leftHand.Direction.Pitch);
                        rollL = ToDegrees(- leftHand.PalmNormal.Roll);

                        lblLeftHand_yaw.Text = yawL.ToString();
                        lblLeftHand_roll.Text = rollL.ToString();
                        lblLeftHand_pitch.Text = pitchL.ToString();
                        #endregion
                    }
                    DataSender(yawR, pitchR, rollR, yawL);
                    frameCounter = 0;
                }

                frameCounter++;
            }
            else
            {
                DataSender();
            }
            #endregion
        }

        #region Server Start/Buttons Server
        private void btStartSocket_Click(object sender, EventArgs e)
        {
            btStartSocket.Enabled = false;
            btStopSocket.Enabled = true;
            StartServer();
        }
        private void btStopSocket_Click(object sender, EventArgs e)
        {
            // Detach the input channel and stop listening.
            // It releases the thread listening to messages.
            btStartSocket.Enabled = true;
            btStopSocket.Enabled = false;
            txtStatus.Text = "Socket detenido correctamente!";
            myReceiver.DetachDuplexInputChannel();
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

            txtStatus.Text = ("The service is running.");
        }
        private void OnMessageReceived(object sender, TypedRequestReceivedEventArgs<MyRequest> e)
        {
            this.e = e;
            isClientConnected = true;
        }
        #endregion

        #region Configuraciones
        private void DataSender(float yaw = 0, float pitch = 0, float roll = 0, float yawL = 0)
        {
            if (e != null && isClientConnected)
            {
                try
                {
                    MyResponse aResponse = new MyResponse();
                    aResponse.Yaw = yaw;
                    aResponse.Pitch = pitch;
                    aResponse.Roll = roll;
                    aResponse.YawL = yawL;
                    // Send the response message back to the client.
                    myReceiver.SendResponseMessage(e.ResponseReceiverId, aResponse);
                }
                catch (Exception ex)
                {
                    ErrorHandler eh = new ErrorHandler(ex, "Conexion Interrumpida");
                    eh.Show();
                    isClientConnected = false;
                }


            }
        }
        float ToDegrees(float Radian)
        {
            float Degrees;
            Degrees = Radian * 180 / (float)Math.PI;
            return Degrees;
        }
        #endregion
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
        public float YawL { get; set; }
    }
}

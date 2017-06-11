using Leap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.ServiceProcess;
using System.Windows.Forms;

namespace LeapMotion_visualizer
{
    public partial class Main : Form
    {
        private byte[] imagedata = new byte[1];
        private Controller controller;
        Bitmap bitmap = new Bitmap(640, 480, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
        public Main(Controller c)
        {
            this.controller = c;
            InitializeComponent();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            controller.ImageReady += onImageReady;
            controller.ImageRequestFailed += onImageRequestFailed;

            //set greyscale palette for image Bitmap object
            ColorPalette grayscale = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                grayscale.Entries[i] = Color.FromArgb((int)255, i, i, i);
            }
            bitmap.Palette = grayscale;
        }

        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            Frame frame = eventArgs.frame;

            this.displayID.Text = frame.Id.ToString();
            this.displayTimestamp.Text = frame.Timestamp.ToString();
            this.displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            this.displayHandCount.Text = frame.Hands.Count.ToString();
            Hand rightHand = null;
            Hand leftHand = null;
            if (frame.Hands.Count > 0)
            {
                List<Hand> hands = frame.Hands;
                for (int i = 0; i < hands.Count; i++) {
                    if (hands[i].IsLeft)
                    {
                        leftHand = hands[i];
                    }
                    else {
                        rightHand = hands[i];
                    }
                }
                if (rightHand != null) {
                    this.lblRightHandC_X.Text = rightHand.PalmPosition.x.ToString();
                    this.lblRightHandC_Y.Text = rightHand.PalmPosition.y.ToString();
                    this.lblRightHandC_Z.Text = rightHand.PalmPosition.z.ToString();
                }

                if (leftHand != null) {
                    this.lblLeftHandC_X.Text = leftHand.PalmPosition.x.ToString();
                    this.lblLeftHandC_Y.Text = leftHand.PalmPosition.y.ToString();
                    this.lblLeftHandC_Z.Text = leftHand.PalmPosition.z.ToString();

                }                
            }

            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);
        }

        void onImageRequestFailed(object sender, ImageRequestFailedEventArgs e)
        {
            if (e.reason == Leap.Image.RequestFailureReason.Insufficient_Buffer)
            {
                imagedata = new byte[e.requiredBufferSize];
            }
        }

        void onImageReady(object sender, ImageEventArgs e)
        {
            Rectangle lockArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(lockArea, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] rawImageData = imagedata;
            System.Runtime.InteropServices.Marshal.Copy(rawImageData, 0, bitmapData.Scan0, e.image.Width * e.image.Height * 2 * e.image.BytesPerPixel);
            bitmap.UnlockBits(bitmapData);
            displayImages.Image = bitmap;
        }

        private void bt_startService_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController service = new ServiceController("LeapService");
                if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
                    (service.Status.Equals(ServiceControllerStatus.StopPending)))
                    service.Start();
            }
            catch (Exception ex)
            {
                ErrorHandler eh = new ErrorHandler(ex, "Servicio desconocido");
                eh.Show();
            }
        }

        private void bt_stopService_Click(object sender, System.EventArgs e)
        {
            try
            {
                ServiceController service = new ServiceController("LeapService");
                if ((service.Status.Equals(ServiceControllerStatus.Running)) ||
                    (service.Status.Equals(ServiceControllerStatus.Paused)))
                    service.Stop();
            }
            catch (Exception ex)
            {
                ErrorHandler eh = new ErrorHandler(ex, "Servicio desconocido");
                eh.Show();
            }
            
        }
    }
}

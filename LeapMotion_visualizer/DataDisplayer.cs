using Leap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapMotion_visualizer
{
    public partial class DataDisplayer : Form
    {
        private int frameCounter = 0;
        private Controller controller;
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
                if (frameCounter == 50) { 
                    if (rightHand != null)
                    {
                        #region Right Hand BasisX
                        lblRightHandBasis_x_x.Text = rightHand.Basis.xBasis.x.ToString();
                        lblRightHandBasis_x_y.Text = rightHand.Basis.xBasis.y.ToString();
                        lblRightHandBasis_x_z.Text = rightHand.Basis.xBasis.z.ToString();
                        #endregion

                        #region Right Hand BasisY
                        lblRightHandBasis_y_x.Text = rightHand.Basis.yBasis.x.ToString();
                        lblRightHandBasis_y_y.Text = rightHand.Basis.yBasis.y.ToString();
                        lblRightHandBasis_y_z.Text = rightHand.Basis.yBasis.z.ToString();
                        #endregion

                        #region Right Hand BasisZ
                        lblRightHandBasis_z_x.Text = rightHand.Basis.zBasis.x.ToString();
                        lblRightHandBasis_z_y.Text = rightHand.Basis.zBasis.y.ToString();
                        lblRightHandBasis_z_z.Text = rightHand.Basis.zBasis.z.ToString();
                        #endregion
                    }

                    if (leftHand != null)
                    {
                    
                    }

                    frameCounter = 0;
                }

                frameCounter++;
            }
        }
    }
}

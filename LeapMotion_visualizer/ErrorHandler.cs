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
    public partial class ErrorHandler : Form
    {
        public ErrorHandler()
        {
            InitializeComponent();
        }
        public ErrorHandler(Exception ex, string titulo)
        {
            InitializeComponent();
            string exception_msg = !string.IsNullOrEmpty(ex.Message) ? ex.Message : "Error desconocido";
            lblErrorHandlerTitle.Text = titulo;
            txtErrorHandlerMsg.Text = exception_msg;
        }

    }
}

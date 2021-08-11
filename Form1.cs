using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace AplicacionesArduino2021_II_G3
{
    public partial class Form1 : Form
    {
        public SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            SeleccionarPuerto();
        }

        private void SeleccionarPuerto()
        {
            string[] V = SerialPort.GetPortNames();
            Array.Sort(V);
            tsComboPuertos.Items.AddRange(V);
            
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormTemperatura formTemperatura = new FormTemperatura();
          formTemperatura.MdiParent = this;
          formTemperatura.Show();

        }

       
    }
}

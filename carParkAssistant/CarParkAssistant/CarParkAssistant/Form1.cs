using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CarParkAssistant
{
    public partial class Form1 : Form
    {
        public SerialPort myport;
        int Sensor1, Sensor2, Sensor3, Sensor4, Sensor5, Sensor6;

        public Form1()
        {
            InitializeComponent();
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM3";
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myportDataReceived;
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void myportDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String dataFromArduino = myport.ReadLine().ToString();
            String[] dataSensors = dataFromArduino.Split(',');
            Sensor1 = (int)(Convert.ToDecimal(dataSensors[0]));
            Sensor2 = (int)(Convert.ToDecimal(dataSensors[1]));
            Sensor3 = (int)(Convert.ToDecimal(dataSensors[2]));
            Sensor4 = (int)(Convert.ToDecimal(dataSensors[3]));
            Sensor5 = (int)(Convert.ToDecimal(dataSensors[4]));
            Sensor6 = (int)(Convert.ToDecimal(dataSensors[5]));

            this.Invoke(new EventHandler(displayDataEvent));
        }

        private void displayDataEvent(object sender, EventArgs e)
        {
            if (Sensor1 > 70) //Sensor1
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
            }
            else if (Sensor1 > 30)
            {
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = false;
            }
            else
            {
                p1.Visible = true;
                p2.Visible = false;
                p3.Visible = false;
            }

            if (Sensor2 > 70) //Sensor2
            {
                p4.Visible = true;
                p5.Visible = true;
                p6.Visible = true;
            }
            else if (Sensor2 > 30)
            {
                p4.Visible = true;
                p5.Visible = true;
                p6.Visible = false;
            }
            else
            {
                p4.Visible = true;
                p5.Visible = false;
                p6.Visible = false;
            }
            if (Sensor3 > 70) //Sensor3
            {
                p7.Visible = true;
                p8.Visible = true;
                p9.Visible = true;
            }
            else if (Sensor3 > 30)
            {
                p7.Visible = true;
                p8.Visible = true;
                p9.Visible = false;
            }
            else
            {
                p7.Visible = true;
                p8.Visible = false;
                p9.Visible = false;
            }
            if (Sensor4 > 70) //Sensor4
            {
                p10.Visible = true;
                p11.Visible = true;
                p12.Visible = true;
            }
            else if (Sensor4 > 30)
            {
                p10.Visible = true;
                p11.Visible = true;
                p12.Visible = false;
            }
            else
            {
                p10.Visible = true;
                p11.Visible = false;
                p12.Visible = false;
            }
            if (Sensor5 > 70) //Sensor5
            {
                p13.Visible = true;
                p14.Visible = true;
                p15.Visible = true;
            }
            else if (Sensor5 > 30)
            {
                p13.Visible = true;
                p14.Visible = true;
                p15.Visible = false;
            }
            else
            {
                p13.Visible = true;
                p14.Visible = false;
                p15.Visible = false;
            }
            if (Sensor6 > 70) //Sensor6
            {
                pf1.Visible = true;
                pf2.Visible = true;
                pf3.Visible = true;
            }
            else if (Sensor6 > 30)
            {
                pf1.Visible = true;
                pf2.Visible = true;
                pf3.Visible = false;
            }
            else
            {
                pf1.Visible = true;
                pf2.Visible = false;
                pf3.Visible = false;
            }
        }
    }
}

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

namespace ArduinoServoGauge
{
    public partial class frmArduinoGauge : Form
    {
        Graphics g; //Main graphics object
        Bitmap bitmap = new Bitmap(362, 154); //The gauge will be drawn on the Bitmap
        Gauge servo_gauge; //Logical representation of the gauge
        int degreesOfRotation = 0; //Represents the current degree of Arduino servo rotation

        //Serial Communication port
        SerialPort arduinoPort;
        String selectedPort = "COM5";

        public frmArduinoGauge()
        {
            InitializeComponent();

            //Initialize the Graphics object
            g = Graphics.FromImage(bitmap);
            //Initialize the servo gauge and track bar rate
            servo_gauge = new Gauge(g, pnlGauge.Size.Width / 2, pnlGauge.Size.Height - 20, 100, 10);
            this.controlTrack.SmallChange = servo_gauge.getGuageInterval();
            
            //Start the main drawing loop
            gaugeTimer.Start();

            //Initialize the COM port
            arduinoPort = new SerialPort(selectedPort, 9600);
            rotateServo(0); //Reset the servo to 0 degrees
           
        }
        /*
            Rotate the servo by the @param degrees 
        */
        private void rotateServo( int degrees )
        {
            try
            {
                if (!arduinoPort.IsOpen)
                    arduinoPort.Open();
                arduinoPort.Write(degrees.ToString());
                arduinoPort.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /*
            At every tick of the timer, redraw the gauge, tick marks, and
            the current position of the dial
        */
        private void gaugeTimer_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.NavajoWhite);
            servo_gauge.drawGauge(degreesOfRotation, this.checkDrawTicks.Checked);
            pnlGauge.Invalidate();   
        }

        /*
            When loading the form, get a list of available COM ports and 
            populate the 'Available COM Ports' combo box
        */
        private void frmArduinoGauge_Load(object sender, EventArgs e)
        {
            this.pnlGauge.Focus();
            foreach(string portName in SerialPort.GetPortNames() )
            {
                this.cmbCOMPorts.Items.Add(portName);
            }
        }

        private void pnlGauge_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0); //The guage will be drawn on the bitmap
        }

        /*
            When the main form closes, check if the user wants the servo
            rotate back to 0 degrees position.
        */
        private void frmArduinoGauge_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.checkResetServo.Checked)
                rotateServo(0);
        }

        /*
            Rotate the servo and update the status label as the
            track bar is updated 
        */
        private void controlTrack_Scroll(object sender, EventArgs e)
        {
            //Only rotate the servo if an appropriate interval value is set
            degreesOfRotation = controlTrack.Value;
            if( degreesOfRotation % servo_gauge.getGuageInterval() == 0 )
            {   
                rotateServo(degreesOfRotation);
                this.lblCurrentValue.Text = "Current Rotation(Degrees): " + degreesOfRotation;
            }
        }

        /*
            When user selects an interval, update the rotation intervals for the
            track bar and reset the servo to 0 degrees position
        */
        private void cmbIntervals_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the user selected value
            int selected_interval = Int32.Parse(this.cmbIntervals.GetItemText(this.cmbIntervals.SelectedItem));
            //Set the guage interval so that guage is drawn with the new interval
            this.servo_gauge.setGaugeInterval(selected_interval);
            //Update the rate of the track bar
            controlTrack.SmallChange = selected_interval;
            //Reset trackbar, servo, and label to 0 degrees
            controlTrack.Value = 0;
            degreesOfRotation = 0;
            this.lblCurrentValue.Text = "Current Rotation(Degrees): " + degreesOfRotation;
            rotateServo(degreesOfRotation);
        }

        /*
            When user selects a COM port, verify and update the main arduino 
            communication port
        */
        private void cmbCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedPort = this.cmbCOMPorts.GetItemText(this.cmbCOMPorts.SelectedItem);
            if (verifyCOM(this.selectedPort))
            {
                arduinoPort.PortName = this.selectedPort;
                this.comStatus.Text = "Connected: " + arduinoPort.PortName;
            }
           
        }
        /*
            Verify if a COM port is available for communication
        */
        private bool verifyCOM(String portName)
        {
            String currentPot = arduinoPort.PortName;
            arduinoPort.PortName = portName;
            try
            {
                arduinoPort.Open();
                arduinoPort.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error communicationg with " + portName + ".");
                arduinoPort.PortName = currentPot;
                return false;
            }
        }
    }
}

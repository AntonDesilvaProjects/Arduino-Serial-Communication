using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

/*
    A logical representation of a gauge.  An arduino servo can only rotate
    between 0-180 degrees so the guage is limited accordingly.
*/
namespace ArduinoServoGauge
{
    class Gauge
    {
        int center_x, center_y, radius;
        Graphics gObj;
        int currentDegree = 0; //Current degree-wise position of the dial
        int gauage_interval = 10; //The num of degrees the gauge dial travels in one move 

        int gauge_max = 180;
        int gauge_min = 0;

        public Gauge( Graphics g, int x, int y, int r, int interval )
        {
            this.center_x = x;
            this.center_y = y;
            this.radius = r;
            this.gauage_interval = interval;
            this.gObj = g;
        }
        public Gauge(Graphics g, int x, int y, int r, int interval, int max, int min)
        {
            this.center_x = x;
            this.center_y = y;
            this.radius = r;
            this.gauage_interval = interval;
            this.gauge_max = max;
            this.gauge_min = min;
            this.gObj = g;
        }
        /*
            Draws the guage
         */
        public void drawGauge(int degreesOfRotation, bool drawMark)
        {
            //Draw the base line
            this.gObj.DrawLine(Pens.Black, this.center_x - this.radius, 
                                      this.center_y, 
                                      this.center_x + this.radius, 
                                      this.center_y);
            //Draw the dial
            this.drawDial(degreesOfRotation);

            //Draw gauge marks(tick marks that indicate current position)
            if (drawMark)
                this.drawGaugeMarks(10, this.gauage_interval);
        }
        /*
            Draws the gauge dial based on the specified num of degrees.
        */
        private void drawDial( int degrees )
        {
            //Gauge dial must be inclusively between 0-180 degrees
            if (degrees <= 180 && degrees >= 0)
            {
                double[] dial_coords = getCoordinatesFromDegrees(degrees, this.center_x, this.center_y, this.radius);
                this.gObj.DrawLine(Pens.Green, center_x, center_y, (int)dial_coords[0], (int)dial_coords[1]);
                this.currentDegree = degrees;
            }
        }
        /*
            Draws the gauges marks(tick marks) that will indicate the current position
            of the dial.  
                @param mark_distance is the length of the tick mark
                @param interval is the distance between two tick marks(in degrees)
         
            This function can also mark a sub-section of the 180-arc based on the 
            fields gauge_max & gauge_min. Currently this functionality is not used.
        */
        private void drawGaugeMarks(int mark_distance, int interval)
        {
            for(int i = 0; i <= 180; i = i + interval)
            {
                double[] outer_coords = this.getCoordinatesFromDegrees( i, this.center_x, this.center_y, this.radius + mark_distance);
                double[] inner_coords = this.getCoordinatesFromDegrees( i, this.center_x, this.center_y, this.radius );
                Pen penColor = i > this.gauge_max || i < this.gauge_min ? Pens.Red : Pens.Black;

                this.gObj.DrawLine(penColor, (int) inner_coords[0], (int) inner_coords[1], (int) outer_coords[0], (int) outer_coords[1]);
            }
        }
        /*
            Converts an angle(in degrees) to a cartesian point on the circumference
            of the circle using the following relationship:
         
                x = centerX + r * cos( theta-radians )
                y = centerY + r * sin( theta-radians )
            @result will be a double array consisting of two numbers, the x and y values.
        */
        private double[] getCoordinatesFromDegrees( int degrees, int center_x, int center_y, int radius )
        {
            double radians = degrees * (Math.PI / 180);
            double dial_x = center_x + radius * Math.Cos(radians);
            double dial_y = center_y - radius * Math.Sin(radians);
            return new Double[] { dial_x, dial_y };
        }
        /*
            Returns the current angle of rotation in degrees
        */
        public int getCurrentRotation()
        {
            return this.currentDegree;
        }
        /*
           Returns the current gauge interval
        */
        public int getGuageInterval()
        {
            return this.gauage_interval;
        }
        /*
          Sets the gauge interval
        */
        public void setGaugeInterval(int interval)
        {
            this.gauage_interval = interval;
        }
    }
}

#include <Servo.h>

Servo servo; //Create Servo object

void setup() {
  //Use analog pin 5 to control the servo
  pinMode(5, OUTPUT );
  servo.attach(5); //Connect the servo
  servo.write(0); //Reset the servo to 0 degrees
  Serial.begin( 9600 ); //Initialize Serial communication
}

void loop() {
  int rotate_degrees;
  while( Serial.available() > 0 )
  {
       //Read the entire value from the buffer and convert to an int
       //Use 'readString' b/c an input can have more than 1 digit
       rotate_degrees = Serial.readString().toInt(); 
       servo.write( rotate_degrees ); //Rotate the servo
  }
}

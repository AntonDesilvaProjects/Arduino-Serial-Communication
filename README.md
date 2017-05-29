# Arduino Serial COM with C#
This simple application demonstrates how to control an Arduino servo using C#/.NET SerialPort interface and your keyboard. To visualize the movement of the servo, Windows Forms(WinForm) is used to draw 2D gauge which updates as the servo moves. In addition to these features, application has an interface to select different COM ports(i.e. for easily controlling multiple arduinos) and specify varying rotation intervals for the servo.

![alt text](https://github.com/AntonDesilvaProjects/Arduino-Serial-Communication/blob/master/arduino_gauge_ui.JPG "Arduino Control UI")

### Source Code and Setup
Find the Arduino code within the `arduino_servo.ino` & the C#/WinForm code within the `ArduinoServoGauge` directories. Below is the Arduino sketch:
![alt text](https://github.com/AntonDesilvaProjects/Arduino-Serial-Communication/blob/master/servo_sketch_image.JPG "Arduino Sketch Image")
![alt text](https://github.com/AntonDesilvaProjects/Arduino-Serial-Communication/blob/master/servo_sketch_actual.jpg "Arduino Sketch Actual")

An executable can be found under `/ArduinoServoGauge/bin/Debug/ArduinoServoGauge.exe`
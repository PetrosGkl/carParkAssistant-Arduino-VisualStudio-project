#include <NewPing.h>
#define max_distance 300
#define sonar_num 6     // Number of sensors.

NewPing sonar[sonar_num] = {   // Sensor object array.
  NewPing(13, 7, max_distance), // Each sensor's trigger pin, echo pin, and max distance to ping. 
  NewPing(13, 8, max_distance),
  NewPing(13, 9, max_distance),  
  NewPing(13, 10, max_distance),
  NewPing(13, 11, max_distance),  
  NewPing(13, 12, max_distance)
};

void setup() {
 Serial.begin(9600);
}

void loop() {
  //Sensor1
  Serial.print((int)sonar[0].ping_cm());
  Serial.print(",");
  delay(350);
  //Sensor2
  Serial.print((int)sonar[1].ping_cm());
  Serial.print(",");
  delay(350);
  //Sensor3
  Serial.print((int)sonar[2].ping_cm());
  Serial.print(",");
  delay(350);
  //Sensor4
  Serial.print((int)sonar[3].ping_cm());
  Serial.print(",");
  delay(350);
  //Sensor5
  Serial.print((int)sonar[4].ping_cm());
  Serial.print(",");
  delay(350);
  //Sensor6
  Serial.print((int)sonar[5].ping_cm());
  Serial.print(",");
  delay(1);
  //flag
  Serial.print((int)0);
  Serial.print(",");
  Serial.print((int)0);
  Serial.print(",");
  Serial.print((int)0);
  Serial.println();
  delay(350);
}

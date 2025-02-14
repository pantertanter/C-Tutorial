class Car : Vehicle
{
  public string color;

  public int maxSpeed;

  public string model;
  
  public int doors;

  // class constructor
  public Car(int maxSpeedKmH, string modelName, int nbrDoors)
  {
    color = "red";
    maxSpeed = maxSpeedKmH;
    model = modelName;
    doors = nbrDoors;

  }
  public void FullThrottle()
  {
    Console.WriteLine("The car is going as fast as it can");
  }

  public override string ToString()
    {
        return $"Car: Color: {color}, Max Speed: {maxSpeed} km/h, model: {model}, doors: {doors}";
    }
}
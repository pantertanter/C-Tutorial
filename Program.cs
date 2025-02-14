using System;
using System.Linq;
using System.Reflection;

namespace HelloWorld
{
  class Program
  {

    static int PlusMethod(int x, int y)
    {
        return x + y;
    }

    static double PlusMethod(double x, double y)
    {
        return x + y;
    }
    
    static void Main(string[] args)
    {
    
    static void MyMethod()
    {
        Console.WriteLine("myMethod Console.WriteLine() exeuted");
    }

    MyMethod();
    MyMethod();
    MyMethod();
    MyMethod();

    static void MySecondMethod(string fName, int age, string country = "Norway")
    {
        Console.WriteLine($"{fName} Refnes is {age} old and from {country}");
    }

    MySecondMethod("Liam", 45);
    MySecondMethod("Alex", 64, "Denmark");
    MySecondMethod("Sarah", 23, "Sweden");
    MySecondMethod("Bent", 32, "Finland");

    static bool MyThirdMethod(int i)
    {
        return i > 33;
    }

    Console.WriteLine(MyThirdMethod(66));
    Console.WriteLine(MyThirdMethod(43));
    Console.WriteLine(MyThirdMethod(23));
    Console.WriteLine(MyThirdMethod(13));

    static int MyFourthMethod(int x, int y) 
    {
        return x + y;
    }

    Console.WriteLine(MyFourthMethod(5, 3));

    int z = MyFourthMethod(4, 5);

    Console.WriteLine(z);

    // Overloading functions or methods has to have their definition outside the main scope/loop

    int myNum1 = PlusMethod(8, 5);
    double myNum2 = PlusMethod(4.3, 6.26);
    Console.WriteLine("Int: " + myNum1);
    Console.WriteLine("Double: " + myNum2);

    Car car = new(300, "Ford", 5);
    Console.WriteLine(car);

    car.FullThrottle();

    Person person = new Person();
    person.Name = "Alex";
    Console.WriteLine(person.Name);


    Car carTwo = new Car(299, "Mustang", 5);

    carTwo.Honk();

    Console.WriteLine($"{carTwo.brand} {carTwo.doors} doors");

    Animal myAnimal = new Animal();
    Animal myDog = new Dog();
    Animal myPig = new Pig();

    myAnimal.AnimalSound();
    myDog.AnimalSound();
    myPig.AnimalSound();

    // An interface is a complete abstract class that only can contain absract methods and properties

    Glad glad = new Glad();
    Console.Write("The glad inherent from IHumor says: ");
    glad.humorSound();
    glad.SqrM(35);
    Console.WriteLine($"\n{Glad.Level.Medium}");

    int num = (int) Days.DaysOfWeek.Friday;
    Console.WriteLine(num);

    /*

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }

    for (int i = 0; i < 5; i = i + 2)
    {
        Console.WriteLine(i);
    }

    // Outer loop
    for (int i = 0; i <= 2; i++)
    {
        Console.WriteLine($"Outer loop: {i}");

        //Inner loop
        for (int j = 0; j <= 2; j++)
        {
            Console.WriteLine($"Inner loop: {j}");
        }
    }

    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    foreach (string i in cars)
    {
        Console.WriteLine(i.Substring(0, 3));
        Console.WriteLine(i);
    }

    for (int i = 0; i < 10; i++) 
    {
        if (i == 4) 
        {
            continue;
        }
    Console.WriteLine(i);
}

    cars[0] = "Opel";
    Console.WriteLine(cars[0]);

    Console.WriteLine($"The cars array has {cars.Length} entries");

    string[] houses;

    houses = new string[] {"Villa", "Parcel", "Appartment", "Mansion"};
    Array.Sort(houses);
    Console.WriteLine("The house array sorted alphabetically:");
    foreach (string h in houses)
    {
        Console.Write(h + " ");
    }

    int[] myNumbers = {5, 1, 8, 9};
    Array.Sort(myNumbers);
    Console.WriteLine("\nmyNumbers array sorted");
    foreach (int i in myNumbers)
    {
        Console.Write(i + " ");
    }

    // using System.Linq;
    Console.WriteLine("\n" + myNumbers.Max() + ": is the largest value in the array");  // returns the largest value
    Console.WriteLine(myNumbers.Min() + ": is the smallest value in the array");  // returns the smallest value
    Console.WriteLine(myNumbers.Sum() + ": is the sum of all the element of the array");  // returns the sum of elements

    int x = 1;
    int y = 1;
    int[,] twoDimArray = {{1,3,7}, {4,7,0}};
    Console.WriteLine(twoDimArray[x, y] + "\n");

    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    } 

    for (int i = 0; i < numbers.GetLength(0); i++) 
    { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
            Console.WriteLine(numbers[i, j]); 
        } 
    }  

    */

    /*

    string firstName = "Alex";
    string lastName = "Panter";
    string name = $"My full name is: {firstName} {lastName}";
   
    Console.WriteLine(name);

    string myString = "Hello";
    Console.WriteLine(myString[0]);

    string myEscapeString = "boxer\\cat";
    
    Console.WriteLine(myEscapeString);

    \n	New Line	
    \t	Tab	
    \b	Backspace

    int x = 20;
    int y = 20;
    if (x > y)
    {
        Console.WriteLine($"Yes, the assumption is correct. {x} is greater than {y}");
    }
    else if ( x == y)
    {
        Console.WriteLine($"{x} and {y} are the same numbers");
    }
    else
    {
        Console.WriteLine($"No, the assumption is incorrect. {x} is not greater than {y}");
    }

    x = 20;
    y = 24;
    string result = (x < y) ? "correct" : "Not correct";
    Console.WriteLine(result);

    Console.WriteLine("Please enter the number of a day in the week:");
    int dayNumber = Convert.ToInt32(Console.ReadLine());

    switch (dayNumber)
    {
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("The number is not from 1 to 7");
        break;
}

    int i = 0;
    while (i < 5) 
    {
        Console.WriteLine(i);
        i++;
    }

    i = 0;
    do 
    {
        Console.WriteLine(i);
        i++;
    }
    while (i < 5);

    */

    /*
    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();
    Console.WriteLine("Username is: " + username);

    Console.WriteLine("Enter age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your age is: " + age);

    Console.WriteLine(!(age > 5 && age < 40));

    */

      /*
      string name = "John";
      Console.WriteLine("Hello " + name);

      int myNum;
      myNum = 13;  
      myNum = 14;
      Console.WriteLine(myNum);

      double myDoubleNum = 5.99D;
      char myLetter = 'D';
      Console.WriteLine(myLetter + " " + myDoubleNum);

      bool myBool = true;
      string myText = "Hello";

      Console.WriteLine(myBool + " " + myText);

      // apply const in front of types to make them not changeable

      double myDouble = 9.78;
      int myInt = (int) myDouble;
      Console.WriteLine(myDouble);
      Console.WriteLine(myInt);

      Console.WriteLine(Convert.ToString(myInt));    // convert int to string
      Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
      Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
      Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
      */
    }
  }
}
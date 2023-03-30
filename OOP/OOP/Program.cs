
class car
{
    int horsePower = 1000;
    string color = "red";
    bool fourWheels = true;
    static void Main(string[] args)
    {   
        car myObj = new car();
        car myObj1 = new car();
        myObj1.color = "orange";
        myObj.horsePower = 1500;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj.horsePower);
        Console.WriteLine(myObj1.horsePower);
    }
}
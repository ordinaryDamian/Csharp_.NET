
class car
{
    string color = "red";
    bool fourWheels = true;
    static void Main(string[] args)

    {
        car myObj = new car();
        car myObj1 = new car();
        myObj1.color = "orange";
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj1.fourWheels);
    }
}
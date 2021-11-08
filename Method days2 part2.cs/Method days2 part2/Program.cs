using System;
class HelloWorld
{
    public static void Main() //static 
    {

        HelloWorld oHelloWorld = new HelloWorld();

        string lastName = oHelloWorld.GetUserName("Pooja", "Singh");//caller method  is main method

        Console.WriteLine(lastName);

    }

    public string GetUserName(string fname, string lname)//called method is GetUserName method
    {
        return fname + lname;
    }

    //return statment always return the value to caller 
}
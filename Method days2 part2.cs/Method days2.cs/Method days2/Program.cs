using System;
class HelloWorld
{
    static void Main() //static 
    {
        //method is the block of code that can perform specfic task
        //type of method 
        //static method and non static methdo
        //how to acces the static and non static method
        //static method we can call using class name 
        //non static method we call using object refrences variable
        //method parameter and method argument
        //method return type
        //class Name refrences variable =new class Name();

        HelloWorld m1 = new HelloWorld();//m1 is the refrence variable

        m1.PrintMessage("Lara", "Banglore");//lara and Banglore both are method argument 

        HelloWorld.PrintFullName("abc", "bhopal");//abc and bhopal both are method argument
    }

    public void PrintMessage(string fname, string lname) // non static
    {
        string fullname = fname + " " + lname;

        Console.WriteLine("Hi" + " " + fullname);//
    }

    public static string PrintFullName(string fristName, string lastName)
    {
        return fristName + lastName;
    }
}
/*
fname and lname is the method parameter and signature  

how to accesss the static and non static method 

static method we can access by class name 

and non static method we can access by object refrences 

how to create object 

by using new keyword we can create the object
*/
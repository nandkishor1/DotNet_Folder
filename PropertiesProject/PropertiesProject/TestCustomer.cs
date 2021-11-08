using System;

namespace PropertiesProject
{
    class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101, false, "Nandu", 50000.00,Cites.Bengaluru,"Bihar");
            Console.WriteLine("Custid: " + obj.Custid);
            // obj.Custid = 201;//Can't be assigned as the property is 
            //Console.WriteLine("Custid: " + obj.Custid);

            if(obj.Status == true)
            Console.WriteLine("Current Customer Status: Active");
            else
            
            Console.WriteLine("Modify Customer Status: In-Active");

            Console.WriteLine("Customer Name: " + obj.Cname);
            obj.Cname += " Yadav";
            Console.WriteLine("Modified Name: " + obj.Cname);//Assignement filed, So old  name only print

            Console.WriteLine("Customer Available Balance is: " + obj.Balance);
            obj.Balance = 100000;
            Console.WriteLine("Customer Updated Balance is: " + obj.Balance);//Assignement filed, So old  balance only print

            obj.Status = true;
            if(obj.Status ==true)
                Console.WriteLine("Current Customer Status: Active");
            else
                Console.WriteLine("Modify Customer Status: In-Active");
            obj.Cname += " Yadav";
            Console.WriteLine("Modified Name: " + obj.Cname);//Assignement succeds, So new  name  print

            obj.Balance -= 40000;
            Console.WriteLine("Customer Updated Balance is: " + obj.Balance);//Assignement succeds, So new  balance  print

            obj.Balance = obj.Balance - 9600;
            Console.WriteLine("Modified Balance: " + obj.Balance);

            Console.WriteLine("Current City: " + obj.City);
            obj.City = Cites.Mumbai;
            Console.WriteLine("Modified City: " + obj.City);


            Console.WriteLine("Current State: " + obj.State);

            //obj.State = "Karnatka";
            Console.WriteLine("Modified State: " + obj.Country);
            
            Console.ReadLine();
        }
    }
}

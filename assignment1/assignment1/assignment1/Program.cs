using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name,age,address,contact;
            Console.WriteLine("Enter your name");
            
            name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            
            age = Console.ReadLine();
            Console.WriteLine("Enter your address");
            
            address = Console.ReadLine();
            Console.WriteLine("Enter your contact");
            contact = Console.ReadLine();
            

            Console.WriteLine("Name:"+ name);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("Age:"+ age);
            Console.WriteLine("Contact:" + contact);

            Console.ReadLine();




        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace validation
{
    class program
    {
        static void Main(string[] args)
        {
            ValidationusingLambda v1 = new();
            Console.WriteLine("enter firstname");
            string firstName1 = Console.ReadLine();
            string result1 = v1.Firstname(firstName1);
            Console.WriteLine(result1);

            ValidationusingLambda v2 = new();
            Console.WriteLine("enter Lastname");
            string lastName1 = Console.ReadLine();
            string result2 = v2.Lastname(lastName1);
            Console.WriteLine(result2);

            ValidationusingLambda v3 = new();
            Console.WriteLine("enter email");
            string email = Console.ReadLine();
            string result3 = v3.Email(email);
            Console.WriteLine(result3);

            ValidationusingLambda v4 = new();
            Console.WriteLine("enter mobilenumber");
            string mobilenumber = Console.ReadLine();
            string result4 = v4.PhoneNumber(mobilenumber);
            Console.WriteLine(result4);

            ValidationusingLambda v5 = new();
            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            string result5 = v5.password(password);
            Console.WriteLine(result5);


        }
    }
}
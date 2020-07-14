using System;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace Deliverable2
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");

            var input = Console.ReadLine();
            var message = "";
            var count = 0;
            var checkSum = 0;
            
            foreach (char c in input.ToUpper())
            {
                message = message + ((int)c - 64);
                count++;
                if (input.Length > count)
                    message = (message + "-");

                checkSum = checkSum + c;
            }
         
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " +checkSum);
        }

    }

}











using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {


        // Define an enum with explicit integer values
        //named constants
        //they are stored in the form of integers
        //they should be stored in diff file as Enum Class name
        //enum is only for integer constants only
     

        static void Main(string[] args)
        {
            // Assign enum values and use them
            Status currentStatus = Status.InProgress;
            Console.WriteLine($"Current status: {currentStatus}");
            
            int value = (int)Status.InProgress;
            Console.WriteLine($"InProgress Status value: {value}");

            // Check enum value

            if (currentStatus == Status.InProgress)
            {
                Console.WriteLine("Task is in progress.");
            }
           






        }
    }
}

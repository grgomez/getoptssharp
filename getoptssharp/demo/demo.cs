using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    using getoptssharp;

    class demo
    {
        static void Main(string[] args)
        {

            while(getoptssharp.getopts(args, "a:bc:d"))
            {
                switch (getoptssharp.flag)
                {
                    case "-a":
                        Console.WriteLine("I got a");
                        break;
                    case "-b":
                        Console.WriteLine("I got b");
                        break;
                    case "-c":
                        Console.WriteLine("I got c");
                        Console.WriteLine("I got value {0}", getoptssharp.value);
                        break;
                    case "-d":
                        Console.WriteLine("I got d");
                        break;
                    default:
                        if (getoptssharp.value == "?")
                        {
                            // I will get a message
                        } 
                        else
                        {
                            // Maybe I have an argument
                            Console.WriteLine("I got an argument {0}", getoptssharp.arg);
                        }
                        break;
                }
            }
        }
    }
}

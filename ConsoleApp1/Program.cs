using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kaushik Dutta";
            StringBuilder sb = new StringBuilder();
            sb.Append(name);

            Console.WriteLine("Hello World " + sb.ToString() + "!");
        }
    }
}

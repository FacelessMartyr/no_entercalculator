using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey consoleKey; string n1 = ""; string n2 = ""; string temp;
            do
            {
                while (true)
                {

                    consoleKey = Console.ReadKey().Key;
                    temp = consoleKey.ToString();
                    if (temp.Contains("NumPad"))
                    {
                        if (temp.Contains("1")) { n1 += "1"; }
                        else if (temp.Contains("2")) { n1 += "2"; }
                        else if (temp.Contains("3")) { n1 += "3"; }
                        else if (temp.Contains("4")) { n1 += "4"; }
                        else if (temp.Contains("5")) { n1 += "5"; }
                        else if (temp.Contains("6")) { n1 += "6"; }
                        else if (temp.Contains("7")) { n1 += "7"; }
                        else if (temp.Contains("8")) { n1 += "8"; }
                        else if (temp.Contains("9")) { n1 += "9"; }
                        else if (temp.Contains("0")) { n1 += "0"; }
                    }
                    temp = "";
                    if (consoleKey == ConsoleKey.Add || consoleKey == ConsoleKey.Multiply || consoleKey == ConsoleKey.Subtract || consoleKey == ConsoleKey.Divide)
                    {
                        break;
                        //Console.WriteLine(consoleKey);
                    }
                    //Console.WriteLine(consoleKey);
                }
                int i = 0;
                ConsoleKey Operation = consoleKey;

                temp = "";
                while (true)
                {

                    consoleKey = Console.ReadKey().Key;
                    temp = consoleKey.ToString();
                    if (temp.Contains("NumPad"))
                    {
                        if (temp.Contains("1")) { n2 += "1"; }
                        else if (temp.Contains("2")) { n2 += "2"; }
                        else if (temp.Contains("3")) { n2 += "3"; }
                        else if (temp.Contains("4")) { n2 += "4"; }
                        else if (temp.Contains("5")) { n2 += "5"; }
                        else if (temp.Contains("6")) { n2 += "6"; }
                        else if (temp.Contains("7")) { n2 += "7"; }
                        else if (temp.Contains("8")) { n2 += "8"; }
                        else if (temp.Contains("0")) { n2 += "0"; }
                    }
                    temp = "";
                    if (consoleKey == ConsoleKey.OemPlus)
                    {
                        break;
                    }

                }
                if (Operation == ConsoleKey.Add) { Console.WriteLine(Convert.ToInt32(n1) + Convert.ToInt32(n2)); }
                else if (Operation == ConsoleKey.Divide) { Console.WriteLine(Convert.ToInt32(n1) / Convert.ToInt32(n2)); }
                else if (Operation == ConsoleKey.Subtract) { Console.WriteLine(Convert.ToInt32(n1) - Convert.ToInt32(n2)); }
                else if (Operation == ConsoleKey.Multiply) { Console.WriteLine(Convert.ToInt32(n1) * Convert.ToInt32(n2)); }
                temp = "";
                n1 = "";n2 = "";
            } while (consoleKey != ConsoleKey.Q);
               

        }
    }
}

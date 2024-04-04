using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joe_Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() {Cash = 50, Name = "joe" };
            Guy bob = new Guy() {Cash = 100, Name = "bob" };

            while (true)
            {
                Console.Write("do you want play game(Y/N) : ");
                string yn = Console.ReadLine();
                if (yn == "Y")
                {
                    continue;
                }
                else if (yn == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("check you coment!");
                    return;
                }
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                int amount;
                if (int.TryParse(howMuch, out amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.Receive(amount);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.Receive(amount);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }

            }
        }
    }
}

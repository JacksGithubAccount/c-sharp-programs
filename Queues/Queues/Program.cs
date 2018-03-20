using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue inventory = new Queue();
            Queue price = new Queue();
            int addItems, itemSell = 0, totalQuantity = 0;
            int quantity = 0, pushBack = 0;
            decimal totalPrice = 0, itemPrice = 0, profit = 0;
            string command;

            do
            {
                Console.WriteLine("What would you like to do?" + Environment.NewLine +
                    "[1] - Add an Item to inventory" + Environment.NewLine +
                    "[2] - Sell item from inventory" + Environment.NewLine +
                    "[3] - Check the current profit" + Environment.NewLine +
                    "[4] - End the program");
                command = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("");

                switch (command)
                {
                    case "1":
                        Console.WriteLine("Enter the number of items you would like to add to the inventory");
                        addItems = int.Parse(Console.ReadLine());
                        inventory.Enqueue(addItems);
                        Console.WriteLine("\n Enter the Price for the item");
                        itemPrice = decimal.Parse(Console.ReadLine());
                        price.Enqueue(itemPrice);
                        break;
                    case "2":
                        Console.WriteLine("How many items would you like to sell.");
                        itemSell = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((int)inventory.Peek() >= itemSell)
                        {
                            quantity = (int)inventory.Dequeue();
                            itemPrice = (decimal)price.Dequeue();
                            totalPrice += itemPrice * itemSell;
                            totalPrice = totalPrice * 1.1m;
                            profit += totalPrice - (totalPrice / 1.1m);

                            Console.WriteLine("The cost of " + itemSell + " items is "
                                + totalPrice + "USD\n");
                        }
                        else
                        {
                            do
                            {
                                quantity = (int)inventory.Dequeue();
                                itemPrice = (decimal)price.Dequeue();
                                totalQuantity += quantity;
                                totalPrice += quantity * itemPrice;
                                if (totalQuantity > itemSell)
                                {
                                    pushBack = totalQuantity - itemSell;
                                    inventory.Enqueue(pushBack);
                                    price.Enqueue(itemPrice);

                                    totalPrice -= pushBack * itemPrice;

                                }
                                profit = totalPrice * .1m;
                            }
                            while (totalQuantity < itemSell);
                            totalPrice = totalPrice * 1.1m;
                            Console.WriteLine("Cost of " + itemSell + " item is "
                                + totalPrice + "USD\n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Your current total profit is: " + profit + " USD\n");
                        break;
                }
            }
            while (command != "4");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

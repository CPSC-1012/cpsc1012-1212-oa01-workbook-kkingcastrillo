/*
 * Purpose:         Program for calculating the sale price of an item
 * 
 * Input:           item's price, item's quantity
 * 
 * Output:          Subtotal, provincial tax, federal tax, total tax, total purchase
 * 
 * Written by:      Kevin King
 * 
 * Written for:     Sam Wu
 * 
 * Section:         Lab 1 - OA01
 */
using System;

namespace CPSC1012_Lab01_KevinKing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            double ProvincialTax = 0.06;
            double FederalTax = 0.05;

            //Variables
            double itemPrice;
            double itemquantity;
            double provincialTax;
            double federalTax;
            double totalPurchase;

            Console.WriteLine("************ Welcome to the General Store ************\n");

            //Input data
            Console.WriteLine("Enter price of the item:");
            itemPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter quantity of item:");
            itemquantity = double.Parse(Console.ReadLine());

            //Processing data 
            provincialTax = (itemPrice * itemquantity) * ProvincialTax;
            federalTax = (itemPrice * itemquantity) * FederalTax;
            totalPurchase = (itemPrice * itemquantity) + provincialTax + federalTax;

            //Results
            Console.WriteLine("\nInvoice Summary\n");
            Console.WriteLine("=========================\n");
            Console.WriteLine($"Sub Total:\t\t{(itemPrice * itemquantity):F2}\n");
            Console.WriteLine($"Provincial Tax:\t\t{provincialTax:F2}");
            Console.WriteLine($"Federal Tax:\t\t{federalTax:F2}");
            Console.WriteLine($"Total Tax:\t\t{(provincialTax + federalTax):F2}\n");
            Console.WriteLine($"Total Price:\t\t{totalPurchase:F2}\n");
            Console.WriteLine("=========================\n");
            Console.WriteLine("Thank you for your purchase, come again.");
            Console.WriteLine("Press 'Enter' to exit");
            Console.ReadLine();
        }
    }
}
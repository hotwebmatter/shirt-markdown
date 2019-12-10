/**
 * ######################################################
 * ##    Chapter 2, Programming Exercise #5            ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: December 9 2019               ##
 * ##    Purpose: Width & numeric format specifiers    ##
 * ######################################################
 */
using System;
using static System.Console;

namespace shirt_markdown
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate values using compile-time initialization
            // note that this algorithm seems wrong; retail price is undefined
            // and sale price should be markdown of retail, not wholesale
            // but it's just a silly code example from a textbook :)

            string itemName = "Open Collar Running Shirt";
            double itemWholesalePrice = 41,
                   markdownPercentage = 0.15,
                   itemMarkdownAmount = itemWholesalePrice * markdownPercentage,
                   itemMarkdownPrice = itemWholesalePrice * (1 - markdownPercentage);
            if (itemMarkdownPrice == (itemWholesalePrice - itemMarkdownAmount))
            {
                // generate output
                WriteLine("{0, 12} {1}", "Item Name:", itemName);
                WriteLine("{0, 12} {1:C2}", "Wholesale:", itemWholesalePrice);
                WriteLine("{0, 12} {1:C2}", "Markdown:", itemMarkdownAmount);
                WriteLine("{0, 12} {1:C2}", "Sale price:", itemMarkdownPrice);
            }
            else
            {
                // unreachable state (if algorithm is correct)
                WriteLine("Something went wrong with our calculations!");
                WriteLine("https://www.xkcd.com/2200/");
            }
        }
    }
}

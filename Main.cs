using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            String stockName;
            int shareBought;
            double shareBoughtPrice,
                   shareSoldPrice,
                   totalBoughtPrice,
                   totalSoldPrice,
                   totalDifference;

            Header();
            Instruction();

            Console.WriteLine("******************************");
            Console.Write("Enter stock name: ");
            stockName = Console.ReadLine();
            Console.Write("Enter shares bought: ");
            shareBought = int.Parse(Console.ReadLine());
            Console.Write("Enter price bought: ");
            shareBoughtPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter price sold: ");
            shareSoldPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("******************************");

            StockCalc stockCalc = new StockCalc(shareBought, shareBoughtPrice, shareSoldPrice);

            totalBoughtPrice = stockCalc.calculateAmountSpent();
            totalSoldPrice = stockCalc.claculateAmountReceived();
            totalDifference = stockCalc.calculateDifference(totalSoldPrice, totalBoughtPrice);

            Console.WriteLine("\t{0}\n" +
                              "Bought price\t{1:c}\n" +
                              "Sold price\t{2:c}\n" +
                              "Difference\t{3:c}\n",
                              stockName, totalBoughtPrice, totalSoldPrice, totalDifference);

            Console.Read();


        }

        public static void Header()
        {
            Console.WriteLine("*******************************************************\n" +
                              "\tStock Transaction\n" +
                              "\tCalculate results of stock bought and sold\n" +
                              "\tDylan Grandjean\n\t" +
                              DateTime.Today.ToShortDateString() +
                              "\n*******************************************************");
        }

        public static void Instruction()
        {
            Console.WriteLine("This program will determine profit or loss on stock\n\n" +
                              "You will be asked to enter the stock name, number of shares,\n" +
                              "price bought, and price sold.\n\n" +
                              "*******************************************************");
        }
    }
}

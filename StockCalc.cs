using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class StockCalc
    {
        const double COMMISSION = .03;

        int shareBought;
        double shareBoughtPrice,
               shareBoughtSold;

        //Default constructor
        public StockCalc(){}

        //Variable instantiator
        public StockCalc(int aShareBought, double aShareBoughtPrice, double aShareBoughtSold)
        {
            shareBought = aShareBought;
            shareBoughtPrice = aShareBoughtPrice;
            shareBoughtSold = aShareBoughtSold;
        }

        public double calculateAmountSpent()
        {
            double subTotal = shareBought * shareBoughtPrice;
            subTotal += (subTotal * COMMISSION);
            return subTotal;
        }

        public double claculateAmountReceived()
        {
            double subTotal = shareBought * shareBoughtSold;
            subTotal += (subTotal * COMMISSION);
            return subTotal;
        }

        public double calculateDifference(double totalAmountReceived, double totalAmountSpent)
        {
            return totalAmountReceived - totalAmountSpent;
        }

    }
}

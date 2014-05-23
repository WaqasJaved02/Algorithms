using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    class MaximumProfit
    {
        public int BuyingIndex {get; set;}
        public int SellingIndex { get; set; }
    }

    class Helper 
    {
        public MaximumProfit GetMaximumProfitForStock(double[] stockPrices)
        {
            int min = 0;
            double maxDiff = 0;
            int Buying = 0, Selling = 0;
            for (int i = 0; i < stockPrices.Length; i++)
            {
                if (stockPrices[i] < stockPrices[min])
                    min = i;
                double diff = stockPrices[i] - stockPrices[min];
                if (diff > maxDiff)
                {
                    Buying = min;
                    Selling = i;
                    maxDiff = diff;
                }
            }

            return new MaximumProfit() { BuyingIndex = Buying, SellingIndex = Selling };
        }
    }
    
}

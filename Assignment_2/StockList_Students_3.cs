using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal

        public decimal Value()
        {
            decimal value = 0.0m;

            // write your implementation here
            StockNode current = head;
            while (current != null)
            {
                value += (current.StockHolding.Holdings * current.StockHolding.CurrentPrice);
                current = current.Next;
            }

            return value;
        }

        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            // Considering Similarity means the Stocks with the same name.
            StockNode node1 = head;
            StockNode node2 = listToCompare.head;
            while(node1 != null)
            {
                while(node2 != null)
                {
                    if(node1.StockHolding.Name == node2.StockHolding.Name)
                    {
                        similarityIndex++;
                    }
                    node2 = node2.Next;
                }
                node1 = node1.Next;
            }

            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            StockNode current = head;
            if (current == null)
            {
                Console.WriteLine("No Data to print");
            }
            while (current != null)
            {
                Console.WriteLine(current.StockHolding);
                current = current.Next;
            }
        }
    }
}
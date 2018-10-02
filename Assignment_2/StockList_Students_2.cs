using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
        StockList resultList = new StockList();
        StockNode current = head;
        while (current != null)
        {
            resultList.AddStock(current.StockHolding);
            current = current.Next;
        }
        current = listToMerge.head;
        while (current != null)
        {
            resultList.AddStock(current.StockHolding);

            current = current.Next;
        }
        // write your implementation here

        return resultList;
    }
        public Stock MostShares()
        {
        Stock mostShareStock = null;
        mostShareStock = head.StockHolding;
        StockNode current = head;
        while (current != null)
        {
            if (mostShareStock.Holdings < current.StockHolding.Holdings)
            {
                mostShareStock = current.StockHolding;
            }
            current = current.Next;
        }

        return mostShareStock;
    }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
    {
        int length = 0;

        StockNode current = head;
        while (current != null)
        {
            length++;
            current = current.Next;
        }

        return length;
        }
    }
  }
}
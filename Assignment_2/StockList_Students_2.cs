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
        while (current != null) // add the first list to the new list
        {
            resultList.AddStock(current.StockHolding); // add stock nodes to the new list until first list is finished
            current = current.Next;
        }
        current = listToMerge.head; // once first list is added set the current node to the start of next list and continue adding the nodes
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
        mostShareStock = head.StockHolding; // set the first value as the max value.
        StockNode current = head;
        while (current != null) // traverse through the list to find the node eith highest holdings
        {
            if (mostShareStock.Holdings < current.StockHolding.Holdings)
            {
                mostShareStock = current.StockHolding;
            }
            current = current.Next; // go to the next node
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
        while (current != null)  // traverse the list and increment length with each loop cycle to get the length
        {
            length++;
            current = current.Next; // go to the next node
        }

        return length;
        }
    }
  }
}
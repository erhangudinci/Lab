using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_
{
    class Stock
    {
        int count = 0;
        StockItem[] stockItems = new StockItem[20];
        
        public StockItem this[int index]
        {
            get { return stockItems[index]; }
            private set
            {
                stockItems[index] = value;
            }
        }
        
        public void AddItem(StockItem item)
        {
            
            this[count] = item;
            count++;
        }
        
        public StockItem GetItem(int itemId)
        {

            for (int i = 0; i < stockItems.Length; i++)
            {
                if (stockItems[i] != null)
                {
                    Console.WriteLine("Hittar inget");
                    break;
                }
                else if (stockItems[i].Id == itemId)
                {
                    return stockItems[i];
                }
            }
            throw new Exception("Det Blev ett fel");
    }

        public int StockItemLength()
        {
            return stockItems.Length;
        }
    }
}

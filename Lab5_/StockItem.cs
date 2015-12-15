using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_
{
    class StockItem
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                var validId = value > 0;
                if (validId)
                    id = value;
                else
                    throw new Exception("Något blev fel. Prova igen!");
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                var validName = !string.IsNullOrWhiteSpace(value);
                if (validName)
                    name = value;
                else
                    throw new Exception("Något blev fel");
            }
        }
        private int stockCount;

        public int StockCount
        {
            get { return stockCount; }
            set
            {
                var validStockCount = value > 0;
                if (validStockCount)
                    stockCount = value;
                else
                    throw new Exception("Något blev fel!");
            }
        }

        public StockItem(int id, string name, int stockCount)
        {
            Id = id;
            Name = name;
            StockCount = stockCount;   
        }

        public StockItem()
        {
        }

        public override string ToString() => $"Id: {Id} Name: {Name} Stock Count: {StockCount}";
    }
}

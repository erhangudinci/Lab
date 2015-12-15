using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_
{
    class EcoStockItem : StockItem
    {
        private string markning;

        public string Markning
        {
            get { return markning; }
            set
            {
                var validMarkning = value.ToLower() == "krav" || value.ToLower() == "eg";
                if (validMarkning)
                    markning = value.ToLower();
                else
                    throw new Exception("Det är inte ekoligisk.");
            }
        }

        public EcoStockItem(int id, string name, int stockCount, string markning) : base(id,name,stockCount)
        {
            Markning = markning;
        }

        public EcoStockItem()
        {
        }

        public override string ToString()
        {
            return string.Format($"Markning: {Markning} {base.ToString()}");
        }
    }
}

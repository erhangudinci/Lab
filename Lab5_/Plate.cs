using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_
{
    class Plate : StockItem
    {
        private string typ;

        public string Typ
        {
            get { return typ; }
            set
            {
                var validTyp = !string.IsNullOrWhiteSpace(value) || value.ToLower() == "flat" || value.ToLower() == "djup";
                if (validTyp)
                    typ = value.ToLower();
                else
                    throw new Exception("Din tallrik är nånting annat än flat och djup. Prova igen!");
            }
        }

        public Plate(int id, string name, int stockCount,string typ):base(id,name,stockCount)
        {
            Typ = typ;
        }

        public Plate()
        {
        }

        public override string ToString()
        {
            return string.Format($"Tallriks typ: {Typ} {base.ToString()}");
        }
    }
}

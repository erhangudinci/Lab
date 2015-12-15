using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_
{
    class Juice : EcoStockItem
    {
        private string typ;

        public string Typ
        {
            get { return typ; }
            set
            {
                var validTyp = !string.IsNullOrWhiteSpace(value) || value.ToLower() == "äpple" || value.ToLower() == "orange";
                if (validTyp)
                    typ = value.ToLower();
                else
                    throw new Exception("Det är inte äpple eller orange.");
            }
        }

        public Juice(int id, string name, int stockCount, string markning, string typ) : base(id, name, stockCount, markning)
        {
            Typ = typ; 
        }

        public Juice()
        {
        }

        public override string ToString()
        {
            return string.Format($"Juice typ: {Typ} {base.ToString()} ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Bicycle bicycle, int quantity)
        {
            CartLine line = lineCollection.FirstOrDefault(x => x.Bicycle.BicycleId == bicycle.BicycleId);
            
            if(line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Bicycle = bicycle,
                    Quantity = quantity
                });
            }
            else
                line.Quantity += quantity;
        }

        public void RemoveLine(Bicycle bicycle)
        {
            lineCollection.RemoveAll(x => x.Bicycle.BicycleId == bicycle.BicycleId);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public int ComputeTotalValue()
        {
            return lineCollection.Sum(x => x.Bicycle.Price * x.Quantity);
        }

        public IEnumerable<CartLine> Lines
        {            
            get => lineCollection;
        }

    }

    public class CartLine
    {
        public Bicycle Bicycle { get; set; }
        public int Quantity { get; set; }
    }

}

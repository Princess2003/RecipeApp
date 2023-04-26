using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    public class Ingredients
    {

        //Data members
        private string Name;
        private double Quantity;
        private string Unit;

        //get and set
        public string name { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }


        public Ingredients()
        {
            Name = Name;
            quantity = Quantity;
            Unit = Unit;
        }
        public void RestQuantity()
        {
            Quantity /= 2;
        }


    }

}


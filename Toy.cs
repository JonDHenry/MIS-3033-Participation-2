//Jonathan Henry
//MIS 3033-950
//Participation 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Toy
    {

        public string manufacturer { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string aisle { get; set; }

        public Toy()
        {

        }

        public string GetAisle()
        {
            //Returns the first letter of the Manufacturer, capitalized with the value of the Price afterwards (with no punctuation like . or , or $).
            string aisle = aisle = manufacturer.Substring(0, 1) + Math.Floor(price);

            return aisle;
        }

        public override string ToString()
        {
            return $"{manufacturer} - {name}";
        }
    }
}

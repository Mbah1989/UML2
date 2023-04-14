using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UML2
{
    public class Items
    {

        public Items( Pizza Pizza, int Quantity) 
        { 
          
            
            this.Quantity = Quantity;
            this.Pizza = Pizza;
            
        }
        public Items()
        {
            
        }
        
        
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
        public Pizza Pizza { get; set; }
       


        public override string ToString()
        {
            return $" Customer : {Customer},  Pizza : {Pizza}, Quantity : {Quantity} ";
        }
        

    }
}

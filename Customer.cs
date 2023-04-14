using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
   public class Customer
    {
       public string Name { get; set; }
        public string Address { get; set; }
        public int  Number { get; set; }
        public int Id { get; set; }
        public Customer(string name, string address, int number, int Id)
        {
            this.Name = name;
            this.Address = address;
            this.Number = number;
            this.Id = Id;
        }
        public Customer() { }

        public override string ToString()
        {
            return $"Name: { Name}, Address : {Address}, Number: {Number}, Id: {Id}";
        }
    }
}

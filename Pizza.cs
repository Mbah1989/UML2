using System.Net;

namespace UML2
{
    public class Pizza
    {
        public Pizza() { }
        public Pizza(int number, string name, int price)
        { 
            Number = number;
            Name = name;
            Price = price;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
          
            return $"Number: {Number}, Name : {Name}, Price: {Price}";
        }
    }
}
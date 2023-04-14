using System;
using System.Collections.Generic;
namespace UML2
{
    public class MenuCatalog 
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
              
        {
            _pizzas = new List<Pizza>();
            Pizza p1 = new Pizza(1, "peperoni large", 50);
            Pizza p2 = new Pizza(2, "peperoni small", 25);
            _pizzas.Add(p1);
            _pizzas.Add(p2);
        }
        public List<Pizza> Pizzas
        {
            get { return _pizzas; }
        }
        public void Create(Pizza p)
        {
            _pizzas.Add(p);
          
        }
        public void PrintMenu()
        {
            foreach (var p in _pizzas)
            {
                Console.WriteLine(p);
            }
            
           
        }
       
        public void Update(Pizza pizza, int Number)
        {
            foreach (var p in _pizzas)
            {
              
                if (p.Number ==Number)
                {
                   
                    p.Name = pizza.Name;
                    p.Price = pizza.Price;
                    return;

                    
                    
                }
               
            }

        }
        public void Delate(int Number)
        {
            foreach (var p in _pizzas)
            {
                if (p.Number == Number)
                {
                    _pizzas.Remove(p);
                    return;
                }
            }
        }
    }
}


    

    

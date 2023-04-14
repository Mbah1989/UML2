using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML2
{
    public class Order
    {

        List<Items> _items;
        Customer _customer;
        int _id;


        public Order(int id,Customer customer)
        {
            _id = id;
           
            _customer = customer;
            _items = new List<Items>();

        }
        public Order()
        {

            _items = new List<Items>();
            
        }
        public List<Items> Items
        { get { return _items; } }

        public void CreateOrder(Items items)
        {
            foreach (var item in _items)
            {
                _items.Add(item);
                break;
            }
        }
        public List<Items> PrintOrder()
        {
            List<Items> list = new List<Items>();
            foreach (var item in _items)
            {
                list.Add(item);
                Console.WriteLine(item);

            }
            return list;

        }
        public void AddItems(Pizza pizza, int quantity) 
        {
           Items i = new Items(pizza, quantity);
            _items.Add(i);
        }
        //public void DeleteOder(int id)
        //{
        //    foreach (var item in _items)
        //    {
        //        if(item.Id== id) 
        //        {
        //            _items.Remove(item);
        //            return;
        //        }
        //    }

        //}
        public override string ToString()
        {
            string str = "";
         
             foreach (Items item in _items)
            {
              
               str += $"Name: {item.Pizza.Name}, :Price: {item.Pizza.Price}, Number: {item.Pizza.Number} Quantity: {item.Quantity}\n";


            }
             return str;
        }

        public void UpdateOrder(Items items, int number)
        {
            foreach (var item in _items)
            {


                if (item.Pizza == item.Pizza)

                    item.Customer = items.Customer;
                item.Quantity = items.Quantity;

                return;


            }
           
            //}
            




            //public void Topping( int id) 
            //{

            //    foreach (Items item in _items) 
            //    {

            //        if (item.Id == id)
            //        {
            //            Console.WriteLine("Enter Extra Topping");
            //        }
            //    }
            //}
        }
    }
}

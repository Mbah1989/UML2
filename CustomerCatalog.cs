using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UML2
{
    public class CustomerCatalog 
    {
        List<Customer> _customers;
        public CustomerCatalog()
        {
            _customers = new List<Customer>();
        }
        public void Create(Customer c)
        {
            _customers.Add(c);
            
        }
        public List<Customer> PrintCustomer()
        {
            List<Customer> list = new List<Customer>();
          
            foreach (var c in _customers)
            {
                list.Add(c);

            }
            return list;
        }
        public void Update (Customer customer, int Id)
            //I need to find an object in this list by some property which is unique 
            //and update another property of this object.
        {
          
            foreach (var c in _customers)
            {
                if (c.Id == Id)
                {
                    c.Name = customer.Name;
                    c.Number = customer.Number;
                    c.Address = customer.Address;
                    return;
                }


            }
        }
        public void Delete(int Id)
        {
            foreach (var c in _customers)
            {
                if (c.Id == Id)
                {
                    _customers.Remove(c);
                }
            }
        }
        public Customer SearchCustomer( int Id)
        {
            Customer customer=new Customer();
            foreach (var c in _customers)

            {

                if (c.Id == Id)
                {
                    customer = c;
                    break;
                } 
               
            }
            return customer;
        }
        

    }
}

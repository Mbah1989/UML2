using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace UML2
{
    public class Store
    {

        MenuCatalog menuCatalog;
        CustomerCatalog customerCatalog;
        Order order;
      
    
      

           public Store()
        {   menuCatalog = new MenuCatalog();
            customerCatalog = new CustomerCatalog();
            order= new Order();
          
           

        }
        public Pizza GetItem( int Number) 
        {
            foreach (var Pizza in menuCatalog.Pizzas)
            {
                if (Number == Pizza.Number)
                    return Pizza;


            }
            return null;

        }
        public void doRun(Order o)
        {
            Console.WriteLine("Enter Item number ");
            Console.WriteLine("Enter 100 to view the added items ");
            Console.Write("or zero to complete ");


            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                return;
            }
            else if (number == 100)
            {
                Console.WriteLine(o);
                doRun(o);
            }
            Console.Write("Enter quantity ");
            int quantity = int.Parse(Console.ReadLine());


            Pizza p = GetItem(number);


            if (p != null)
            {
                o.AddItems(p, quantity);
                Console.WriteLine("Item Added");
            }
            else
            {
                Console.WriteLine("invalid Order number " + number);
            }
            
             
            doRun(o);
           



            
       
        }
        public void deleteOrder()
        {
            //Console.WriteLine("Enter Order Number");
            //int orderNumber = int.Parse(Console.ReadLine()) ;
            order.PrintOrder();
            Console.Write("Enter Item Number ");
            int number = int.Parse(Console.ReadLine()) ;
            //order.DeleteItems(number);
            //order.PrintOrder();
        }


        public void Run()
        {
            MenuCatalog catalog = new MenuCatalog();
            customerCatalog = new CustomerCatalog();
            order = new Order();
            printOptions();
            ShowMenu(catalog);
                
            
        }
        static void printOptions()
        {

            Console.WriteLine("Welcome. Enter : ");

            Console.WriteLine("PIZZA");

            Console.WriteLine("1. To Print Menu");

            Console.WriteLine("2. To Add ");

            Console.WriteLine("3. To Update");

            Console.WriteLine("4. To Delete");

            Console.WriteLine("0. To End the program");

            Console.WriteLine( "CUSTOMER");

            Console.WriteLine("5.To Add customer");

            Console.WriteLine("6 To Update customer");

            Console.WriteLine("7 To Delate customer");

            Console.WriteLine("8 To Search customer");

            Console.WriteLine("9 To Print customer list");

            Console.WriteLine(" ORDER");

            Console.WriteLine("10 Order items");

            
        
        }

       
        void ShowMenu(MenuCatalog catalog)
        {
             Console.Write("Enter your choice; ");
                string input = Console.ReadLine();
            
            //Case 1
            //Print Manu

            if (string.Equals(input, "1"))
            {
                Console.WriteLine(" MY MENU");
                catalog.PrintMenu();
                
            }
            //Case 2
            //Add Pizza

            else if (string.Equals(input, "2"))
            {
                try
                {
                    Console.Write(" Enter number; ");
                    int number = Int32.Parse(Console.ReadLine());

                    Console.Write(" Enter pizza name; ");
                    string name = Console.ReadLine();

                    Console.WriteLine(" Enter price; ");
                    int price = Int32.Parse(Console.ReadLine());
                    Pizza p = new Pizza(number, name, price);
                    catalog.Create(p);
                    Console.Clear();
                    printOptions();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            //Case 3
            //Update Pizza

            else if (string.Equals(input, "3"))
            {
                try

                {
                    Console.WriteLine(" Enter Pizza number ");
                    int number = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter pizza name; ");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter pizza price");
                    int price = int.Parse(Console.ReadLine());
                    Pizza p = new Pizza(number, name, price);
                    catalog.Update(p, number);
                    Console.Clear();
                    printOptions();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            //Case 4
            //Delate Pizza

            else if (string.Equals(input, "4"))
            {
                try
                {
                    Console.WriteLine(" Enter Pizza number");
                    int number = Int32.Parse(Console.ReadLine());

                    catalog.Delate(number);
                    Console.Clear();
                    printOptions();
                }
                catch(Exception e)
                { 
                    Console.WriteLine(e.Message);
                }
            }
            //Case 5
            //Add Customer

            else if (string.Equals(input, "5"))
            {
                try
                {
                    Console.WriteLine(" Enter customer name ");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter customer Address ");
                    string address = Console.ReadLine();
                    Console.WriteLine(" Enter customer Number ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter customer Id ");
                    int id = int.Parse(Console.ReadLine());
                    Customer c = new Customer(name, address, number, id);
                    customerCatalog.Create(c);
                    Console.Clear();
                    printOptions();
                }
                catch( Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                }
            }
            //Case 6
            //Update Customer
            else if (string.Equals(input, "6"))
            {
                try
                {
                    Console.WriteLine(" Enter Id ");
                    int Id = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter Customer name ");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter customer address ");
                    string address = Console.ReadLine();
                    Console.WriteLine(" Enter customer number ");
                    int number = int.Parse(Console.ReadLine());
                    Customer c = new Customer(name, address, number, Id);
                    customerCatalog.Update(c, Id);
                    Console.Clear();
                    printOptions();
                }
                catch ( Exception ex ) 
                { 
                    Console.WriteLine(ex.Message);
                }
            }
            //Case 7
            //Delete Customer

            else if (string.Equals(input, "7"))
            {
                try
                {
                    Console.WriteLine(" Enter Id ");
                    int Id = Int32.Parse(Console.ReadLine());
                    customerCatalog.Delete(Id);
                    Console.Clear();
                    printOptions();
                }
                catch (Exception ex)
                { 
                 Console.WriteLine(ex.Message);
                }
            }
            //Case 8
            //Search Customer

            else if (string.Equals(input, "8"))
            {
                try
                {
                    Console.WriteLine(" Enter Id ");
                    int Id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(customerCatalog.SearchCustomer(Id));
                }
                catch(Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                }
                

            }
            //Case 9
            //Print customer

            else if (string.Equals(input, "9"))
            {
              foreach (var c in customerCatalog.PrintCustomer())
                {
                    Console.WriteLine(c);
                }

            }
            //Case 10
            //Create Order
            else if (string.Equals(input, "10"))
            {
                try
                {
                   
                    Console.Write("Enter Order Number ");
                    int OrderNumber = int.Parse(Console.ReadLine());
                    Customer c = new Customer() { Name = "Elvis" };

                    Order o = new Order(OrderNumber, c);
                 
                    menuCatalog.PrintMenu();
                    doRun(o);
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            

            //Case 0

            else if (string.Equals(input, "0"))
            {
                return;
            }

            else
            {
                Console.WriteLine("Invalid input...");
                printOptions();

            }
            ShowMenu(catalog);

        }
    }
}



        
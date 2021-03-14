using Order1;
using Person1;
using Product1;
using System;
using System.Collections.Generic;
using System.Text;


namespace PirmaisMajasDarbs
{
    public interface IOrderManager 
    {
        void AddOrder(Order o);
        void AddProduct(Product p);
        void AddProduct(string name, decimal price, int Amount);
        void AddPerson(Person p);
        public IEnumerable<Order> GetOrders();
        public IEnumerable<Person> GetPersons();
        public IEnumerable<Product> GetProducts();


    }
}

using System;
using System.Linq;
using DataStore;
using DataStore.Models;

var customers = MyData.GetCustomers();

var highValueCustomers = customers
    .Where(c => c.orders.Any(o => o.products.Sum(p => p.price) > 1000));

foreach (var customer in highValueCustomers)
{
    Console.WriteLine(customer.name);
}

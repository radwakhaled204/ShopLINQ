using System;
using System.Linq;
using DataStore;
using DataStore.Models;

// WHERE Function
var customer = MyData.GetCustomers();

var highValueCustomers = customer.Where(o => o.orders.Any(p => p.products.Sum(s => s.price) > 500 && p.products.Sum(s => s.price) < 2000));
foreach (var item in highValueCustomers)
{
    Console.WriteLine(item.name);
}



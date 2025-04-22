using System;
using System.Linq;
using DataStore;
using DataStore.Models;


var customer = MyData.GetCustomers();


// WHERE Function
//var highValueCustomers = customer.Where(o => o.orders.Any(p => p.products.Sum(s => s.price) > 500 && p.products.Sum(s => s.price) < 2000));
//foreach (var item in highValueCustomers)
//{
//    Console.WriteLine(item.name);
//}


//Select Funcation
//var upcustomer = customer.Select(n => n.name.ToUpper());
//foreach (var item in upcustomer)
//{
//    Console.WriteLine(item);
//}



using System;
using System.Linq;
using DataStore;
using DataStore.Models;


var customer = MyData.GetCustomers();


//Filtring: WHERE Function
//var highValueCustomers = customer.Where(o => o.orders.Any(p => p.products.Sum(s => s.price) > 500 && p.products.Sum(s => s.price) < 2000));
//foreach (var item in highValueCustomers)
//{
//    Console.WriteLine(item.name);
//}


// Projection: Select Funcation
//var upcustomer = customer.Select(n => n.name.ToUpper());
//foreach (var item in upcustomer)
//{
//    Console.WriteLine(item);
//}


//SelectMany Function
//var all = customer.SelectMany(o => o.orders).SelectMany(p => p.products);
//foreach (var item in all)
//{
//    Console.WriteLine($"{item.name} - {item.price}");
//}
//var allpro = customer.SelectMany(o => o.orders).SelectMany(p => p.products);
//foreach(var Or in allpro)
//{
//    Console.WriteLine($"{Or.name} -{Or.id}- {Or.price }");
//}

//Sorting: OrderBy
//var order = customer.SelectMany(o => o.orders).OrderBy(d => d.date).ToList();
//foreach (var item in order)
//{
//    Console.WriteLine(item.date);
//}

//OrderByDescending
//var order = customer.SelectMany(o => o.orders).SelectMany(p => p.products).OrderByDescending(s => s.price).ToList();
//foreach (var item in order)
//{
//    Console.WriteLine(item.price);
//}

//ThenBy ,ThenByDescending
//var order = customer.OrderBy(c => c.name).ThenBy(c => c.orders.Count).ToList();
//foreach (var item in order)
//{
//    Console.WriteLine(item.name);
//}


//Grouping: GroupBy
//var order = customer.SelectMany(o => o.orders).SelectMany(p => p.products).GroupBy(s => s.price).ToList();
//foreach (var group in order)
//{
//    //Key : for group
//    Console.WriteLine($"Price: {group.Key}");
//    foreach (var item in group)
//    {
//        Console.WriteLine($"Product Name: {item.name}");
//    }
//}

//ToLookup
//var order = customer.SelectMany(o => o.orders).SelectMany(p => p.products).ToLookup(s => s.price).ToList();
//foreach (var group in order)
//{
//    //Key : for group
//    Console.WriteLine($"Price: {group.Key}");
//    foreach (var item in group)
//    {
//        Console.WriteLine($"Product Name: {item.name}");
//    }
//}

//Aggregation
//sum
//var sumofprice = customer.SelectMany(o => o.orders).SelectMany(p=> p.products).Sum(s => s.price);

//    Console.WriteLine(sumofprice);
//count 
var countoforder = customer.SelectMany(o => o.orders).Count();

Console.WriteLine(countoforder);







//Joining 

//Element Operators

//Quntifier

//Set Operations

//Conversion

//Partitioning 

//Miscellaneous
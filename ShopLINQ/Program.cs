﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
//var countoforder = customer.SelectMany(o => o.orders).Count();
//     Console.WriteLine(countoforder);

//max
//var max = customer.SelectMany(o => o.orders).SelectMany(p => p.products).Max(s => s.price);
//Console.WriteLine(max);

//min
//var min = customer.SelectMany(o => o.orders).SelectMany(p => p.products).Min(s => s.price);
//Console.WriteLine(min);

//Average
//var ave = customer.SelectMany(o => o.orders).SelectMany(p => p.products).Average(s => s.price);
//Console.WriteLine(ave);


//Element Operators

//last
//var last = customer.Last();
//Console.WriteLine(last.name);

//lastordefault
//var lastordefault = customer.LastOrDefault();

//if (lastordefault != null)
//{
//    Console.WriteLine(lastordefault.name);
//}
//else
//    Console.WriteLine("Customer Not Found");

//first
//var first = customer.First();
//Console.WriteLine(first.name);


//firstordefault
//var firstordefault = customer.FirstOrDefault(n => n.name == "Radwa");
//if (firstordefault != null)
//{
//    Console.WriteLine(firstordefault.name);
//}
//else
//    Console.WriteLine("Customer Not Found");

//single
//var single = customer.Single(n => n.name == "Radwa");
//Console.WriteLine(single.name);

//singleorefault
//var singleorefault = customer.SingleOrDefault(n => n.name == "Radwa");
//if (singleorefault != null)
//{
//    Console.WriteLine(singleorefault.name);
//}
//else
//    Console.WriteLine("Customer Not Found");



//ElementAt
//var findcust = MyData.GetCustomers().ElementAt(4);
//Console.WriteLine(findcust.name);

//ElementAtOrDefault
//var findcustordefault = customer.ElementAtOrDefault(2);
//Console.WriteLine(findcustordefault.name);

//Quntifier

//Any
//var anyproduct = customer
//    .Any(c => c.orders.Any(o => o.products.Any(p => p.price > 2000)));
//Console.WriteLine(anyproduct);

//All
//var allHaveOneOrder = customer
//    .All(c => c.orders.Count == 9);
//Console.WriteLine(allHaveOneOrder);

//Contain
//var aliExists = customer
//    .Select(c => c.name)
//    .Contains("Ali");
//Console.WriteLine(aliExists);

//var ayaExists = customer
//    .Select(c => c.name)
//    .Contains("Aya");
//Console.WriteLine(ayaExists);


//Set Operations

//Conversion

//var customersList = MyData.GetCustomers().ToList();
//var customersArray = MyData.GetCustomers().ToArray();
//var customersDict = MyData.GetCustomers()
//    .ToDictionary(c => c.id, c => c.name);


//Partitioning 
//Take , Skip
//var skipFirstTwo = MyData.GetCustomers().Skip(2).Take(2).ToList();


//SkipWhile , TakeWhile
//var skipWhileNameStartsWithA = MyData.GetCustomers()
//    .SkipWhile(c => c.name.StartsWith("A"))
//    .ToList();

//var takeWhileNameStartsWithA = MyData.GetCustomers()
//    .TakeWhile(c => c.name.StartsWith("A"))
//    .ToList();

//Miscellaneous

//Reverse
//var reversedCustomers = MyData.GetCustomers().Reverse().ToList();

//DefaultIfEmpty
//var customersOrDefault = MyData.GetCustomers()
//    .Where(c => c.name == "NotExist")
//    .DefaultIfEmpty(new Customer { name = "No Customer" })
//    .ToList();





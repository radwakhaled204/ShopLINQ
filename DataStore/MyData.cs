namespace DataStore.Models;

public static class MyData
{
    public static List<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer
            {
                id = 1,
                name = "Salim",
                orders = new List<Order>
                {
                    new Order
                    {
                        id = 101,
                        date = DateTime.Now.AddDays(-10),
                        products = new List<Product>
                        {
                            new Product { id = 1, name = "Laptop", price = 1500 },
                            new Product { id = 2, name = "Mouse", price = 50 }
                        }
                    }
                }
            },
            new Customer
            {
                id = 2,
                name = "Ali",
                orders = new List<Order>
                {
                    new Order
                    {
                        id = 102,
                        date = DateTime.Now.AddDays(-5),
                        products = new List<Product>
                        {
                            new Product { id = 3, name = "Tab", price = 800 },
                            new Product { id = 4, name = "Monitor", price = 300 }
                        }
                    }
                }
            },
            new Customer
            {
                id = 3,
                name = "Azza",
                orders = new List<Order>
                {
                    new Order
                    {
                        id = 103,
                        date = DateTime.Now.AddDays(-7),
                        products = new List<Product>
                        {
                            new Product { id = 1, name = "Bed", price = 2500 },
                            new Product { id = 1, name = "Lamp", price = 500 },
                            new Product { id = 1, name = "Chair", price = 600 },
                            new Product { id = 1, name = "Table", price = 900 },
                            new Product { id = 1, name = "cups", price = 50 },
                            new Product { id = 1, name = "Dishes", price = 80 },
                            new Product { id = 2, name = "T-shirt", price = 20 }
                        }
                    }
                }
            },
            new Customer
            {
                id = 4,
                name = "Azza",
                orders = new List<Order>
                {
                    new Order
                    {
                        id = 104,
                        date = DateTime.Now.AddDays(-6),
                        products = new List<Product>
                        {
                            new Product { id = 1, name = "Bed", price = 2500 },
                            new Product { id = 1, name = "Lamp", price = 500 }

                        }
                    }
                }
            },
            new Customer
            {
                id = 5,
                name = "Radwa",
                orders = new List<Order>
                {
                    new Order
                    {
                        id = 105,
                        date = DateTime.Now.AddDays(-8),
                        products = new List<Product>
                        {
                            new Product { id = 1, name = "Laptop", price = 1800 },
                            new Product { id = 2, name = "Mouse", price = 50 },
                            new Product { id = 2, name = "keyboard", price = 70 },
                            new Product { id = 2, name = "USB", price = 20 }
                        }
                    }
                }
            }
        };
    }
}

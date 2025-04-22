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
                name = "Sara",
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
                            new Product { id = 3, name = "Keyboard", price = 80 },
                            new Product { id = 4, name = "Monitor", price = 300 }
                        }
                    }
                }
            }
        };
    }
}

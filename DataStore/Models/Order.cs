﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Models;

public class Order
{
    public int id { get; set; }
    public DateTime date { get; set; }
    public List<Product> products { get; set; }
}

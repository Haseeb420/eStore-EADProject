﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EStore.Shared
{
    public class Catalog
    {
        public List<Product> Products { get; set; }

        public Product GetProduct(int id) => Products.SingleOrDefault(p => p.Id == id);

    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime di, DateTime df)
        {
            return Sellers.Sum(seller => seller.TotalSales(di, df));
        }
    }
}

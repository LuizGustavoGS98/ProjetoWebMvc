﻿using ProjetoWebMvc.Data;
using ProjetoWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoWebMvc.Services
{
    public class SellerService
    {
        private readonly ProjetoWebMvcContext _context;

        public SellerService(ProjetoWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
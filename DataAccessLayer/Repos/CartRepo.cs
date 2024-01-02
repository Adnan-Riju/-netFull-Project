﻿using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class CartRepo : Repo, IRepo<Cart, int, Cart>
    {
        public Cart Create(Cart obj)
        {
            db.Carts.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Carts.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Cart> Read()
        {
            return db.Carts.ToList();
        }

        public Cart Read(int id)
        {
            return db.Carts.Find(id);
        }

        public Cart Update(Cart obj)
        {
            var ex = Read(obj.CartID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
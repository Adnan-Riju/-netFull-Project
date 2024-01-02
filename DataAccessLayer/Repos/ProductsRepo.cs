using DataAccessLayer.Interfaces;
using DataAccessLayer.Migrations;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    
        internal class ProductsRepo : Repo, IRepo<Products, int, Products>
        {
        public Products Create(Products obj)
        {
            db.Products.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Products.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Products> Read()
        {
            return db.Products.ToList();
        }

        public Products Read(int id)
        {
            return db.Products.Find(id);
        }

        public Products Update(Products obj)
        {
            var ex = Read(obj.ProductId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

    }
    }


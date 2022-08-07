using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GeneralStore
{
    public class ProductDal
    {
        public List<Product> GetAllProduct()
        {
            using(GeneralStoreContext context = new GeneralStoreContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetProductByName(string key)
        {
            using (GeneralStoreContext context = new GeneralStoreContext())
            {
                return context.Products.Where(p=>p.ProductName.Contains(key)).ToList();
            }
        }
        public List<Product> GetProductById(int keyId)
        {
            using (GeneralStoreContext context = new GeneralStoreContext())
            {
                return context.Products.Where(p =>p.Id == keyId).ToList();
            }
        }

        public List<Product> GetProductByPriceRange(decimal minPrice, decimal maxPrice)
        {
            using (GeneralStoreContext context = new GeneralStoreContext())
            {
                return context.Products.Where(p => p.ProductPrice >= minPrice && p.ProductPrice <= maxPrice).ToList();
            }
        }

        public void AddProduct(Product product)
        {
            using (GeneralStoreContext context = new GeneralStoreContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (GeneralStoreContext context = new GeneralStoreContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (GeneralStoreContext context= new GeneralStoreContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}

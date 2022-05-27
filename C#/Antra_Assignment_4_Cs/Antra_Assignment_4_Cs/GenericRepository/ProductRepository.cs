using System;
using Antra_Assignment_4_Cs.DataSet;
using Antra_Assignment_4_Cs.GenericRepository;

namespace Antra_Assignment_4_Cs.GenericRepository
{
	public class ProductRepository : IRepository<Product>
	{

        List<Product> listProduct = new List<Product>();

        public ProductRepository()
        {
            listProduct = new List<Product>();
        }


        public void Add(Product item)
        {
            listProduct.Add(item);
        }

        public IEnumerable<Product> GetAll()
        {
            return listProduct;
        }

        public Product GetByld(int id)
        {
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Id == id)
                {
                    return listProduct[i];
                }
            }
            return null;

        }

        public void Remove(Product item)
        {
            listProduct.Remove(item);
        }

        public void Save()
        {
            
        }
    }
}


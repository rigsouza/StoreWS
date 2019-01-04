using ABSCard.Data.Models;
using ABSCard.Data.Repository.Base;

namespace StoreWS.Repository.ProductRepository
{
    public class ProductRepository : RepositoryBase<Order>, IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context)
        {

        }
    }
}
using ABSCard.Data.Models;
using ABSCard.Data.Repository.Base;

namespace StoreWS.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(StoreContext context) : base(context)
        {

        }
    }
}
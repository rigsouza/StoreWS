using ABSCard.Data.Models;
using ABSCard.Data.Repository.Base;

namespace StoreWS.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(StoreContext context) : base(context)
        {

        }
    }
}
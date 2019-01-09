using Cedro.Data.Context;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Models;
namespace Cedro.Data.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(CedroContext context) : base(context)
        {
            
        }
    }
}
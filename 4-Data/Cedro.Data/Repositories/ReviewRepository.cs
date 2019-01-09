using Cedro.Data.Context;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Models;
namespace Cedro.Data.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(CedroContext context) : base(context)
        {
            
        }
    }
}
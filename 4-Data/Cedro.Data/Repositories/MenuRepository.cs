using Cedro.Data.Context;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Models;
namespace Cedro.Data.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(CedroContext context) : base(context)
        {
            
        }
    }
}
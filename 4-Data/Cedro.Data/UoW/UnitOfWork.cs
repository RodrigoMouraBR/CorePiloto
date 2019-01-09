using Cedro.Data.Context;

namespace Cedro.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CedroContext _context;
        public UnitOfWork(CedroContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
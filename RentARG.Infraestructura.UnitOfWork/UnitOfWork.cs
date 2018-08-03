using RentARG.Domain.Interfaces;
using RentARG.Infraestructura.Context;

namespace RentARG.Infraestructura.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RentARGContext _context;

        public UnitOfWork(RentARGContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

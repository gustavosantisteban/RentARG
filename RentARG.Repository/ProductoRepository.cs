using RentARG.Domain;
using RentARG.Infraestructura.Context;
using RentARG.Repository.Base;

namespace RentARG.Repository
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(RentARGContext context) : base(context)
        {
        }
    }
}

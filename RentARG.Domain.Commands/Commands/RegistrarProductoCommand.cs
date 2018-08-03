using RentARG.Aplicacion.ViewModels;

namespace RentARG.Domain.Commands
{
    public class RegistrarProductoCommand : ProductoCommand
    {
        public RegistrarProductoCommand(ProductoViewModel producto)
        {
            this.Nombre = producto.Nombre;
        }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}

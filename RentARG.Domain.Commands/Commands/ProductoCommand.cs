using RentARG.Aplicacion.ViewModels;
using RentARG.Domain.Core.Commands;
using System;

namespace RentARG.Domain.Commands
{
    public class ProductoCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Nombre { get; protected set; }

        public string Descripcion { get; protected set; }

        public DateTime FechaAlta { get; set; }


        public void RegistrarProductoCommand(ProductoViewModel producto)
        {
            //this.Nombre = producto.Nombre;
        }

        public void ActualizarProductoCommand(ProductoViewModel producto)
        {
            //this.Nombre = producto.Nombre;
        }

        public void EliminarProductoCommand(Guid productoid)
        {
            //this.Nombre = producto.Nombre;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

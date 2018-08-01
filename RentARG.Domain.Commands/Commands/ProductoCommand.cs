using RentARG.Domain.Core.Commands;
using System;

namespace RentARG.Domain.Commands.Commands
{
    public abstract class ProductoCommand : Command
    {
        public Guid Id { get; protected set; }

        public string Nombre { get; protected set; }

        public string Descripcion { get; protected set; }

        public DateTime FechaAlta { get; set; }
    }
}

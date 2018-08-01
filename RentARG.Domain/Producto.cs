using RentARG.Domain.Core.Models;
using System;

namespace RentARG.Domain
{
    public class Producto : Entity
    {
        public Producto()
        {
            this.Id = Guid.NewGuid();
        }

        public string Nombre { get; private set; }

        public string Descripcion { get; private set; }

        public DateTime FechaAlta { get; private set; }
    }
}

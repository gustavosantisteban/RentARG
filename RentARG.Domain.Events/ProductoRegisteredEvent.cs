using RentARG.Domain.Core.Events;
using System;

namespace RentARG.Domain.Events
{
    public class ProductoRegisteredEvent : Event
    {
        public ProductoRegisteredEvent(Guid id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            AggregateId = id;
        }
        public Guid Id { get; set; }

        public string Nombre { get; private set; }

        public string Descripcion { get; private set; }

    }
}

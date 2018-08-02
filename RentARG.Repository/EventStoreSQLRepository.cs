using RentARG.Domain.Core.Events;
using RentARG.Infraestructura.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentARG.Repository
{
    public class EventStoreSQLRepository : IEventStoreRepository
    {
        private readonly RentARGSQLContext _context;

        public EventStoreSQLRepository(RentARGSQLContext context)
        {
            _context = context;
        }

        public IList<StoredEvent> All(Guid aggregateId)
        {
            return (from e in _context.StoredEvent where e.AggregateId == aggregateId select e).ToList();
        }

        public void Store(StoredEvent theEvent)
        {
            _context.StoredEvent.Add(theEvent);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

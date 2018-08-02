﻿using RentARG.Domain.Core.Events;
using System;
using System.Collections.Generic;

namespace RentARG.Repository
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        IList<StoredEvent> All(Guid aggregateId);
    }
}

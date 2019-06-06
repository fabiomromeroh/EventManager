using EventManager.Entity;
using System;
using System.Collections.Generic;

namespace Data.Contracts
{
    public interface IEventRepository : IBaseRepository<Event>
    {
        List<Event> FilterEvents(DateTime? fromDate, DateTime? toDate);

    }
}

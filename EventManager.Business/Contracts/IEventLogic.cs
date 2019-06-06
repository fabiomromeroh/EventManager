using EventManager.Entity;
using System;
using System.Collections.Generic;

namespace Business.Contracts
{
    public interface IEventLogic: IBaseLogic<Event>
    {
        List<Event> FilterEvents(DateTime? fromDate, DateTime? toDate);


    }
}

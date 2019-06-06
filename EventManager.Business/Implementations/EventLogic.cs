using Business.Contracts;
using Data;
using Data.Contracts;
using EventManager.Entity;
using System;
using System.Collections.Generic;

namespace Business.Implementations
{
    public class EventLogic: BaseLogic<Event, EventRepository>, IEventLogic
    {
        private readonly IEventRepository eventRepository;

        public EventLogic(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public List<Event> FilterEvents(DateTime? fromDate, DateTime? toDate)
        {
            return this.eventRepository.FilterEvents(fromDate, toDate);
        }
    }
}

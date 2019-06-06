using Business.Contracts;
using Data.Contracts;
using Entities;
using System;
using System.Collections.Generic;

namespace Business.Implementations
{
    public class EventLogic: BaseLogic<Event>, IEventLogic
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

using Data.Base;
using Data.Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public List<Event> FilterEvents(DateTime? fromDate, DateTime? toDate)
        {
            using (AssesmentContext context = new AssesmentContext())
            {
                return context.Events
                    .Where(x => (toDate == null) || x.EndDate <= toDate)
                    .Where(x => (fromDate == null) || x.StartDate >= fromDate).ToList();
            }
        }
    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IEventLogic: IBaseLogic<Event>
    {
        List<Event> FilterEvents(DateTime? fromDate, DateTime? toDate);


    }
}

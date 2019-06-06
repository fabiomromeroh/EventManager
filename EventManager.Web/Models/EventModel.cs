using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagerAssesment.Models
{
    public class EventModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
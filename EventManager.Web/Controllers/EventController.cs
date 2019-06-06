using Business.Contracts;
using EventManager.Entity;
using EventManagerAssesment.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EventManagerAssesment.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventLogic eventLogic;

        public EventController(IEventLogic eventLogic)
        {
            this.eventLogic = eventLogic;
        }
        // GET: Event
        public ActionResult Index()
        {
            var events = this.eventLogic.GetAll();
            //we can use automapper here.
            return View(events);
        }

        public ActionResult New()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var eve = this.eventLogic.GetById(id);
            //We can use automapper here. 
            EventModel model = new EventModel()
            {
                ID = eve.ID,
                Name =eve.Name,
                Description = eve.Description,
                EndDate = eve.EndDate,
                StartDate = eve.StartDate
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult New(Event model)
        {
            try
            {

                this.eventLogic.Add(model);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

            return RedirectToAction("Index", "Event");
        }
        [HttpPost]
        public ActionResult Edit(Event model)
        {
            try
            {

                this.eventLogic.Update(model);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return RedirectToAction("Index", "Event");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {

                this.eventLogic.RemoveById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return RedirectToAction("Index", "Event");
        }

        [HttpGet]
        public JsonResult Search(string fromDate, string toDate)
        {
            List<Event> events = new List<Event>();
  
            var fDate = fromDate != "" ? Convert.ToDateTime(fromDate): (DateTime?)null;
            var tDate = toDate != "" ? Convert.ToDateTime(toDate) : (DateTime?)null;

            events = this.eventLogic.FilterEvents(fDate, tDate);

            return Json(events, JsonRequestBehavior.AllowGet);
        }
    }
}
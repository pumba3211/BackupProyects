using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiCharp.Models;

namespace ApiCharp.Controllers
{
    public class PilotsController : ApiController
    {
        private apicharpEntities db = new apicharpEntities();

        // GET: api/Pilots
        public IQueryable<pilot> Getpilot()
        {
            return db.pilot;
        }

        // GET: api/Pilots/5
        [ResponseType(typeof(pilot))]
        public IHttpActionResult Getpilot(int id)
        {
            pilot pilot = db.pilot.Find(id);
            if (pilot == null)
            {
                return NotFound();
            }

            return Ok(pilot);
        }

        // PUT: api/Pilots/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpilot(int id, pilot pilot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pilot.id)
            {
                return BadRequest();
            }

            db.Entry(pilot).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pilotExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pilots
        [ResponseType(typeof(pilot))]
        public IHttpActionResult Postpilot(pilot pilot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.pilot.Add(pilot);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pilot.id }, pilot);
        }

        // DELETE: api/Pilots/5
        [ResponseType(typeof(pilot))]
        public IHttpActionResult Deletepilot(int id)
        {
            pilot pilot = db.pilot.Find(id);
            if (pilot == null)
            {
                return NotFound();
            }

            db.pilot.Remove(pilot);
            db.SaveChanges();

            return Ok(pilot);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool pilotExists(int id)
        {
            return db.pilot.Count(e => e.id == id) > 0;
        }
    }
}
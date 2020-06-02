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
    public class DestinationsController : ApiController
    {
        private apicharpEntities db = new apicharpEntities();

        // GET: api/Destinations
        public IQueryable<destination> Getdestination()
        {
            return db.destination;
        }

        // GET: api/Destinations/5
        [ResponseType(typeof(destination))]
        public IHttpActionResult Getdestination(int id)
        {
            destination destination = db.destination.Find(id);
            if (destination == null)
            {
                return NotFound();
            }         
            return Ok(destination);
        }

        // PUT: api/Destinations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putdestination(int id, destination destination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != destination.id)
            {
                return BadRequest();
            }

            db.Entry(destination).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!destinationExists(id))
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

        // POST: api/Destinations
        [ResponseType(typeof(destination))]
        public IHttpActionResult Postdestination(destination destination)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.destination.Add(destination);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = destination.id }, destination);
        }

        // DELETE: api/Destinations/5
        [ResponseType(typeof(destination))]
        public IHttpActionResult Deletedestination(int id)
        {
            destination destination = db.destination.Find(id);
            if (destination == null)
            {
                return NotFound();
            }

            db.destination.Remove(destination);
            db.SaveChanges();

            return Ok(destination);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool destinationExists(int id)
        {
            return db.destination.Count(e => e.id == id) > 0;
        }
    }
}
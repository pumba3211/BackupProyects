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
    public class AirplanesController : ApiController
    {
        private apicharpEntities db = new apicharpEntities();

        // GET: api/Airplanes
        public IQueryable<airplane> Getairplane()
        {
            return db.airplane;
        }

        // GET: api/Airplanes/5
        [ResponseType(typeof(airplane))]
        public IHttpActionResult Getairplane(int id)
        {
            airplane airplane = db.airplane.Find(id);
            if (airplane == null)
            {
                return NotFound();
            }

            return Ok(airplane);
        }

        // PUT: api/Airplanes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putairplane(int id, airplane airplane)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != airplane.id)
            {
                return BadRequest();
            }

            db.Entry(airplane).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!airplaneExists(id))
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

        // POST: api/Airplanes
        [ResponseType(typeof(airplane))]
        public IHttpActionResult Postairplane(airplane airplane)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.airplane.Add(airplane);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = airplane.id }, airplane);
        }

        // DELETE: api/Airplanes/5
        [ResponseType(typeof(airplane))]
        public IHttpActionResult Deleteairplane(int id)
        {
            airplane airplane = db.airplane.Find(id);
            if (airplane == null)
            {
                return NotFound();
            }

            db.airplane.Remove(airplane);
            db.SaveChanges();

            return Ok(airplane);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool airplaneExists(int id)
        {
            return db.airplane.Count(e => e.id == id) > 0;
        }
    }
}
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
    public class ProgrammingsController : ApiController
    {
        private apicharpEntities db = new apicharpEntities();

        // GET: api/Programmings
        public IQueryable<Programming> GetProgramming()
        {
            return db.Programming;
        }

        // GET: api/Programmings/5
        [ResponseType(typeof(Programming))]
        public IHttpActionResult GetProgramming(int id)
        {
            Programming programming = db.Programming.Find(id);
            if (programming == null)
            {
                return NotFound();
            }

            return Ok(programming);
        }

        // PUT: api/Programmings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProgramming(int id, Programming programming)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != programming.id)
            {
                return BadRequest();
            }

            db.Entry(programming).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgrammingExists(id))
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

        // POST: api/Programmings
        [ResponseType(typeof(Programming))]
        public IHttpActionResult PostProgramming(Programming programming)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Programming.Add(programming);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = programming.id }, programming);
        }

        // DELETE: api/Programmings/5
        [ResponseType(typeof(Programming))]
        public IHttpActionResult DeleteProgramming(int id)
        {
            Programming programming = db.Programming.Find(id);
            if (programming == null)
            {
                return NotFound();
            }

            db.Programming.Remove(programming);
            db.SaveChanges();

            return Ok(programming);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProgrammingExists(int id)
        {
            return db.Programming.Count(e => e.id == id) > 0;
        }
    }
}
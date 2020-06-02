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
using SuperZapatosApi.Dal;
using SuperZapatosApi.Models;

namespace SuperZapatosP.Controllers
{
    public class StoresApiController : ApiController
    {
        private SuperZapatosContext db = new SuperZapatosContext();

        // GET: api/StoresApi
        public IQueryable<Store> GetStore()
        {
            return db.Store;
        }

        // GET: api/StoresApi/5
        [ResponseType(typeof(Store))]
        public IHttpActionResult GetStore(int id)
        {
            Store store = db.Store.Find(id);
            if (store == null)
            {
                return NotFound();
            }

            return Ok(store);
        }

        // PUT: api/StoresApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStore(int id, Store store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != store.StoreID)
            {
                return BadRequest();
            }

            db.Entry(store).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreExists(id))
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

        // POST: api/StoresApi
        [ResponseType(typeof(Store))]
        public IHttpActionResult PostStore(Store store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Store.Add(store);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = store.StoreID }, store);
        }

        // DELETE: api/StoresApi/5
        [ResponseType(typeof(Store))]
        public IHttpActionResult DeleteStore(int id)
        {
            Store store = db.Store.Find(id);
            if (store == null)
            {
                return NotFound();
            }

            db.Store.Remove(store);
            db.SaveChanges();

            return Ok(store);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StoreExists(int id)
        {
            return db.Store.Count(e => e.StoreID == id) > 0;
        }
    }
}
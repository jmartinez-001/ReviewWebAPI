using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ReviewWebAPI.Models;

namespace ReviewWebAPI.Controllers
{
    public class ReviewsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Reviews
        public IQueryable<ReviewDTO> GetReviews()
        {
            var reviews = from r in db.Reviews
                          select new ReviewDTO()
                          {
                              Id = r.Id,
                              Title = r.Title,
                              AuthorName = r.Author.FirstName + " " + r.Author.LastName
                          };
            return reviews;
        }

        // GET: api/Reviews/5
        [ResponseType(typeof(ReviewDTO))]
        public async Task<IHttpActionResult> GetReview(int id)
        {
            var review = await db.Reviews.Include(r => r.Author).Select(r => 
            new ReviewDetailDTO()
            {
                Id = r.Id,
                Title = r.Title,
                AuthorName = r.Author.FirstName + " " +r.Author.LastName,
                ContractorId = r.ContractorId,
                ClientId = r.ClientId,
                JobType = r.JobType,
                Content = r.Content,
                Date = r.Date,
                Rating = r.Rating,
                Budget = r.Budget,
                Helpful = r.Helpful,
                Comments = r.Comments,
                
            }).SingleOrDefaultAsync(r => r.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }

        // PUT: api/Reviews/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutReview(int id, Review review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != review.Id)
            {
                return BadRequest();
            }

            db.Entry(review).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(id))
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

        // POST: api/Reviews
        [ResponseType(typeof(ReviewDTO))]
        public async Task<IHttpActionResult> PostReview(Review review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reviews.Add(review);
            await db.SaveChangesAsync();

            db.Entry(review).Reference(x => x.Author).Load();

            var dto = new ReviewDTO()
            {
                Id = review.Id,
                Title = review.Title,
                AuthorName = review.Author.FirstName + " " + review.Author.LastName
            };

            return CreatedAtRoute("DefaultApi", new { id = review.Id }, dto);
        }

        // DELETE: api/Reviews/5
        [ResponseType(typeof(Review))]
        public async Task<IHttpActionResult> DeleteReview(int id)
        {
            Review review = await db.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            db.Reviews.Remove(review);
            await db.SaveChangesAsync();

            return Ok(review);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReviewExists(int id)
        {
            return db.Reviews.Count(e => e.Id == id) > 0;
        }
    }
}
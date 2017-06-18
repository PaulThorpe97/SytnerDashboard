using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SytnerDashboard.Models;

namespace SytnerDashboard.Controllers
{
    public class StaffReviewsController : Controller
    {
        private readonly SytnerDashboardContext _context;

        public StaffReviewsController(SytnerDashboardContext context)
        {
            _context = context;    
        }

        // GET: StaffReviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.StaffReview.ToListAsync());
        }

        // GET: StaffReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffReview = await _context.StaffReview
                .SingleOrDefaultAsync(m => m.ID == id);
            if (staffReview == null)
            {
                return NotFound();
            }

            return View(staffReview);
        }

        // GET: StaffReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StaffReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Forename,Surenamename,Productivity,WorkQuality,TechnicalSkills,Creativity,Attendance,CommunicationSkills,DateOfReview")] StaffReview staffReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffReview);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(staffReview);
        }

        // GET: StaffReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffReview = await _context.StaffReview.SingleOrDefaultAsync(m => m.ID == id);
            if (staffReview == null)
            {
                return NotFound();
            }
            return View(staffReview);
        }

        // POST: StaffReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Forename,Surenamename,Productivity,WorkQuality,TechnicalSkills,Creativity,Attendance,CommunicationSkills,DateOfReview")] StaffReview staffReview)
        {
            if (id != staffReview.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffReviewExists(staffReview.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(staffReview);
        }

        // GET: StaffReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffReview = await _context.StaffReview
                .SingleOrDefaultAsync(m => m.ID == id);
            if (staffReview == null)
            {
                return NotFound();
            }

            return View(staffReview);
        }

        // POST: StaffReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staffReview = await _context.StaffReview.SingleOrDefaultAsync(m => m.ID == id);
            _context.StaffReview.Remove(staffReview);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool StaffReviewExists(int id)
        {
            return _context.StaffReview.Any(e => e.ID == id);
        }
    }
}

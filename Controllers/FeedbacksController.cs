using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFMS.Data;
using CFMS.Models;
using Microsoft.AspNetCore.Authorization;
using CFMS.Data.Repositories;
using System.Xml;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using CFMS.Logger;

namespace CFMS.Controllers
{
    [Authorize]
    public class FeedbacksController : Controller
    {
        private readonly ILoggerService _logger;
        private readonly IMemoryCache _cache;
        private readonly IFeedbackRepository  _repository;


        public FeedbacksController(IFeedbackRepository repository, IMemoryCache memoryCache, ILoggerService logger)
        {
            _repository = repository;
            _cache = memoryCache;
            _logger = logger;
        }

        // GET: Feedbacks
        public async Task<IActionResult> Index()
        {
            //look for cahe data
            if (!_cache.TryGetValue("FeedbackList", out IEnumerable<Feedback> feedbackList))
                {
                    //get data
                    feedbackList = await _repository.GetByLastMonthList(DateTime.Now);
                    //cache data
                    _cache.Set("FeedbackList", feedbackList, TimeSpan.FromMinutes(1));    
                }

            return View(await _repository.GetByLastMonthList(DateTime.Now));
        }

        // GET: Feedbacks/ListPartial
        public async Task<IActionResult> ListPartial()
        {
            return PartialView("_List", await _repository.GetByLastMonthList(DateTime.Now));
        }

        // GET: Feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _repository.GetById(id);
            
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // GET: Feedbacks/Create
        public IActionResult Create()
        {
            return PartialView("_Create");
        }

        // POST: Feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Feedback feedback)
        {            

            if (ModelState.IsValid)
            {                
                await _repository.Create(feedback);

                return Json(feedback);
            }
            return Json("Create Feedback error");
        }

        // GET: Feedbacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _repository.GetById(id);
            if (feedback == null)
            {
                return NotFound();
            }
            return PartialView("_Edit", feedback);
        }

        // POST: Feedbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FeedbackId,CustomerName,Category,Description")] Feedback feedback)
        {
            if (id != feedback.FeedbackId)
            {
                return Json("Feedback not found");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Edit(feedback);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_repository.FeedbackExists(feedback.FeedbackId).Result)
                    {
                        return Json("Feedback not found");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return PartialView("_Edit",feedback);
        }

        // GET: Feedbacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _repository.GetById(id);
               
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedback = await _repository.GetById(id);

            if (id == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);    
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> FeedbackExists(int id)
        {
            return await _repository.FeedbackExists(id);
        }
    }
}

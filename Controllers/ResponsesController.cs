using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFMS.Data;
using CFMS.Models;
using CFMS.Data.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace CFMS.Controllers
{
    public class ResponsesController : Controller
    {       
        private readonly IResponseRepository _repository;

        public ResponsesController(IResponseRepository repository)
        {
            _repository = repository;           
        }

        // GET: Responses
        public async Task<IActionResult> Index()
        {           
            return View(await _repository.GetList());
        }

        // GET: Feedbacks/ListPartial
        public async Task<IActionResult> ListPartial(int id)
        {
            return PartialView("_List", await _repository.GetByFeedbackId(id));
        }

        // GET: Responses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _repository.GetById(id);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Responses/Create/5
        //Receives feedback Id to create the response
        public IActionResult Create(int id)
        {
            return PartialView("_Create", new Response { FeedbackId = id } );
        }

        // POST: Responses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Response response)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(response);

                return Json(response);
            }
            return Json("Create Response error");
        }

        // GET: Responses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _repository.GetById(id);
            if (response == null)
            {
                return NotFound();
            }
            return PartialView("_Edit", response);
        }

        // POST: Responses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResponseId,CustomerName,Description,FeedbackId")] Response response)
        {
            if (id != response.ResponseId)
            {
                return Json("Response not found");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Edit(response);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_repository.ResponseExists(response.ResponseId).Result)
                    {
                        return Json("Response not found");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return PartialView("_Edit", response);
        }

        // GET: Responses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _repository.GetById(id);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // POST: Responses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {          
            if (id == null)
            {
                return NotFound();
            }

            var response = await _repository.GetById(id);

            var feedbackId = response.FeedbackId;

            await _repository.Delete(id);

            return RedirectToAction(nameof(Details),"Feedbacks", new { id = feedbackId });
        }

        private async Task<bool> ResponseExists(int id)
        {
            return await _repository.ResponseExists(id);
        }
    }
}

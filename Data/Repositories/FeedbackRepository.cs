using CFMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMS.Data.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly ApplicationDbContext _context;

        public FeedbackRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Feedback>> GetList()
        {
            return await _context.FeedbackList.ToListAsync();
        }
        /// <summary>
        /// Return registered feedbacks in the las 30 days
        /// </summary>
        /// <param name="date">end date to get the list</param>
        /// <returns></returns>
        public async Task<IEnumerable<Feedback>> GetByLastMonthList(DateTime date)
        {
            date = date.AddDays(-30);

            var feedbackList = await _context.FeedbackList
                .Where(f => f.SubmissionDate.HasValue && f.SubmissionDate >= date)
                .OrderBy(o => o.Category).ThenBy(o => o.SubmissionDate)
                .ToListAsync();

            return feedbackList;            
        }               

        public async Task<Feedback> GetById(int? id)
        {
            var feedback = await _context.FeedbackList.Include(f => f.Responses)
                .FirstOrDefaultAsync(f => f.FeedbackId == id);

            return feedback;
        }

        public async Task<Feedback> Create(Feedback feedback)
        {
            _context.Add(feedback);
            await _context.SaveChangesAsync();

            return feedback;
        }

        public async Task<Feedback> Edit(Feedback feedback)
        {
            _context.Update(feedback);
            await _context.SaveChangesAsync();

            return feedback;
        }

        public async Task<bool> Delete(int id)
        {
            var feedback = await _context.FeedbackList.FindAsync(id);
            _context.FeedbackList.Remove(feedback);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> FeedbackExists(int id)
        {
            return await _context.FeedbackList.AnyAsync(s => s.FeedbackId ==id);
        }
    }
}

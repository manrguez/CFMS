using CFMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMS.Data.Repositories
{
    public class ResponseRepository : IResponseRepository
    {
        private readonly ApplicationDbContext _context;

        public ResponseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Response>> GetList()
        {
            return await _context.ResponseList.ToListAsync();
        }

        public async Task<IEnumerable<Response>> GetByFeedbackId(int id)
        {
            return await _context.ResponseList.Where(w => w.FeedbackId == id).ToListAsync();
        }

        public async Task<Response> GetById(int? id)
        {
            var response = await _context.ResponseList
                .FirstOrDefaultAsync(f => f.ResponseId == id);

            return response;
        }

        public async Task<Response> Create(Response response)
        {
            _context.Add(response);
            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<Response> Edit(Response response)
        {
            _context.Update(response);
            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<bool> Delete(int id)
        {
            var response = await _context.ResponseList.FindAsync(id);
            _context.ResponseList.Remove(response);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> ResponseExists(int id)
        {
            return await _context.ResponseList.AnyAsync(s => s.ResponseId == id);
        }
    }
}

using CFMS.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CFMS.Data.Repositories
{
    public interface IFeedbackRepository
    {
        Task<Feedback> Create(Feedback feedback);
        Task<bool> Delete(int id);
        Task<Feedback> Edit(Feedback feedback);
        Task<Feedback> GetById(int? id);
        Task<IEnumerable<Feedback>> GetList();
        Task<IEnumerable<Feedback>> GetByLastMonthList(DateTime date);
        Task<bool> FeedbackExists(int id);
    }
}
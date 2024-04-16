using CFMS.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CFMS.Data.Repositories
{
    public interface IResponseRepository
    {
        Task<Response> Create(Response response);
        Task<bool> Delete(int id);
        Task<Response> Edit(Response response);
        Task<Response> GetById(int? id);        
        Task<IEnumerable<Response>> GetList();
        Task<IEnumerable<Response>> GetByFeedbackId(int id);
        Task<bool> ResponseExists(int id);
    }
}
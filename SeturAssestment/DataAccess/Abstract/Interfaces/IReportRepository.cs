using Core.Entities.Concrete.ContactEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DataAccess.Abstract
{
    public interface IReportRepository
    {
        IQueryable<Report> GetAll();
        Report Get(Guid id);
        Task<Report> AddAsync(Report report);
        Task UpdateAsync(Report report);
    }
}

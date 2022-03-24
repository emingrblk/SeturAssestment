using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete.ContactEntities;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class ReportRepository:IReportRepository
    {
        private readonly SeturAssesmentDbContext _context;

        public ReportRepository(SeturAssesmentDbContext context)
        {
            _context = context;
        }

        public IQueryable<Report> GetAll()
        {
            return _context.Reports.Include(q=>q.ReportStatus);
        }

        public Report Get(Guid id)
        {
            return _context.Reports.Include(q => q.ReportStatus).FirstOrDefault(q=>q.Id==id);
        }

        public async Task<Report> AddAsync(Report report)
        {
            await _context.AddAsync(report);
            await _context.SaveChangesAsync();

            return report;
        }

        public async Task UpdateAsync(Report report)
        {
            var existingEntity = await _context.Reports.FindAsync(report.Id);
             _context.Entry(existingEntity).CurrentValues.SetValues(report);
            await _context.SaveChangesAsync();
        }
    }
}

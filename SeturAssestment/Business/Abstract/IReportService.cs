using Core.Entities.Concrete.ContactEntities;
using Core.Utilities.Results;
using Core.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Business.Abstract
{
    public interface IReportService
    {
        IDataResult<IList<Report>> GetAll();
        IDataResult<Report> Get(Guid id);
        Task<IDataResult<Report>> AddAsync(Report report);
        Task<IDataResult<string>> GetReportBodyAsync(ResponseModel model);
        Task<IResult> UpdateAsync(Report report);


    }
}

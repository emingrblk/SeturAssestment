using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Core.Entities.Concrete.ContactEntities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Business.Abstract;
using SeturAssessment.ContactService.Utilities.Constants;
using Core.Utilities.DTOs;
using Core.Utilities.Results;
using Core.Utilities.ViewModels;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IConfiguration _configuration;
        public ReportManager(IReportRepository reportRepository, IConfiguration configuration)
        {
            _reportRepository = reportRepository;
            _configuration = configuration;
        }

        public IDataResult<IList<Report>> GetAll()
        {
            var query = _reportRepository.GetAll().ToList();
            return new SuccessDataResult<List<Report>>(query, Messages.ReportsGet);

        }

        public IDataResult<Report> Get(Guid id)
        {
            var query = _reportRepository.Get(id);
            return new SuccessDataResult<Report>(query, Messages.ReportGet);

        }

        public async Task<IDataResult<Report>> AddAsync(Report report)
        {
            var query = await _reportRepository.AddAsync(report);
            return new SuccessDataResult<Report>(query, Messages.ReportAdded);

        }

      

        public async Task<IDataResult<string>> GetReportBodyAsync(ResponseModel model)
        {
           
            IList<ReportBody> query = new List<ReportBody>();
            var locationList = model.ContactInformationModels.Select(q => q.Location).Distinct();
            foreach (var location in locationList.Where(q=>model.location == null || q==model.location ))
            {
                var x = new ReportBody
                {
                    Location = location,
                    ContactCount = model.ContactInformationModels.Count(q => q.Location==location),
                    PhoneNumberCount = model.ContactInformationModels.Where(q=>!String.IsNullOrEmpty(q.Phone)).Count(q=>q.Location==location),
                };
                query.Add(x);
            }
         

            return new SuccessDataResult<string>(JsonConvert.SerializeObject(query), Messages.ReportBodyCreated);


        }

        public async  Task<IResult> UpdateAsync(Report report)
        {
            await _reportRepository.UpdateAsync(report);
            return new SuccessResult(Messages.ReportUpdated);
        }
    }
}

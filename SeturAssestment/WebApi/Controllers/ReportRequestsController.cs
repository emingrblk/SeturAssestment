
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeturAssessment.ContactService.Utilities.Constants;
 
using Core.Entities.ViewModels;
using SeturAssessment.ContactService.Business.Abstract;
using Business.MessageBrokers.RabbitMq;
using Microsoft.AspNetCore.Authorization;

namespace SeturAssessment.ContactService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportRequestsController : ControllerBase
    {
        private readonly IMessageBrokerHelper _messageBrokerHelper;
        private readonly IContactInformationService _contactInformationService;
        public ReportRequestsController(IMessageBrokerHelper messageBrokerHelper, IContactInformationService contactInformationService)
        {
            _messageBrokerHelper = messageBrokerHelper;
            _contactInformationService = contactInformationService;
        }


        [HttpPost("RequestReport/{location}")]
        public async Task<IActionResult> RequestReportWithLocation(string location)
        {
            var result = await _contactInformationService.GetContactDetailsAsync();
            if (result.IsSuccess)
            {
                ReportRequestModelWithLocation reportRequestModel = new ReportRequestModelWithLocation();
                reportRequestModel.ContactInformations = result.Data.ToList();
                reportRequestModel.location = location;
                _messageBrokerHelper.QueueMessage(reportRequestModel);
                return Ok($"{location} {Messages.ReportRequestCreatedForLocation}");
            }
            return BadRequest(new { Message = result.Message });

        }
    }
}

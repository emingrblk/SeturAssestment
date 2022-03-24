 
using Microsoft.AspNetCore.Mvc;
using System; 
using System.Threading.Tasks;
using AutoMapper;
using SeturAssessment.ContactService.Business.Abstract;
using Entities.Concrete.ContactInformationEntities;
using Microsoft.AspNetCore.Authorization;

namespace SeturAssessment.ContactService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInformationController : ControllerBase
    {
        private readonly IContactInformationService _ContactInformationManager;
 

        public ContactInformationController(IContactInformationService ContactInformationManager)
        { 
            _ContactInformationManager = ContactInformationManager;
        }


        [HttpPost("add/{contactId}")]
        public async Task<IActionResult> Add(Guid contactId, ContactInformation ContactInformation)
        {
         
            ContactInformation.ContactId = contactId;
            var result = await _ContactInformationManager.AddAsync(ContactInformation);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            return BadRequest(new { Message = result.Message });



        }

        [HttpPost("update/{contactId}")]
        public async Task<IActionResult> Update(Guid contactId, ContactInformation ContactInformation)
        {
         
            ContactInformation.ContactId = contactId;
            var result = await _ContactInformationManager.UpdateAsync(ContactInformation);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            return BadRequest(new { Message = result.Message });
        }


        [HttpPost("delete/{ContactInformationId}")]

        public async Task<IActionResult> Delete(Guid ContactInformationId)
        {
            var result = await _ContactInformationManager.DeleteAsync(ContactInformationId);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            return BadRequest(new { Message = result.Message });
        }

    }
}

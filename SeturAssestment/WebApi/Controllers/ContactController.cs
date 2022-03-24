using AutoMapper;
using Entities.Concrete.ContactEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeturAssessment.ContactService.Business.Abstract;
using SeturAssessment.ContactService.Business.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
     


        public ContactController(IContactService contactService )
        {
            _contactService = contactService;

        }           
       
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var result = await _contactService.GetAllAsync();
            if (result.IsSuccess)
            {
           
                return Ok(result.Data);
            }
            return BadRequest(new { Message = result.Message });
        }
          [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _contactService.GetAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(new { Message = result.Message });

        }
         
        [HttpPost("add")]
        public async Task<IActionResult> Add(Contact contact)
        {
   
            var result = await _contactService.AddAsync(contact);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            return BadRequest(new { Message = result.Message });



        }
        
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] Contact contact)
        {
          
            var result = await _contactService.UpdateAsync(contact);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            return BadRequest(new { Message = result.Message });
        }
       
        [HttpPost("delete/{id}")]

        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _contactService.DeleteAsync(id);
            if (result.IsSuccess)
            {
                return Ok(new { Message = result.Message });
            }
            return BadRequest(new { Message = result.Message });
        }
    }
}

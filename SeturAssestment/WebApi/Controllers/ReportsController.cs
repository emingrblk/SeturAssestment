using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq; 
using AutoMapper;
using Business.Abstract;
using Core.Entities.Concrete.ContactEntities;
using Microsoft.AspNetCore.Authorization;

namespace SeturAssessment.ReportService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;
       

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
          
        }


        [HttpGet]
        public IActionResult Get()
        {

            var result = _reportService.GetAll();
            if (result.IsSuccess)
            {

                return Ok(result.Data.ToList());
            }
            return BadRequest(new { Message = result.Message });
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _reportService.Get(id);
             if (result.IsSuccess)
            { 
                return Ok(result);
            }
            return BadRequest(new { Message = result.Message });

        }


    }
}

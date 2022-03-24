using System;
using System.Collections.Generic;
using Core.Entities;
using Newtonsoft.Json;
using Core.Utilities.DTOs;

namespace Core.Entities.Concrete.ContactEntities
{
    public class Report : IEntity
    {
        public Guid Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public int ReportStatusId { get; set; }
        public ReportStatus ReportStatus { get; set; }
        public int ContactCount { get; set; }
        public int PhoneNumberCount { get; set; }
        public string Location{ get; set; }




    }
}

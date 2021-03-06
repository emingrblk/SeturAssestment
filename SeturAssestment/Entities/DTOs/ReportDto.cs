using System;
using System.Collections.Generic; 

namespace Entities.DTOs
{
    public class ReportDto
    {
        public Guid Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public string StatusName { get; set; }
        public List<ReportBody> ReportBody { get; set; }
    }
}

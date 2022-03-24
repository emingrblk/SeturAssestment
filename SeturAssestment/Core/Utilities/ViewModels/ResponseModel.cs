
using Core.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Core.Utilities.ViewModels
{
    public class ResponseModel
    {
        public List<ContactInformationModel> ContactInformationModels { get; set; }
        public string location { get; set; }
    }
}

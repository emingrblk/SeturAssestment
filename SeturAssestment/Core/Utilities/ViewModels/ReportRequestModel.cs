using Entities.Concrete.ContactEntities;
using Entities.Concrete.ContactInformationEntities;
using System.Collections.Generic;

namespace Core.Entities.ViewModels
{
    public class ReportRequestModel: IRequestModel
    {
        public List<ContactInformation> ContactInformations{ get; set; }
    }
}

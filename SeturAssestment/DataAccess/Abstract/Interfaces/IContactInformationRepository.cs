using Entities.Concrete.ContactInformationEntities;
using System; 

namespace SeturAssessment.ContactService.DataAccess.Abstract
{
    public interface IContactInformationRepository: IEntityRepository<ContactInformation, Guid>
    {
       
    }
}

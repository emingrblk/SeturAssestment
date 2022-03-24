using System;  
using Core.DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.ContactInformationEntities;
using SeturAssessment.ContactService.DataAccess.Abstract; 

namespace SeturAssessment.ContactService.DataAccess.Concrete
{
    public class ContactInformationRepository : EntityRepository<ContactInformation, Guid, SeturAssesmentDbContext>, IContactInformationRepository
    {
        public ContactInformationRepository(SeturAssesmentDbContext context) : base(context)
        {
        }
    }
}

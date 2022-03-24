 
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.ContactEntities;
using SeturAssessment.ContactService.DataAccess.Abstract;
using System;
using Core.DataAccess.Concrete;
namespace SeturAssessment.ContactService.DataAccess.Concrete
{
    public class ContactRepository: EntityRepository<Contact,Guid, SeturAssesmentDbContext>, IContactRepository
    {
        public ContactRepository(SeturAssesmentDbContext context) : base(context)
        {
        }

     
    }
}

using System;
using Entities.Concrete.ContactEntities;

namespace SeturAssessment.ContactService.DataAccess.Abstract
{
    public interface IContactRepository : IEntityRepository<Contact,Guid>
    {
    }
}

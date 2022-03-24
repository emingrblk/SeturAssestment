using Core.DataAccess;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using SeturAssessment.ContactService.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserRepository : IEntityRepository<User,Guid>
     {
        
       
    }
}

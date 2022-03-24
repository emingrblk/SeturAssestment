
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;

using Core.DataAccess.Concrete;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{

    public class UserRepository : EntityRepository<User, Guid, SeturAssesmentDbContext>, IUserRepository
    {
        public UserRepository(SeturAssesmentDbContext context) : base(context)
        { 
             
        }
        
    }
}

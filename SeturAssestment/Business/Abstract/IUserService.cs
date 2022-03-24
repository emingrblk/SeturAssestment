using Core.Entities.Concrete;
using SeturAssessment.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {

        List<OperationClaim> GetClaims(User user);
        
        Task<IResult> AddAsync(User contact);


        Task<IDataResult<User>> GetByMailAsync(string email);

    }
}

 
using Entities.Concrete.ContactEntities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeturAssessment.ContactService.Business.Abstract
{
    public interface IContactService
    {
        Task<IDataResult<IList<Contact>>> GetAllAsync();
        Task<IDataResult<Contact>> GetAsync(Guid id);
        Task<IResult> AddAsync(Contact contact);
        Task<IResult> UpdateAsync(Contact contact);
        Task<IResult> DeleteAsync(Guid id);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Entities.Concrete.ContactInformationEntities;
using SeturAssessment.ContactService.Business.Abstract;
using SeturAssessment.ContactService.DataAccess.Abstract;
using SeturAssessment.ContactService.Utilities.Constants;
using Core.Utilities.Results;

namespace SeturAssessment.ContactService.Business.Concrete
{
    public class ContactInformationManager : IContactInformationService
    {
        private readonly IContactInformationRepository _contactInformationRepository;

        public ContactInformationManager(IContactInformationRepository contactInformationRepository)
        {
            _contactInformationRepository = contactInformationRepository;
        }

        public async Task<IDataResult<IList<ContactInformation>>> GetContactDetailsAsync()
        {
            var query = await _contactInformationRepository.GetAllAsync();
            return new SuccessDataResult<IList<ContactInformation>>(query.ToList(), Messages.ContactsDetailGet);
        }

        public async Task<IResult> AddAsync(ContactInformation contactDetail)
        {
            await _contactInformationRepository.AddAsync(contactDetail);
            return new SuccessResult(Messages.ContactDetailAdded);
        }

        public async Task<IResult> UpdateAsync(ContactInformation contactDetail)
        {
            await _contactInformationRepository.UpdateAsync(contactDetail, contactDetail.Id);
            return new SuccessResult(Messages.ContactDetailUpdated);
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _contactInformationRepository.DeleteAsync(id);
            return new SuccessResult(Messages.ContactDetailDeleted);
        }
    }
}

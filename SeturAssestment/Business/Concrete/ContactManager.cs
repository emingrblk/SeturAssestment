using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Entities.Concrete.ContactEntities;
using SeturAssessment.ContactService.Business.Abstract;
using SeturAssessment.ContactService.DataAccess.Abstract;
using SeturAssessment.ContactService.Utilities.Constants;
using Core.Utilities.Results;

namespace SeturAssessment.ContactService.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IDataResult<IList<Contact>>> GetAllAsync()
        {
            var query = await _contactRepository.GetAllAsync("ContactInformations");
            return new SuccessDataResult<IList<Contact>>(query.ToList(), Messages.ContactsGet);
        }

        public async Task<IDataResult<Contact>> GetAsync(Guid id)
        {
            var query = await _contactRepository.GetAsync(q => q.Id == id, "ContactInformations");
            return new SuccessDataResult<Contact>(query, Messages.ContactGet);
        }

        public async Task<IResult> AddAsync(Contact contact)
        {
            await _contactRepository.AddAsync(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public async Task<IResult> UpdateAsync(Contact contact)
        {
            await _contactRepository.UpdateAsync(contact, contact.Id);
            return new SuccessResult(Messages.ContactUpdated);
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _contactRepository.DeleteAsync(id);
            return new SuccessResult(Messages.ContactDeleted);
        }


    }
}


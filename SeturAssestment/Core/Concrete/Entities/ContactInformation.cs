
using Core.Entities;
using System;
 
namespace Entities.Concrete.ContactInformationEntities
{
    public class ContactInformation : IEntity
    {
        public Guid Id { get; set; }
        public string Phone { get; set; }

        public string EMail { get; set; }
      
        public string Location { get; set; }

     
        public string Description { get; set; }

       
        public Guid ContactId { get; set; }
    }
}

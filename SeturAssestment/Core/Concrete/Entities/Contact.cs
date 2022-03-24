using Core.Entities;
using Entities.Concrete.ContactInformationEntities;
using System;
using System.Collections.Generic;
 

namespace Entities.Concrete.ContactEntities
{
    public class Contact : IEntity
    {
       
        public Guid Id{ get; set; }
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public string Company { get; set; }

        public virtual ICollection<ContactInformation> ContactInformations { get; set; }
    }
}

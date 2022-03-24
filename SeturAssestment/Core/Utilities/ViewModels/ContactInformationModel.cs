using System;

namespace Core.Entities.ViewModels
{
    public class ContactInformationModel 
    {
        public Guid Id { get; set; }
        public Guid ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}

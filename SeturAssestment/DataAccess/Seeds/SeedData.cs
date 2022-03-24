using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.ContactEntities;
using Entities.Concrete.ContactInformationEntities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SeturAssessment.DataAccess.Concrete.EntityFrameworkCore.Seeds
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {

            var context = app.ApplicationServices.GetRequiredService<SeturAssesmentDbContext>();

            context.Database.Migrate();


            if (!context.Contacts.Any())
            {
                var contacts = new[]
                {
                    new Contact() { Name = "Hilmi" , Surname = "Yazıcı", Company = "Natro", ContactInformations =
                        new List<ContactInformation>()
                        {
                            new ContactInformation(){Phone = "0554011220",EMail = "hilmi@yazici.com",Location = "İstanbul"},
                            new ContactInformation(){Phone = "0535411234",EMail = "hilmi2@yazici.com",Location = "Ankara"}

                         }
                    },

                    new Contact() { Name = "Ersin" , Surname = "Düzen", Company = "Vestel", ContactInformations =
                        new List<ContactInformation>()
                        {
                            new ContactInformation(){Phone = "0534442344",EMail = "ersin@aduzen.com",Location = "İstanbul"},
                            new ContactInformation(){Phone = "0565333332",EMail = "ersin@aduzen.com",Location = "İstanbul"}

                        }
                    },

                    new Contact() { Name = "Burcu" , Surname = "Kaya", Company = "Youtube", ContactInformations =
                        new List<ContactInformation>()
                        {
                            new ContactInformation(){Phone = "05445544332",EMail = "brcu@kaya.com",Location = "İzmir"},
                            new ContactInformation(){Phone = "05555415446",EMail = "burcu@kayagunes.com",Location = "Ankara"}

                        }
                    },


                    new Contact() { Name = "Sevgi" , Surname = "Özer", Company = "Linkedin", ContactInformations =
                        new List<ContactInformation>()
                        {
                            new ContactInformation(){Phone = "06452223344",EMail = "sevgi@ozer.com",Location = "İstanbul"},
                            new ContactInformation(){Phone = "06452223322",EMail = "svg@ozer.com",Location = "Antalya"}

                        }
                    },

                    new Contact() { Name = "Mithat" , Surname = "Yakar", Company = "Atv", ContactInformations =
                        new List<ContactInformation>()
                        {
                            new ContactInformation(){Phone = "0535784455",EMail = "mithat@yakar.com",Location = "İstanbul"},
                            new ContactInformation(){Phone = "05465234493",EMail = "mithat@ykr.com",Location = "Bursa"}

                        }
                    },


                };

                context.AddRange(contacts);



                var operationClaim =
              new OperationClaim()
              {
                  Name = "admin"

              };
                var operationClaimEntity = context.Add(operationClaim);

                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash("Asd123", out passwordHash, out passwordSalt);
                var user =
                    new User()
                    {
                        FirstName = "Admin",
                        LastName = "Admin",
                        PasswordSalt = passwordSalt,
                        PasswordHash = passwordHash,
                        Status = true,
                        Email = "admin@admin.com"
                    };

                var userEntity = context.Add(user);


                var userOperationClaim =
                new UserOperationClaim()
                {
                    UserId = userEntity.Entity.Id,
                    OperationClaimId = operationClaimEntity.Entity.Id
                };
                context.Add(userOperationClaim);


                context.SaveChanges();



            }





        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CroytonStoreFront.Database.Entities;
using CroytonStoreFront.Models;
using CroytonStoreFront.Database;

namespace CroytonStoreFront.Repositories
{
    public class ContactFormRerpository
    {
        public bool InsertContactInformation(ContactFormViewModel model)
        {
            bool toReturn;
            try
            {
                using (var ctx = new CroytonDbContext())
                {
                    ContactForm contact = new ContactForm();
                    contact.FullName = model.FullName;
                    contact.Email = model.Email;
                    contact.PhoneNumber = model.PhoneNumber;
                    contact.Website = model.Website;
                    contact.Message = model.Message;
                    contact.CreatedOn = model.CreatedOn;
                    contact.UpdatedOn = model.UpdatedOn;
                    contact.Status = model.Status;
                    ctx.ContactForms.Add(contact);
                    ctx.SaveChanges();
                    toReturn = true;
                }
            }
            catch (Exception ex)
            {
                toReturn = false;

            }
            return toReturn;
        }
    }
}
using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();
        public int BLContactAdd(Contact c)
        {
            if (c.Mail == "" || c.Message == "" || c.Mail.Length <= 5 || c.Name == "" || c.SurName == ""||c.Subject==""||c.Subject.Length<=2)
            {
                return -1;
            }
            return repocontact.Insert(c);
        }
        public List<Contact> GetAll()
        {
            return repocontact.List();
        }
        public Contact GetContactDetails(int id)
        {
            return repocontact.Find(x => x.ContactID == id);

        }
    }
}

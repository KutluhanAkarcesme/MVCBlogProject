using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
                _contactDal = contactDal;
        }
        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(x => x.ContactId == id);
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}

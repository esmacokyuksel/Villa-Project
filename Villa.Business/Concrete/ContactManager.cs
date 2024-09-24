using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        public ContactManager(DataAccess.Abstract.IGenericDal<Contact> genericDal) : base(genericDal)
        {
        }
    }
}

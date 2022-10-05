using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTP
{
    public class Capas
    {
        private DataAcces _dataAcces;

        public Capas() 
        {
            _dataAcces = new DataAcces();
        }
        public Contacts SaveContact(Contacts contact)
        {
            if (contact.Id == 0)
                _dataAcces.InsertContact(contact);
            else
                _dataAcces.UpdateContacts(contact);

                    return contact;

        }
        public List<Contacts> GetContacts(string searchText = null)
        {
            return _dataAcces.GetContacts(searchText);
        }
        public void DeleteContacts(int id)
        {
            _dataAcces.DeleteContacts(id);
        }
    }
   
}

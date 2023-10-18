using AgendaDeContactos.Data.Implementations;

namespace AgendaDeContactos.Services
{
    public class ContactService
    {
        private readonly AgendaContext _context;
        public ContactService(AgendaContext context)
        {
            _context = context;

        }

        public List<Contact> GetContacts(int id)
        {
            return _context.Contacts.ToList();
        }
        public Contact? GetContact(int id)
        {
            return _context.Contacts.FirstOrDefault();
        }
        public bool DeleteContact(int id)
        {
            Contact contactToDelete = GetContact(id);
            if (contactToDelete != null)
            {
                _context.Contacts.Remove(contactToDelete);
                return true;
            }
            return false;
        } 


        public Contact UpdateContact(Contact contactToUpdate)
        {
            Contact updatedContacts = _context.Update(contactToUpdate).Entity;
            return updatedContacts;
        }
       
    }
}

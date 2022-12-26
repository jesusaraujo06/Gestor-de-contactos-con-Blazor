using Blazor.Contacts.Wasm.Shared;

namespace Blazor.Contacts.Wasm.Client.Services
{
    public interface IContactService
    {
        Task SaveContact(Contact contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contact>> GetAllContacts();
        Task<Contact> GetContactById(int id);
    }
}

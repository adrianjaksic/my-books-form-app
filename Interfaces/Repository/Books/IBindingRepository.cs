using Models.Books;
using System.Collections.Generic;

namespace Interfaces.Repository.Books
{
    public interface IBindingRepository
    {
        /// <summary>
        /// Returns bindings
        /// </summary>
        /// <returns>Bindings</returns>
        IEnumerable<Binding> GetBindings();
    }
}

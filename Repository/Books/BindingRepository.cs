using Core;
using Interfaces.Repository.Books;
using Models.Books;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Books
{
    public class BindingRepository : IBindingRepository
    {
        public IEnumerable<Binding> GetBindings()
        {
            var bindings = AppSettings.BindingsValues.Split(',');
            return bindings.Select(x => new Binding()
            {
                Name = x,
            }).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary;

namespace Adapter
{
    public partial class ApiClient
    {
        public async Task<List<ContactModel>> GetContacts()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, 
                "User/GetAllUsers"));
            return await GetAsync<List<ContactModel>>(requestUrl);
        }
    }
}

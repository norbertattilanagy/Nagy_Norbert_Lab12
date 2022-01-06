using Nagy_Norbert_Lab12.Data;
using Nagy_Norbert_Lab12.Models;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace Nagy_Norbert_Lab12
{
    public class ShoppingListDatabase
    {
        private RestService restService;

        public ShoppingListDatabase(RestService restService)
        {
            this.restService = restService;
        }

        internal Task<IEnumerable> GetShopListsAsync()
        {
            throw new NotImplementedException();
        }

        internal Task SaveShopListAsync(ShopList slist)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteShopListAsync(ShopList slist)
        {
            throw new NotImplementedException();
        }
    }
}
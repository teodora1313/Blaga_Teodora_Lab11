﻿using System.Threading.Tasks;
using Blaga_Teodora_Lab11.Models;

namespace Blaga_Teodora_Lab11.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }

        public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }

        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }
    }
}

using System.Threading.Tasks;
using Blaga_Teodora_Lab11.Models;

namespace Blaga_Teodora_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}

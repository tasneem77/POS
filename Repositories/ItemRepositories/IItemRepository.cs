using POS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Repositories.ItemRepositories
{
   public interface IItemRepository
    {
        IEnumerable<ItemMaster> GetAll();
        ItemMaster GetById(int id);
        ItemMaster Find(int id);
        void Add(ItemMaster itemMaster);
        void Update(ItemMaster itemMaster);
        void Delete(int id);
        void Save();
    }
}

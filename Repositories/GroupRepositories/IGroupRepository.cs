using POS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Repositories.GroupRepositories
{
   public interface IGroupRepository
    {
        IEnumerable<ItemGroup> GetAll();
        ItemGroup GetById(string id);
        ItemGroup Find(string id);
        void Add(ItemGroup itemGroup);
        void Update(ItemGroup itemGroup);
        void Delete(string id);
        void Save();
    }
}

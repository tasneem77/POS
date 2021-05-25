using POS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Repositories.GroupRepositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly EZSportsContext _context;
        public GroupRepository(EZSportsContext context)
        {
            _context = context;
        }
        public void Add(ItemGroup itemGroup)
        {
            _context.ItemGroups.Add(itemGroup);
        }

        public void Delete(string id)
        {
            ItemGroup itemGroup = Find(id);
            _context.ItemGroups.Remove(itemGroup);

        }

        public ItemGroup Find(string id)
        {
            return _context.ItemGroups.Find(id);
        }

        public IEnumerable<ItemGroup> GetAll()
        {
            return _context.ItemGroups.ToList();
        }

        public ItemGroup GetById(string id)
        {
            return _context.ItemGroups.Where(a => a.Code == id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
            
        }

        public void Update(ItemGroup itemGroup)
        {
            _context.Entry(itemGroup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;   
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

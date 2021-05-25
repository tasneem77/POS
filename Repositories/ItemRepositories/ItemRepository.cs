using POS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_API.Repositories.ItemRepositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly EZSportsContext _context;
        public ItemRepository(EZSportsContext context)
        {
            _context = context;
        }
        public void Add(ItemMaster itemMaster)
        {
            _context.ItemMasters.Add(itemMaster);
        }

        public void Delete(int id)
        {
            ItemMaster itemMaster = Find(id);
            _context.ItemMasters.Remove(itemMaster);
        }

        public ItemMaster Find(int id)
        {
            return _context.ItemMasters.Find(id);
        }

        public IEnumerable<ItemMaster> GetAll()
        {
            return _context.ItemMasters.ToList();
        }

        public ItemMaster GetById(int id)
        {
            return _context.ItemMasters.Where(a => a.ItmSerial == id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ItemMaster itemMaster)
        {
            _context.Entry(itemMaster).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

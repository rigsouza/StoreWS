using ABSCard.Data.Models;
using System;

namespace StoreWS.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly StoreContext _context = new StoreContext();

        public UnitOfWork()
        {

        }

        private bool _disposed;

        public void Dispose()
        {
            Clear(true);
            GC.SuppressFinalize(this);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        private void Clear(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        ~UnitOfWork()
        {
            Clear(false);
        }
    }
}
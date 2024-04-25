using Clients.Migrations.Data;

namespace Clients.DAL.BaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        DataContext DbContext { get; }

        // Method to save changes to the database
        int SaveChanges();

        Task<int> SaveChangesAsync();

        void BulkSaveChanges();

        Task BulkSaveChangesAsync();
    }
}
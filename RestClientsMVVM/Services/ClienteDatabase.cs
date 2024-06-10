using RestClientsMVVM.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace RestClientsMVVM.Services
{
    public class ClienteDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public ClienteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cliente>().Wait();
        }

        public Task<List<Cliente>> GetClientesAsync()
        {
            return _database.Table<Cliente>().ToListAsync();
        }

        public Task<Cliente> GetClienteAsync(int id)
        {
            return _database.Table<Cliente>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<int> SaveClienteAsync(Cliente cliente)
        {
            if (cliente.Id != 0)
            {
                return _database.UpdateAsync(cliente);
            }
            else
            {
                return _database.InsertAsync(cliente);
            }
        }

        public Task<int> DeleteClienteAsync(Cliente cliente)
        {
            return _database.DeleteAsync(cliente);
        }
    }
}

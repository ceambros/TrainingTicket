using System;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace TrainingTicket
{
    class AtividadeDao
    {


        readonly SQLiteAsyncConnection database;

        public AtividadeDao(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Atividade>().Wait();
        }

        public Task<List<Atividade>> GetItemsAsync()
        {
            return database.Table<Atividade>().ToListAsync();
        }

        public Task<Atividade> GetItemAsync(uint id)
        {
            return database.Table<Atividade>().Where(i => i.ID == id).FirstOrDefaultAsync();

        }

        public Task<int> SaveItemAsync(Atividade item)
        {
            if (item.ID == 0)
            {
                return database.InsertAsync(item);
            }

            return database.UpdateAsync(item);
        }

        public Task<int> DeleteItemAsync(Atividade item)
        {
            return database.DeleteAsync(item);
        }


    }
}

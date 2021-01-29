using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labs216.Anisimov.Bank
{
    class AccountContext
    {
        private static AccountContext instanse;

        public static AccountContext getInstanse()
        {
            if (instanse == null)
                instanse = new AccountContext();
            return instanse;
        }

        IMongoCollection<Account> Accounts;

        private AccountContext()
        {
            string conect = "mongodb://localhost";
            var client = new MongoClient(conect);
            IMongoDatabase Bank = client.GetDatabase("Bank");
            Accounts = Bank.GetCollection<Account>("Accounts");
        }

        public async Task<ICollection<Account>> GetAccounts()
        {
            var filter = new BsonDocument();
            return await Accounts.Find(filter).ToListAsync();
        }
        public async Task<ICollection<Account>> GetAccounts(FilterDefinition<Account> filter)
        {
            return await Accounts.Find(filter).ToListAsync();
        }

        public async Task<Account> GetAccount(ObjectId id)
        {
            var filter = new BsonDocument { { "_id", id } } ;
            return await Accounts.Find(filter).FirstOrDefaultAsync();
        }

        public async Task Create(Account account)
        {
            await Accounts.InsertOneAsync(account);
        }
        public async Task Update(Account account)
        {
            await Accounts.ReplaceOneAsync(new BsonDocument("_id", account.Id), account);
        }
        public async Task Remove(ObjectId id)
        {
            await Accounts.DeleteOneAsync(new BsonDocument("_id", id));
        }
    }
}

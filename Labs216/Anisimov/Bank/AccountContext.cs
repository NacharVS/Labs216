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
        IMongoCollection<Account> Accounts;

        public AccountContext()
        {
            string conect = "mongodb://localhost";
            var client = new MongoClient(conect);
            IMongoDatabase Bank = client.GetDatabase("Bank");
            Accounts = Bank.GetCollection<Account>("Accounts");
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            var filter = new BsonDocument();
            return await Accounts.Find(filter).ToListAsync();
        }
        public async Task<Account> GetAccount(ObjectId id)
        {
            var filter = new BsonDocument { { "_id", id } } ;
            return await Accounts.Find(filter).FirstOrDefaultAsync();
        }

        public async Task AddAccount(Account account)
        {
            await Accounts.InsertOneAsync(account);
        }

        public async Task UpdateAccount()
        {

        }
    }
}

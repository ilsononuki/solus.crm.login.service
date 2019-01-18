using MongoDB.Driver;
using solus.crm.login.service.Domain.Interfaces;

namespace solus.crm.login.service.Infra.Data.Connection
{


    public class MongoDBConnection : IMongoDBConnection
    {
        public IMongoDatabase GetDatabase()
        {
            var con = @"mongodb://solus-login-service-mdb:admin123@ds012538.mlab.com:12538/solus-login-service-db";
            return new MongoClient(con).GetDatabase("solus-login-service-db");
        }
    }
}

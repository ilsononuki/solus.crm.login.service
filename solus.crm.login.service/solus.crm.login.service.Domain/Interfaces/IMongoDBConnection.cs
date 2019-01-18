using MongoDB.Driver;

namespace solus.crm.login.service.Domain.Interfaces
{
    public interface IMongoDBConnection
    {
        IMongoDatabase GetDatabase();
    }
}

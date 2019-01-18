using MongoDB.Bson;
using MongoDB.Driver;
using solus.crm.login.service.Domain.Domain;
using solus.crm.login.service.Domain.Interfaces;
using System;

namespace solus.crm.login.service.Infra.Data.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IMongoDBConnection _connection;
        public AuthRepository(IMongoDBConnection connection)
        {
            _connection = connection;
        }

        public AuthModel GetAuth(string email, string password)
        {
            return _connection
                   .GetDatabase()
                   .GetCollection<AuthModel>("authCollection")
                   .Find(a => a.Email == email && a.Password == password)
                   .FirstOrDefault();
        }

        public bool ExistAccount(string email)
        {
            var model = _connection
                   .GetDatabase()
                   .GetCollection<AuthModel>("authCollection")
                   .Find(a => a.Email == email)
                   .FirstOrDefault();

            if (model != null)
                return true;
            else
                return false;
        }

        public void Register(AuthModel model)
        {
            _connection
            .GetDatabase()
            .GetCollection<AuthModel>("authCollection")
            .InsertOne(model);
        }

        public void Update(Guid id, AuthModel model)
        {

            var update = Builders<AuthModel>.Update.Set(a => a.Name, model.Name);

            _connection
            .GetDatabase()
            .GetCollection<AuthModel>("authCollection")
            .UpdateOne(a => a.Id == id, update);
        }
    }
}

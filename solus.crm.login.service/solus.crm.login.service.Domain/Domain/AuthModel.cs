using MongoDB.Bson.Serialization.Attributes;
using System;

namespace solus.crm.login.service.Domain.Domain
{
    public sealed class AuthModel
    {
        [BsonRequired()]
        [BsonElement("id")]
        public Guid Id { get; set; }

        [BsonRequired()]
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonRequired()]
        [BsonElement("midleName")]
        public string MidleName { get; set; }

        [BsonRequired()]
        [BsonElement("email")]
        public string Email { get; set; }

        [BsonRequired()]
        [BsonElement("password")]
        public string Password { get; set; }

        [BsonRequired()]
        [BsonElement("active")]
        public bool Active { get; set; }

        [BsonRequired()]
        [BsonElement("premiunAccount")]
        public bool premiunAccount { get; set; }

        [BsonRequired()]
        [BsonElement("plan")]
        public int plan { get; set; }

        [BsonRequired()]
        [BsonElement("expirePlan")]
        public DateTime expirePlan { get; set; }

        [BsonRequired()]
        [BsonElement("created")]
        public DateTime Created { get; set; }

    }
}

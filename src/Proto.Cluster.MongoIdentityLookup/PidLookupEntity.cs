using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Proto.Cluster.MongoIdentityLookup
{
    public class PidLookupEntity
    {

        [BsonId]
        public string Key { get; set; }
        public string Identity { get; set; }
        public string UniqueIdentity { get; set; }
        public string Kind { get; set; }
        public string Address { get; set; }
        public string MemberId { get; set; }
        public Guid? LockedBy { get; set; }
    }
}
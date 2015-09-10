using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace LyphTEC.MongoSimpleMembership.Extensions {
    public static class BsonMemberMapExtension {
        public static BsonMemberMap SetRepresentation(this BsonMemberMap src, BsonType bsonType) {
            //switch (bsonType) {
            //    case BsonType.Int32:
            //        return src;
            //    case BsonType.ObjectId:
            //        return src.SetSerializer(new StringSerializer(bsonType));
            //}
            return src;
        }
    }
}

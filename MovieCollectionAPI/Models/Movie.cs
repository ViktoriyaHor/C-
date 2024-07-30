using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MovieCollectionAPI.Models
{
       public class Rating
    {
            [BsonElement("source")]
        public string Source { get; set; }

        [BsonElement("value")]
        public double Value { get; set; }
    }

    public class Movie
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("title")]
    public string Title { get; set; }

    [BsonElement("director")]
    public string Director { get; set; }

    [BsonElement("releaseYear")]
    public int ReleaseYear { get; set; }

    [BsonElement("genres")]
    public List<string> Genres { get; set; }

    [BsonElement("ratings")]
    public List<Rating> Ratings { get; set; }
}

}

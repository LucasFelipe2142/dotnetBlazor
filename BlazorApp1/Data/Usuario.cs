using MongoDB.Bson;

namespace BlazorApp1.Data
{
    public class Usuario
    {
        public ObjectId Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId();
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}

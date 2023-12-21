namespace BlazorApp1.Data
{
    public class MateriaResumida
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }
    }
}

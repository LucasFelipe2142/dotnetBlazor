namespace BlazorApp1.Data
{
    public class UsuarioDetalhes
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public Dictionary<string, MateriaResumida> MateriasEmCurso { get; set; }
    }
}

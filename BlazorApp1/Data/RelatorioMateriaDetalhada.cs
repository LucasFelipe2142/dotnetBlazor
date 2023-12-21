namespace BlazorApp1.Data
{
    public class RelatorioMateriaDetalhada
    {
        public string IdMateria { get; set; }
        public string NomeMateria { get; set; }
        public string NomeProfessor { get; set; }
        public List<RelatorioAtividade> Atividades { get; set; }
    }
}

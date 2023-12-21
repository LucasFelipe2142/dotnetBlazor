namespace BlazorApp1.Data
{
    public class RelatorioAlunoMateriasAtividades
    {
        public string IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public List<RelatorioMateriaDetalhada> Materias { get; set; }
    }
}

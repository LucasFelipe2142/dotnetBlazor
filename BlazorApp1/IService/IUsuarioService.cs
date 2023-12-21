using BlazorApp1.Data;
using MongoDB.Driver;

namespace BlazorApp1.IService
{
    public interface IUsuarioService
    {
        Task<bool> AdicionarUsuarioAsync(UsuarioCadastro usuario);

        Task<HttpResponseMessage> VerificarCredenciaisAsync(string email, string senha);

        Task<HttpResponseMessage> GetMateriasEmCurso(string email);

        Task<HttpResponseMessage> GetAtividadesMateria(string idMateria);

        Task<HttpResponseMessage> AtualizarValorAtividade(string idMateria, string idAtividade, decimal novoValor);

        Task<HttpResponseMessage> GetRelatorio(string email);
    }
}

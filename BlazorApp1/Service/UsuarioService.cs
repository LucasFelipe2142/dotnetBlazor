using BlazorApp1.Data;
using BlazorApp1.IService;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AdicionarUsuarioAsync(UsuarioCadastro usuario)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5165/api/auth/cadastrar", usuario);

            return response.IsSuccessStatusCode;
        }

        public async Task<HttpResponseMessage> VerificarCredenciaisAsync(string email, string senha)
        {
            var loginModel = new { Email = email, Senha = senha };

            return await _httpClient.PostAsJsonAsync("http://localhost:5165/api/auth/login", loginModel);
        }

        public async Task<HttpResponseMessage> GetMateriasEmCurso(string email)
        {
            string url = $"http://localhost:5165/api/materias/BuscarMateriasPorEmail?emailAluno={Uri.EscapeDataString(email)}";
            return await _httpClient.GetAsync(url);
        }

        public async Task<HttpResponseMessage> GetAtividadesMateria(string idMateria)
        {
            var _idMateria = new { idMateria = idMateria };
            string url = $"http://localhost:5165/api/materias/atividades";
            return await _httpClient.PostAsJsonAsync(url, _idMateria);
        }

        public async Task<HttpResponseMessage> AtualizarValorAtividade(string idMateria, string idAtividade, decimal novoValor)
        {
            var request = new
            {
                IdMateria = idMateria,
                IdAtividade = idAtividade,
                colunaKanban = novoValor
            };

            Console.WriteLine(request);

            string url = "http://localhost:5165/api/materias/atualizar-kanban";
            var response = await _httpClient.PutAsJsonAsync(url, request);
            Console.WriteLine(response);
            return response;
        }

        public async Task<HttpResponseMessage> GetRelatorio(string email)
        {
            string url = $"http://localhost:5165/api/materias/relatorio?emailAluno={Uri.EscapeDataString(email)}";
            return await _httpClient.GetAsync(url);
        }

    }
}

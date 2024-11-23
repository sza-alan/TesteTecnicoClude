using GestaoProfissionais.Models;

namespace GestaoProfissionais.Services;

public interface IProfissionalService
{
    Task<List<Profissional>> ObterProfissionaisPorEspecialidadeAsync(string especialidade);
    Task AdicionarProfissionalAsync(Profissional profissional);
    Task EditarProfissionalAsync(Profissional profissional);
    Task ExcluirProfissionalAsync(int id);
}

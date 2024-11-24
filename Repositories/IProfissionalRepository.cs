using GestaoProfissionais.Models;

namespace GestaoProfissionais.Repositories;

public interface IProfissionalRepository
{
    Task<List<Profissional>> ObterProfissionaisPorEspecialidadeAsync(string especialidade);
    Task AdicionarProfissionalAsync(Profissional profissional);
    Task EditarProfissionalAsync(Profissional profissional);
    Task ExcluirProfissionalAsync(int id);
}

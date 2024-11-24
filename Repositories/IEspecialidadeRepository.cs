using GestaoProfissionais.Models;

namespace GestaoProfissionais.Repositories;

public interface IEspecialidadeRepository
{
    Task<Especialidade> ObterEspecialidadePorIdAsync(int id);
    Task<List<Especialidade>> ObterTodasEspecialidadesAsync();
}

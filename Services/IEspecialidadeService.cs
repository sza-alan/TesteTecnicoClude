using GestaoProfissionais.Models;

namespace GestaoProfissionais.Services;

public interface IEspecialidadeService
{
    Task<Especialidade> ObterEspecialidadePorIdAsync(int id);
    Task<List<Especialidade>> ObterTodasEspecialidadesAsync();
}

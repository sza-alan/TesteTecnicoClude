using GestaoProfissionais.Data;
using GestaoProfissionais.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoProfissionais.Services;

public class EspecialidadeService : IEspecialidadeService
{
    private readonly AppDbContext _context;

    public EspecialidadeService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Especialidade> ObterEspecialidadePorIdAsync(int id)
    {
        return await _context.Especialidades.FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<List<Especialidade>> ObterTodasEspecialidadesAsync()
    {
        return await _context.Especialidades.ToListAsync();
    }
}
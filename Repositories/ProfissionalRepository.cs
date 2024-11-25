using GestaoProfissionais.Models;
using GestaoProfissionais.Data;
using Microsoft.EntityFrameworkCore;

namespace GestaoProfissionais.Repositories;

public class ProfissionalRepository : IProfissionalRepository
{
    private readonly AppDbContext _context;
    private readonly IEspecialidadeRepository _especialidadeRepo;

    public ProfissionalRepository(AppDbContext context, IEspecialidadeRepository especialidadeRepo)
    {
        _context = context;
        _especialidadeRepo = especialidadeRepo;
    }

    public async Task<List<Profissional>> ObterProfissionaisPorEspecialidadeAsync(string especialidade)
    {
        return string.IsNullOrEmpty(especialidade) || especialidade == "Todos"
            ? await _context.Profissionais.Include(p => p.Especialidade).ToListAsync()
            : await _context.Profissionais.Include(p => p.Especialidade)
                .Where(p => p.Especialidade.Nome == especialidade)
                .ToListAsync();
    }

    public async Task AdicionarProfissionalAsync(Profissional profissional)
    {
        if (profissional.EspecialidadeId != 0)
        {
            var especialidade = await _especialidadeRepo.ObterEspecialidadePorIdAsync(profissional.EspecialidadeId);
            if (especialidade != null)
            {
                profissional.Especialidade = especialidade;//
            }
        }

        _context.Add(profissional);
        await _context.SaveChangesAsync();
    }

    public async Task EditarProfissionalAsync(Profissional profissional)
    {
        _context.Update(profissional);
        await _context.SaveChangesAsync();
    }

    public async Task ExcluirProfissionalAsync(int id)
    {
        var profissional = await _context.Profissionais.FindAsync(id);
        if (profissional != null)
        {
            _context.Profissionais.Remove(profissional);
            await _context.SaveChangesAsync();
        }
    }
}
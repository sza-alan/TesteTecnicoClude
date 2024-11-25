using GestaoProfissionais.Models;
using GestaoProfissionais.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProfissionais.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProfissionalRepository _profissionalRepo;
        private readonly IEspecialidadeRepository _especialidadeRepo;

        public HomeController(IProfissionalRepository profissionalRepo, IEspecialidadeRepository especialidadeRepo)
        {
            _profissionalRepo = profissionalRepo;
            _especialidadeRepo = especialidadeRepo;
        }

        public async Task<IActionResult> Index(string selecionada)
        {
            ViewBag.Selecionada = selecionada ?? "Todos";
            ViewBag.Especialidades = await _especialidadeRepo.ObterTodasEspecialidadesAsync();

            var profissionais = await _profissionalRepo.ObterProfissionaisPorEspecialidadeAsync(selecionada);

            return View(profissionais);
        }

        public async Task<IActionResult> Adicionar(Profissional profissional)
        {
            await _profissionalRepo.AdicionarProfissionalAsync(profissional);
            TempData["CadastroSucesso"] = "Profissional cadastrado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Editar(Profissional profissional)
        {
            await _profissionalRepo.EditarProfissionalAsync(profissional);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Excluir(int id)
        {
            await _profissionalRepo.ExcluirProfissionalAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
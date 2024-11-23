using GestaoProfissionais.Models;
using GestaoProfissionais.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProfissionais.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProfissionalService _profissionalService;
        private readonly IEspecialidadeService _especialidadeService;

        public HomeController(IProfissionalService profissionalService, IEspecialidadeService especialidadeService)
        {
            _profissionalService = profissionalService;
            _especialidadeService = especialidadeService;
        }

        public async Task<IActionResult> Index(string selecionada)
        {
            ViewBag.Selecionada = selecionada ?? "Todos";
            ViewBag.Especialidades = await _especialidadeService.ObterTodasEspecialidadesAsync();

            var profissionais = await _profissionalService.ObterProfissionaisPorEspecialidadeAsync(selecionada);

            return View(profissionais);
        }

        public async Task<IActionResult> Adicionar(Profissional profissional)
        {
            await _profissionalService.AdicionarProfissionalAsync(profissional);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Editar(Profissional profissional)
        {
            await _profissionalService.EditarProfissionalAsync(profissional);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Excluir(int id)
        {
            await _profissionalService.ExcluirProfissionalAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
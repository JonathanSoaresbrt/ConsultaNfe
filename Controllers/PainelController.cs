using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RelatoriosWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelatoriosWeb.Models;
using RelatoriosWeb.Services;
using RelatoriosWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Text.RegularExpressions;
using X.PagedList;



namespace RelatoriosWeb.Controllers
{
    public class PainelController : Controller
    {


        private readonly PainelService _painelService;
        private readonly PainelNfe_Service _painelnfeService;
        private readonly RelatoriosWebContext _context;



        public PainelController(PainelService painelService, PainelNfe_Service painelNfe_Service, RelatoriosWebContext context)
        {
            _painelService = painelService;
            _painelnfeService = painelNfe_Service;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Painel(DateTime? minDate, DateTime? maxDate, string ccnpj, int numnota)
        {
            if (ccnpj != null)
            {
                ccnpj = Regex.Replace(ccnpj, @"[/.@-@ @-]", "");
            }

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            ViewData["cnpjBusca"] = ccnpj;
            ViewData["numNotaBusca"] = numnota;

            var result = await _painelService.FindByDatePainelGroupingAsync(minDate, maxDate, ccnpj, numnota);

            return View(result);
        }

        public async Task<ActionResult> PainelGeral(DateTime? minDate, DateTime? maxDate, int? page)
        {
 
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _painelService.FindByDateAsync(minDate, maxDate);

            const int itensPorPagina = 30;
            int numeroPagina = (page ?? 1);

            var notas = result.ToPagedList(numeroPagina, itensPorPagina);

            return View(notas);
        }

        public async Task<ActionResult> EmpresasAtivas(DateTime? minDate, DateTime? maxDate, string ccnpj)
        {
            if (ccnpj != null)
            {
                ccnpj = Regex.Replace(ccnpj, @"[/.@-@ @-]", "");
            }
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            ViewData["cnpjBusca"] = ccnpj;

            var result = await _painelService.FindByDateEmpresasAsync(minDate, maxDate, ccnpj);

            return View(result);
        }

        public async Task<IActionResult> RelatorioErros(DateTime? minDate, DateTime? maxDate, string ccnpj, int? page)
        {
            if (ccnpj != null)
            {
                ccnpj = Regex.Replace(ccnpj, @"[/.@-@ @-]", "");
            }

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            ViewData["cnpjBusca"] = ccnpj;

            var result = await _painelnfeService.FindByDateGroupingAsync(minDate, maxDate, ccnpj);

            const int itensPorPagina = 10;
            int numeroPagina = (page ?? 1);

            var notas = result.ToPagedList(numeroPagina, itensPorPagina);

            return View(notas);
        }

        public async Task<ActionResult> RelatorioErrosDetalhe(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _painelnfeService.FindByGrupoAsync(minDate, maxDate);

            return View(result);

        }
        public async Task<ActionResult> RelatorioErrosDetalheCnpj(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _painelnfeService.FindByGrupoAsyncCnpj(minDate, maxDate);

            return View(result);
        }

        public async Task<IActionResult> Details(string cnpj, int? nfnumero, DateTime dt_termino)
        {
            var ccnpj = cnpj.TrimEnd();

            if (nfnumero == 0)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Não Existe" });
            }

            var painel = await _context.painel_nfe
                .FirstOrDefaultAsync(m => m.cnpj == ccnpj && m.nfnumero == nfnumero && m.dt_termino >= dt_termino);
            if (painel == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Nota Fiscal Nao Existe na tabela" });
            }

            return View(painel);
        }

        public async Task<IActionResult> DetailsEmp(string cnpj)
        {
            var ccnpj = cnpj.TrimEnd();

            if (cnpj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Não Existe" });
            }

            var painel = await _context.painel_empresas
                .FirstOrDefaultAsync(m => m.cnpj == ccnpj);
            if (painel == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Empresa não existe" });
            }

            return View(painel);
        }

        public IActionResult Login(Usuario u)
        {

            if (ModelState.IsValid)
            {
                var usuario = _context.Usuario.Where(a => a.Login.Equals(u.Login) && a.Senha.Equals(u.Senha)).FirstOrDefault();

                if (usuario != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Login ou Senha inválidos!!!");
                    return View();
                }

            }

            return View(u);
        }


        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

    }
}
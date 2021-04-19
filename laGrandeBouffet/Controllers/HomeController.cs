using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using La_Grande_Bouffe.Models;
using Buffet.Models.Buffet.Cliente;
using Buffet.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using La_Grande_Bouffe.RequestModels;
using laGrandeBouffet.ViewModels.Home;
using System.Text.RegularExpressions;
using laGrandeBouffet.Models.Acesso;

namespace La_Grande_Bouffe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CadastroService _cadastroService;

        public HomeController(ILogger<HomeController> logger, CadastroService cadastroService)
        {
            _logger = logger;
            _cadastroService = cadastroService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            var viewModel = new CadastroViewModel();
            viewModel.SucessoCadastro = (string)TempData["sucesso-cadastro"];
            return View(viewModel);
        }
        
        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewModel = new CadastroViewModel();

            viewModel.ErroEmail = (string)TempData["erro-email"];
            viewModel.ErroSenha = (string)TempData["erro-senha"];
            viewModel.ErroConfirmaSenha = (string)TempData["erro-confirmaSenha"];
          
            viewModel.ErroCadastro = (string[])TempData["erro-cadastro"];

            return View(viewModel);
        }

        [HttpPost]
        public async Task<RedirectToActionResult> Cadastro(RequestModelCadastro request)
        {
            
            if (request.EmailLogin == null)
            {
                TempData["erro-email"] = "Por favor, informe um e-mail válido.";
                return RedirectToAction("Cadastro");
            }

            if(request.SenhaLogin != request.ConfirmaSenhaLogin)
            {
                TempData["erro-confirmaSenha"] = "Por favor, confirmação e senhas devem ser iguais.";
                return RedirectToAction("Cadastro");
            }
            
            if(request.SenhaLogin == null)
            {
                TempData["erro-senha"] = "Por favor, informe uma senha válida.";
                return RedirectToAction("Cadastro");
            }


            try
            {
                await _cadastroService.CadastrarUsuario(request.EmailLogin, request.SenhaLogin);

                TempData["sucesso-cadastro"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Login");
            }
            catch (CadastroException exc)
            {
                var listaErros = new List<string>();

                foreach (var identityError in exc.Erros)
                {
                    listaErros.Add(identityError.Description);
                }

                TempData["erro-cadastro"] = listaErros;
                return RedirectToAction("Cadastro");
            }
        }
        
        public IActionResult RecuperaAcesso()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

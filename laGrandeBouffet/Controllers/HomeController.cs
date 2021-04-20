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
using laGrandeBouffet.RequestModels;

namespace La_Grande_Bouffe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CadastroService _cadastroService;
        private readonly LoginService _loginService;

        public HomeController(ILogger<HomeController> logger, CadastroService cadastroService, LoginService loginService)
        {
            _logger = logger;
            _cadastroService = cadastroService;
            _loginService = loginService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            var viewModel = new LoginViewModel();
            viewModel.ErroEmail = (string)TempData["erro-email-login"];
            viewModel.ErroSenha = (string)TempData["erro-senha-login"];

            viewModel.ErroLogin = (string)TempData["erro-login"];

            return View(viewModel);
        }
        
        [HttpPost]
        public async Task<RedirectToActionResult> Login(RequestModelLogin request)
        {
            if (request.EmailLogin == null)
            {
                TempData["erro-email-login"] = "Por favor, informe um e-mail válido.";
                return RedirectToAction("Login");
            }

            if (request.SenhaLogin == null)
            {
                TempData["erro-senha-login"] = "Por favor, informe sua senha.";
                return RedirectToAction("Login");
            }

            try
            {
                await _loginService.LoginrUsuario(request.EmailLogin, request.SenhaLogin);

                TempData["sucesso-login"] = "Bem vindo!";

                return RedirectToAction("Index", "Dashboard");
            }
            catch (Exception exc)
            {
                TempData["erro-login"] = exc.Message;
                return RedirectToAction("Login");
            }


        }
        
        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewModel = new CadastroViewModel();

            viewModel.ErroEmail = (string)TempData["erro-email-cadastro"];
            viewModel.ErroSenha = (string)TempData["erro-senha-cadastro"];
            viewModel.ErroConfirmaSenha = (string)TempData["erro-confirmaSenha"];
          
            viewModel.ErroCadastro = (string[])TempData["erro-cadastro"];

            return View(viewModel);
        }

        [HttpPost]
        public async Task<RedirectToActionResult> Cadastro(RequestModelCadastro request)
        {
            
            if (request.EmailCadastro == null)
            {
                TempData["erro-email-cadastro"] = "Por favor, informe um e-mail válido.";
                return RedirectToAction("Cadastro");
            }

            if(request.SenhaCadastro != request.ConfirmaSenhaCadastro)
            {
                TempData["erro-confirmaSenha"] = "Por favor, confirmação e senhas devem ser iguais.";
                return RedirectToAction("Cadastro");
            }
            
            if(request.SenhaCadastro == null)
            {
                TempData["erro-senha-cadastro"] = "Por favor, informe uma senha válida.";
                return RedirectToAction("Cadastro");
            }


            try
            {
                await _cadastroService.CadastrarUsuario(request.EmailCadastro, request.SenhaCadastro);

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

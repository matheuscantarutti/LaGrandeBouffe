using Buffet.Models.Acesso;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Acesso
{
    public class LoginService
    {
        
        private readonly SignInManager<Usuario> _signInManager;

        public LoginService(SignInManager<Usuario> signInManager)
        {

            _signInManager = signInManager;

        }

        public async Task LoginrUsuario(string email, string senha)
        {
            var result = await _signInManager.PasswordSignInAsync(email, senha, isPersistent:false, lockoutOnFailure:false);


            if (!result.Succeeded)
            {
                throw new Exception("Usuário e/ou senha inválido(s)!");
            }

        }
    }
}

using Buffet.Models.Acesso;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Acesso
{
    public class CadastroService
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public CadastroService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public async Task CadastrarUsuario( string email, string senha)
        {
            var novoUsuario = new Usuario()
            {
                UserName = email,
                Email = email
            };

            var result = await _userManager.CreateAsync(novoUsuario, senha);

            
            if(!result.Succeeded)
            {
                throw new CadastroException(result.Errors);
            }
            
        }
    }
}

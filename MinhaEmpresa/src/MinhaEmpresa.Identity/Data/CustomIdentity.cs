using Microsoft.AspNetCore.Identity;

namespace MinhaEmpresa.Identity.Data
{
    public class CustomIdentity : IdentityUser
    {
        public string Nome { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CopyVisterma.Seed
{
    public class IdentitySeed
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public IdentitySeed(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task EnsureSeedData()
        {
            if (await _roleManager.FindByNameAsync("Admin") == null)
            {
                var admin = new IdentityRole
                {
                    Name = "Admin"
                };
                await _roleManager.CreateAsync(admin);
            }

            if (await _roleManager.FindByNameAsync("Editor") == null)
            {
                var editor = new IdentityRole
                {
                    Name = "Editor"
                };
                await _roleManager.CreateAsync(editor);
            }

            if (await _userManager.FindByEmailAsync("admin@example.com") == null)
            {

                var admin = new IdentityUser
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com"
                };

                await _userManager.CreateAsync(admin, "P@ssw0rd");
                await _userManager.AddToRoleAsync(admin, "Admin");
                await _userManager.AddToRoleAsync(admin, "Editor");
            }

            if (await _userManager.FindByEmailAsync("editor@example.com") == null)
            {

                var editor = new IdentityUser
                {
                    UserName = "editor@example.com",
                    Email = "editor@example.com"
                };

                await _userManager.CreateAsync(editor, "P@ssw0rd");
                await _userManager.AddToRoleAsync(editor, "Editor");
            }

            if (await _userManager.FindByEmailAsync("user@example.com") == null)
            {

                var user = new IdentityUser
                {
                    UserName = "user@example.com",
                    Email = "user@example.com",

                };

                await _userManager.CreateAsync(user, "P@ssw0rd");
                await _userManager.AddClaimsAsync(user, new[] {
                    new Claim("given_name", "John"),
                    new Claim("family_name", "Doe")
                });
            }

            if (await _userManager.FindByEmailAsync("j.kosciesza@codeandpepper.com") == null)
            {

                var jkosciesza = new IdentityUser
                {
                    UserName = "j.kosciesza@codeandpepper.com",
                    Email = "j.kosciesza@codeandpepper.com",

                };

                await _userManager.CreateAsync(jkosciesza, "P@ssw0rd");
                await _userManager.AddClaimsAsync(jkosciesza, new[] {
                    new Claim("given_name", "Jacek"),
                    new Claim("family_name", "Kościesza"),
                    new Claim("photo", "/assets/img/users/jacek-kosciesza.jpg")
                });
                await _userManager.AddToRoleAsync(jkosciesza, "Admin");
                await _userManager.AddToRoleAsync(jkosciesza, "Editor");
            }
        }
    }
}

using Microsoft.AspNetCore.Identity;

namespace User.Management.API.Repository
{
    public interface IRepository
    {
        public string FindByEmailAsync(string Email);
        public string RoleExistsAsync(string Role);

        public string CreateAsync(IdentityUser user, string Password);

        public string AddRoleAsync(string Role);

        public string GenerateEmailConfirmationTokenAsync(IdentityUser user);

        public string ConfirmEmailAsync(string Email, string token);

        public string FindByNameAsync(string userName);

        public string CheckPasswordAsync(IdentityUser user, string Password);

        public string PasswordSignInAsync(IdentityUser user, string password, bool isPersistent, bool lockoutOnFailure);

        public string GenerateTwoFactorTokenAsync(IdentityUser user, string tokenProvider);

        public string SignOutAsync();

        public string GetRolesAsync(IdentityUser user);

        public string DeleteAsync(IdentityUser user);

        public string RemoveFromRolesAsync(IdentityUser user, IEnumerable<string> roles);
        public string UpdateAsync(IdentityUser user);
        public string AddToRoleAsync(IdentityUser user, string Role);

        public string TwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberClient);


    }
}

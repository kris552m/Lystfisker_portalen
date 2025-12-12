using LystfiskerPortalen.Data;
using Microsoft.AspNetCore.Identity;
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Profile> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Profile> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}

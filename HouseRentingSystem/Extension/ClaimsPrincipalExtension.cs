using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace HouseRentingSystem.Extension
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

    }
}

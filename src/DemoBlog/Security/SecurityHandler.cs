using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace DemoBlog.Security
{
    public class SecurityHandler : AuthorizationHandler<TokenRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TokenRequirement requirement)
        {
            //context.Succeed(requirement);
            context.Fail();
            return Task.FromResult(0);
        }
    }
}

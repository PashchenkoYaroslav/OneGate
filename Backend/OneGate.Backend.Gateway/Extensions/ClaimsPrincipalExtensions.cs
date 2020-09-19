﻿using System.Security.Claims;

namespace OneGate.Backend.Gateway.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static int GetAccountId(this ClaimsPrincipal user)
        {
            var claimId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            return claimId == null ? -1 : int.Parse(claimId);
        }
    }
}
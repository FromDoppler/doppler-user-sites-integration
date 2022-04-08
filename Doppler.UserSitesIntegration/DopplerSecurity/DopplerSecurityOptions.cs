using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace Doppler.UserSitesIntegration.DopplerSecurity
{
    public class DopplerSecurityOptions
    {
        public IEnumerable<SecurityKey> SigningKeys { get; set; } = new SecurityKey[0];
    }
}

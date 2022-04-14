using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Doppler.UserSitesIntegration.Controllers
{
    [ApiController]
    public class SiteController : ControllerBase
    {
        [HttpPut]
        [Route("accounts/{accountName}/sites/{domain}/isPushFeatureEnabled")]
        public Task<ActionResult> SetPushFeatureEnabled([FromRoute] string accountName, [FromRoute] string domain, [FromBody] bool isPushFeatureEnabled)
        {
            throw new NotImplementedException();
        }

    }
}

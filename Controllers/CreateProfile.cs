using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueFriendFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LeagueFriendFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateProfileController : ControllerBase
    {

        private readonly ILogger<ProfileController> _logger;
        private readonly ProfileContext _context;
        public CreateProfileController(ProfileContext context)
        {
            _context = context;
        }


        [HttpPost]       
        public async Task<IActionResult> Post([FromBody]JsonElement json)
        {
            try
            {
                Profile newProfile = JsonSerializer.Deserialize<Profile>(json.ToString());

                if (newProfile.IsLicenseAccepted == true)
                {
                    newProfile.DateOfRegistrationInService = DateTime.Now;
                    _context.Add(newProfile);
                   await _context.SaveChangesAsync();
                   return new JsonResult(new { result = true });
                }
                else
                {
                    return new JsonResult(new { result = false });

                }
            }
            catch(Exception ex)
            {
                return new JsonResult(new { result = false });

            }
        }
    }
}


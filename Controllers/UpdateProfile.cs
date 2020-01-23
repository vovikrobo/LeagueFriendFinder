using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueFriendFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace LeagueFriendFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateProfileController : ControllerBase
    {

        private readonly ILogger<ProfileController> _logger;
        private readonly ProfileContext _context;
        public UpdateProfileController(ProfileContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]JsonElement json)
        {
            try
            {
                Models.Profile profileToUpdate = JsonSerializer.Deserialize<Models.Profile>(json.ToString());
                
                if (profileToUpdate.IsLicenseAccepted == true)
                {
                    //_context.Profiles.Where (profileToUpdate);
                    //var profileToUpdate = _context.Profiles.FirstOrDefault(item => item.VkontakteUserID == tempProfile.VkontakteUserID);
                    
                    

                    if (profileToUpdate != null)
                    {
     //                   var configuration = new MapperConfiguration(cfg =>
     //                   {
     //                       cfg.CreateMap<Models.Profile, Models.Profile>()
     //.ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
     //                   });
     //                   AutoMapper.Mapper map = new Mapper(configuration);
     //                   map.Map(tempProfile, profileToUpdate);

                        profileToUpdate.DateOfLastModify = DateTime.Now;
                        // profileToUpdate.Id = tempProfileId;
                        // tempProfile = profileToUpdate;
                        //_context.Entry(tempProfile).State = EntityState.Modified;
                        
                            
                        _context.Update<Models.Profile>(profileToUpdate);

                       await _context.SaveChangesAsync();
                    }
                                       
                    return new JsonResult(new { result = true });
                }

                return new JsonResult(new { result = false });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new JsonResult(new { result = false });
            }
        }
    }
}

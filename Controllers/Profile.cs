using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueFriendFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace LeagueFriendFinder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        
        private readonly ILogger<ProfileController> _logger;
        private readonly ProfileContext _context;
        public ProfileController(ProfileContext context)
        {
            _context = context;
        }

        [Route("{profileId:int}")]
        [HttpGet]
        public IEnumerable<Profile> GetProfile(int profileId)
        { 
            IEnumerable<Profile> profile = from p in _context.Profiles where p.VkontakteUserID == profileId select p;
            return profile;
        }

        [Route("all/{count:int}")]
        [Route("all")]
        [HttpGet]
        public async Task<IActionResult> GetAllProfiles(int count)
        {
            count = string.IsNullOrEmpty(count.ToString()) || count == 0 ? 5 : count;

            if (count > 100)
            {
                return new JsonResult(new { countLimitExceed = true });
            }

            IQueryable<Profile> profiles;

            if (_context.Profiles.Count() >= count)
            {
                profiles = _context.Profiles.Where(p => p.IsActiveProfile == true && p.IsLicenseAccepted == true).Take(count);
            }
            else
            {
                profiles = _context.Profiles.Where(p => p.IsActiveProfile == true && p.IsLicenseAccepted == true);
            }

            JsonSerializer json = JsonSerializer.Create();


            var dummyJsonResult = _context.Profiles.Where(p => p.IsActiveProfile == true && p.IsLicenseAccepted == true)
                .Select(p => new {
                    p.VkontakteUserID,
                    p.InGameAccountNickname,
                    p.ServerOfInGameAccount,
                    p.RankedLeague,
                    p.RankedDivision,
                    p.PrefferedRole1,
                    p.PrefferedRole2,
                    p.IsSearchingForPlayingInTeam,
                    p.IsSearchingForPlayingRankeds,
                    p.IsSearchingJustToFindNewFriends,
                    p.WhoIAmSearchingForComment,
                    p.CommentAboutHimself
                })
                .ToList();

            string jsonResult = JsonConvert.SerializeObject(profiles, Formatting.Indented);
            return new JsonResult(dummyJsonResult);
        }
    }
}

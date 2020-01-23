using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueFriendFinder.Models
{
    public class Profile
    {
        [JsonIgnore]
        public DateTime DateOfRegistrationInService { get; set; }
        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateOfLastModify { get; set; } = DateTime.Now;
        [Required]
        public bool IsLicenseAccepted { get; set; }
        [Required]
        [Key]
        [JsonPropertyName("user_id")]
        public int VkontakteUserID { get; set; }
        [Required]
        public bool IsActiveProfile { get; set; } = true;
        public string InGameAccountNickname { get; set; }
        public string ServerOfInGameAccount { get; set; }

        public string RankedLeague { get; set; }
        public string RankedDivision { get; set; }

        public bool IsSearchingForPlayingInTeam { get; set; }
        public bool IsSearchingForPlayingRankeds { get; set; }
        public bool IsSearchingJustToFindNewFriends { get; set; }

        public string CommentAboutHimself { get; set; }

        public string PrefferedRole1 { get; set; }
        public string PrefferedRole2 { get; set; }

        public string WhoIAmSearchingForComment { get; set; }

        public string MostPlayedChampions { get; set; }
    }
}

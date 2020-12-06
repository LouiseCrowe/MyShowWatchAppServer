using MyShowWatch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShowWatch.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowController : ControllerBase
    {

        private readonly ILogger<ShowController> logger;

        public ShowController(ILogger<ShowController> logger)
        {
            this.logger = logger;
        }

        List<Show> shows = new List<Show>()
            {
                new Show() {    Title = "Fargo",
                                ShowType = ShowType.BoxSet,
                                Status = Status.Available,
                                NumSeasonsConfirmed = 4,
                                LatestSeasonAvailable = 4,
                                NumEpisodes = 11,
                                Description = "American Black Comedy"},
                new Show() {    Title = "Succession",
                                ShowType = ShowType.BoxSet,
                                Status = Status.NoReleaseDate,
                                IsWatched = false,
                                NumSeasonsConfirmed = 3,
                                LatestSeasonAvailable = 2,
                                Description = "American Drama/Comedy based on the Roy family, " +
                                "owners of a global media company"},
                new Show() {    Title = "Upright",
                                ShowType = ShowType.BoxSet,
                                NumSeasonsConfirmed = 1,
                                LatestSeasonAvailable = 1,
                                Description = "Fantastic comedy/drama following a musician " +
                                "and teenager's adventures as they transport an upright piano " +
                                "from Sydney to Perth"},
                new Show() {    Title = "Louis Theroux's Weird Weekends",
                                ShowType = ShowType.Documentary,
                                Status = Status.Available,
                                NumSeasonsConfirmed = 3,
                                LatestSeasonAvailable = 3},
                new Show() {    Title = "The Devil Next Door",
                                ShowType = ShowType.Documentary,
                                Status = Status.Available,
                                Description = "Documentary about the trail in Isreal of a former " +
                                "Ukranian citizen accused of being Ivan the Terrible a " +
                                "notorious concentration camp guard;"},
                new Show() {    Title = "Vietnam",
                                ShowType = ShowType.Documentary,
                                Status = Status.Available},
                new Show() {    Title = "Uncut Gem",
                                ShowType = ShowType.Movie,
                                Status = Status.NoReleaseDate },
                new Show() {    Title = "Black Widow",
                                ShowType = ShowType.Movie,
                                Status = Status.NoReleaseDate,
                                ReleaseDate = new DateTime(2021, 05, 7),
                                IsKidFriendly = true,
                                Description = "Latest in the Marvel series starring Scarlett Johansen"},
                new Show() {    Title = "The SpongeBob Movie: Sponge on the Run",
                                ShowType = ShowType.Movie,
                                Status = Status.NoReleaseDate,
                                ReleaseDate = new DateTime(2021, 05, 7),
                                IsKidFriendly = true,
                                Description = "Latest in the Marvel series starring Scarlett Johansen"},
                new Show() {    Title = "The Morning Show",
                                ShowType = ShowType.BoxSet,
                                Status = Status.NoReleaseDate,
                                NumSeasonsConfirmed = 2,
                                LatestSeasonAvailable = 1,
                                NumEpisodes = 10,
                                Description = "American Drama comedy starring Jennifer Anniston, " +
                                "Reese Witherspoon and Steve Carell about a Morning Show.  Great script" +
                                "and story lines"}

            };

        [HttpGet]
        public IEnumerable<Show> Get()
        {
            return shows.ToArray();
        }

        //[HttpGet]
        //public IActionResult GetAllMovies(ShowType type)
        //{

        //    Show result;

        //    if (true)
        //    {

        //    }
        //    return result;
        //}
    }
}

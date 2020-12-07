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
                                ShowType = ShowType.TVShow,
                                Status = Status.Available,
                                NumSeasonsConfirmed = 4,
                                LatestSeasonAvailable = 4,
                                NumEpisodes = 11,
                                Description = "American Black Comedy"},
                new Show() {    Title = "Succession",
                                ShowType = ShowType.TVShow,
                                Status = Status.NoReleaseDate,
                                IsWatched = false,
                                NumSeasonsConfirmed = 3,
                                LatestSeasonAvailable = 2,
                                Description = "American Drama/Comedy based on the Roy family, " +
                                "owners of a global media company"},
                new Show() {    Title = "Upright",
                                ShowType = ShowType.TVShow,
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
                                ShowType = ShowType.TVShow,
                                Status = Status.NoReleaseDate,
                                NumSeasonsConfirmed = 2,
                                LatestSeasonAvailable = 1,
                                NumEpisodes = 10,
                                Description = "American Drama comedy starring Jennifer Anniston, " +
                                "Reese Witherspoon and Steve Carell about a Morning Show.  Great script" +
                                "and story lines"}

            };

        //[HttpGet]
        //public IEnumerable<Show> GetAllShows()
        //{
        //    shows.OrderBy(s => s.ShowType).ThenBy(s => s.Title);
        //    return shows.ToArray();
        //}


        //FROM EAD2 SAMPLE
        // GET api/shows/all
        [HttpGet("all")]
        public IEnumerable<Show> GetAll()
        {
            shows.OrderBy(s => s.ShowType).ThenBy(s => s.Title);
            return shows.ToArray();       // 200 OK, weather serialized in response body
        }


        [HttpGet("allmovies")]
        public IEnumerable<Show> GetAllMovies()
        {
            var movies = shows.Where(s => s.ShowType == ShowType.Movie);
            return movies.ToArray();
        }


        [HttpGet("alltvshows")]
        public IEnumerable<Show> GetAllTVShows()
        {
            var tvShows = shows.Where(s => s.ShowType == ShowType.TVShow);
            return tvShows.ToArray();
        }


        [HttpGet("alldocumentaries")]
        public IEnumerable<Show> GetAllDocumentaries()
        {
            var tvShows = shows.Where(s => s.ShowType == ShowType.Documentary);
            return tvShows.ToArray();
        }


        //[HttpGet("shows/showtype/{showtype:ShowType}")]
        //// GET weather/cities/warning/true or false
        //public IEnumerable<string> GetCityNameForWarningStatus(bool warning)
        //{
        //    // LINQ query, find cities whoose weather warning status matches warning paramater
        //    var cities = weather.Where(w => w.WeatherWarning == warning).Select(w => w.City);
        //    return cities;
        //}

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

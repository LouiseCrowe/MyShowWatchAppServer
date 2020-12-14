using MyShowWatch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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

        readonly List<Show> shows = new List<Show>()
            {
                new Show() {    Title = "Fargo",
                                ShowType = ShowType.TVShow,
                                Status = Status.Available,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumSeasonsConfirmed = 4,
                                LatestSeasonAvailable = 4,
                                NumEpisodes = 11,
                                IsKidFriendly = false,
                                Description = "American black comedy"},
                new Show() {    Title = "Succession",
                                ShowType = ShowType.TVShow,
                                Status = Status.NoReleaseDate,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumSeasonsConfirmed = 3,
                                LatestSeasonAvailable = 2,
                                NumEpisodes = 10,
                                IsKidFriendly = false,
                                Description = "American Drama/Comedy based on the Roy family, " +
                                "owners of a global media company"},
                new Show() {    Title = "Billions",
                                ShowType = ShowType.TVShow,
                                Status = Status.AwaitingRelease,
                                IsWatched = false,
                                ReleaseDate = new DateTime(2021, 4, 1),
                                ShowComplete = false,
                                NumSeasonsConfirmed = 6,
                                LatestSeasonAvailable = 5,
                                NumEpisodes = 10,
                                IsKidFriendly = false,
                                Description = "American drama about a billionaire hedge" +
                                "fund manager and a US Attorney's attempt to convict him" +
                                "for financial crimes."},
                new Show() {    Title = "Upright",
                                ShowType = ShowType.TVShow,
                                Status = Status.NoReleaseDate,
                                IsWatched = true,
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumSeasonsConfirmed = 1,
                                LatestSeasonAvailable = 1,
                                NumEpisodes = 8,
                                IsKidFriendly = false,
                                Description = "Fantastic comedy/drama following a musician " +
                                "and teenager's adventures as they transport an upright piano " +
                                "from Sydney to Perth"},
                new Show() {    Title = "The A-Team",
                                ShowType = ShowType.TVShow,
                                Status = Status.NoReleaseDate,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = true,
                                NumSeasonsConfirmed = 5,
                                LatestSeasonAvailable = 5,
                                NumEpisodes = 25,
                                IsKidFriendly = true,
                                Description = "In 1972, a crack commando unit was sent to prison " +
                                "by a military court for a crime they didn't commit. These men " +
                                "promptly escaped from a maximum security stockade to the Los " +
                                "Angeles underground. Today, still wanted by the government, " +
                                "they survive as soldiers of fortune"},
                new Show() {    Title = "Louis Theroux's Weird Weekends",
                                ShowType = ShowType.Documentary,
                                Status = Status.Available,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = true,
                                NumSeasonsConfirmed = 3,
                                LatestSeasonAvailable = 3,
                                NumEpisodes = 8, 
                                IsKidFriendly = false, 
                                Description = "Louis travelling around meeting weird and wonderful" +
                                " people"},
                new Show() {    Title = "The Devil Next Door",
                                ShowType = ShowType.Documentary,
                                Status = Status.Available,
                                IsWatched = true, 
                                ReleaseDate = null,
                                ShowComplete = true,
                                NumSeasonsConfirmed = 1,
                                LatestSeasonAvailable = 1,
                                NumEpisodes = 5,
                                IsKidFriendly = false,
                                Description = "Documentary about the trial in Israel of a former " +
                                "Ukranian citizen living in the US accused of being Ivan the Terrible a " +
                                "notorious concentration camp guard"},
                new Show() {    Title = "Peaky Blinders",
                                ShowType = ShowType.TVShow,
                                Status = Status.AwaitingRelease,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumSeasonsConfirmed = 6,
                                LatestSeasonAvailable = 5,
                                NumEpisodes = 6,
                                IsKidFriendly = true,
                                Description = "In 1972, a crack commando unit was sent to prison " +
                                "by a military court for a crime they didn't commit. These men " +
                                "promptly escaped from a maximum security stockade to the Los " +
                                "Angeles underground. Today, still wanted by the government, " +
                                "they survive as soldiers of fortune"},
                new Show() {    Title = "Vietnam",
                                ShowType = ShowType.Documentary,
                                Status = Status.Available,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = true,
                                NumSeasonsConfirmed = 1,
                                LatestSeasonAvailable = 1,
                                NumEpisodes = 12,
                                IsKidFriendly = false,
                                Description = "Documentary about the Vietnam War"},
                new Show() {    Title = "Uncut Gems",
                                ShowType = ShowType.Movie,
                                Status = Status.Available,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = true,
                                IsKidFriendly = false,
                                Description = "Crime thriller starring Adam Sandler"},
                new Show() {    Title = "Black Widow",
                                ShowType = ShowType.Movie,
                                Status = Status.AwaitingRelease,
                                IsWatched = false, 
                                ReleaseDate = new DateTime(2021, 5, 7),
                                ShowComplete = false,
                                NumMovies = 10,
                                LatestMovieAvailable = 9,
                                IsKidFriendly = true,
                                Description = "Latest in the Marvel series starring Scarlett Johansen"},
                new Show() {    Title = "The SpongeBob Movie: Sponge on the Run",
                                ShowType = ShowType.Movie,
                                Status = Status.Available,
                                IsWatched = true, 
                                ShowComplete = true,
                                ReleaseDate = null,
                                IsKidFriendly = true,
                                Description = "Sponge Bob's adventures rescuing his pet snail Gary"},
                new Show() {    Title = "The Morning Show",
                                ShowType = ShowType.TVShow,
                                Status = Status.NoReleaseDate,
                                IsWatched = false, 
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumSeasonsConfirmed = 2,
                                LatestSeasonAvailable = 1,
                                NumEpisodes = 10,
                                IsKidFriendly = false,
                                Description = "American drama comedy starring Jennifer Anniston, " +
                                "Reese Witherspoon and Steve Carell about a Morning Show.  Great script" +
                                " and story lines"},
                new Show() {    Title = "X Men",
                                ShowType = ShowType.Movie,
                                Status = Status.NoReleaseDate,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumMovies = 7,
                                LatestMovieAvailable = 6,
                                IsKidFriendly = true,
                                Description = "Adventure movie following the exploits of mutants with " +
                                "amazing gifts"},
                new Show() {    Title = "Fantastic Four",
                                ShowType = ShowType.Movie,
                                Status = Status.NoReleaseDate,
                                IsWatched = false,
                                ReleaseDate = null,
                                ShowComplete = false,
                                NumMovies = 5,
                                LatestMovieAvailable = 4,
                                IsKidFriendly = true,
                                Description = "A contemporary re-imagining of Marvel's original and " +
                                "longest-running superhero team, centres on four young outsiders who " +
                                "teleport to an alternate and dangerous universe, which alters their " +
                                "physical form in shocking ways"}
            };

      
        // GET show/all
        [HttpGet("all")]
        [Produces("application/json")]
        public IEnumerable<Show> GetAll()
        {
            var allShows = shows.OrderBy(s => s.Title);
            return allShows;       
        }


        [HttpGet("allmovies")]
        public IEnumerable<Show> GetAllMovies()
        {
            var movies = shows.Where(s => s.ShowType == ShowType.Movie)
                              .OrderBy(s => s.Title);

            return movies;
        }


        [HttpGet("alltvshows")]
        public IEnumerable<Show> GetAllTVShows()
        {
            var tvShows = shows.Where(s => s.ShowType == ShowType.TVShow)
                                .OrderBy(s => s.Title); 
            return tvShows;
        }


        [HttpGet("alldocumentaries")]
        public IEnumerable<Show> GetAllDocumentaries()
        {
            var documentaries = shows.Where(s => s.ShowType == ShowType.Documentary)
                               .OrderBy(s => s.Title); 
            return documentaries;
        }


        [HttpGet("search/{titleNoSpaces}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Show> GetSearchResultForShow([FromRoute]string titleNoSpaces)
        {
            Show searchResult = shows.FirstOrDefault(s => s.Title.ToLower() == titleNoSpaces.ToLower());
            if (searchResult == null)
            {
                return NotFound();
            }
            return new OkObjectResult(searchResult);
        }

    }
}

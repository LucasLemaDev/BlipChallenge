using BlipChallenge.Models.Responses.GitHubClient;
using BlipChallenge.Services.External;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlipChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        private readonly IGitHubServices _gitHubServices;

        public GitHubController(IGitHubServices gitHubServices)
        {
            _gitHubServices = gitHubServices;
        }

        [HttpGet("{userName}/repos")]
        public async Task<ActionResult<List<GitHubRepository>>> GetUserReposByName([FromRoute] string userName)
        {
            var response = await _gitHubServices.GetReposByUserName(userName);
            return Ok(response);
        }
    }
}

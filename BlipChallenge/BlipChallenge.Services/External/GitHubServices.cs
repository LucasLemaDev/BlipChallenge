using BlipChallenge.Models.Responses.GitHubClient;
using BlipChallenge.Services.External.Clients;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace BlipChallenge.Services.External
{
    public class GitHubServices : IGitHubServices
    {
        private readonly IGitHubClient _gitHubClient;
        public GitHubServices(IGitHubClient gitHubClient)
        {
            _gitHubClient = gitHubClient;
        }

        public async Task<List<GitHubRepository>> GetReposByUserName(string userName)
        {
            var res = await _gitHubClient.GetReposByUserNameAsync(userName);
            var data = JsonConvert.DeserializeObject<List<GitHubRepository>>(res);
            data = data.OrderBy(d => d.CreatedAt)
                        .Take(5)
                        .ToList() ;   
            return data;
        }
    }
}

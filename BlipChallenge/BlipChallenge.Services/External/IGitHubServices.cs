using BlipChallenge.Models.Responses.GitHubClient;

namespace BlipChallenge.Services.External
{
    public interface IGitHubServices
    {
        Task<List<GitHubRepository>> GetReposByUserName(string userName);
    }
}

using BlipChallenge.Models.Responses.GitHubClient;
using RestEase;
using System.Reflection.Metadata;

namespace BlipChallenge.Services.External.Clients
{
    public interface IGitHubClient
    {
        [Get("users/{userName}/repos")]
        Task<string> GetReposByUserNameAsync([Path] string userName, [Header("User-Agent")] string request = "request");
    }
}

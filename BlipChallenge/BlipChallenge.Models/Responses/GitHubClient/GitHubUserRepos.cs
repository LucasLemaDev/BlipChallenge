using Newtonsoft.Json;

namespace BlipChallenge.Models.Responses.GitHubClient
{
    public class GitHubRepository
    {
        public string Name { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        public string Description { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt {  get; set; } 
    }
}


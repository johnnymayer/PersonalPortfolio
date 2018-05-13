using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PersonalPortfolio.Models
{
    public class Repo
    {
        public string UrlAddress { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        public static List<Repo> GetRepos()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("search/repositories?q=user:johnnymayer&sort=stars&order=desc&per_page=3");

            var response = new RestResponse();

            request.AddHeader("User-Agent", "johnnymayer");

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var repoList = JsonConvert.DeserializeObject<List<Repo>>(jsonResponse["items"].ToString());
            return repoList;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}
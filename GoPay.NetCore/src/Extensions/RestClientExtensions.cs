using RestSharp;
using System.Threading.Tasks;
using RestSharp.Newtonsoft.Json.NetCore;

namespace GoPay.Extensions
{
    public static class RestClientExtensions
    {
        /// <summary>
        /// Since the default RestSharp async api sucks, this is simple workaround to get it work without harder refactoring.
        /// </summary>
        /// <param name="me"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static async Task<IRestResponse> ExecuteAsync(this RestClient me, IRestRequest request)
        {
            return await Task.Factory.StartNew(() => {
                return me.Execute(request);
            });
        }
    }
}

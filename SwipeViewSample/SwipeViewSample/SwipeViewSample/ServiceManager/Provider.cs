using Newtonsoft.Json;
using SwipeViewSample.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwipeViewSample.ServiceManager
{
    public class Provider
    {
        public async Task<Person> GetPersons()
        {
            var client = new HttpClient();
            return JsonConvert.DeserializeObject<Person>(await client.GetStringAsync("https://randomuser.me/api/?results=25"));
        }
    }
}
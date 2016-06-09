using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1;
using System.ServiceModel;
using dotnetconf.Model;

namespace dotnetconf.Controllers
{
    [Route("api/[controller]")]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private int sample = 75;

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<People>> Get()
        {

            var people = await Mashup();

            return people;
        }

        private async Task<IEnumerable<PersonMajor>> GetSomePeeps(int count)
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            var ws = new GetPeopleServiceClient(binding, new EndpointAddress("http://peopleservice.azurewebsites.net/people.svc"));

            var people = await ws.GetCompletePeopleAsync(count);
            return people;
        }

        private async Task<ServiceReference1.Address[]> GetSomeAddress(int count)
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            var ws = new ServiceReference1.GetAddressServiceClient(binding, new EndpointAddress("http://peopleservice.azurewebsites.net/address.svc"));

            var addys = await ws.GetAddressDataAsync(count);
            return addys;
        }

        private async Task<People[]> Mashup()
        {
            var people = new List<People>(sample);
            var peeps = Task.Run(() => GetSomePeeps(sample)).ContinueWith(p => this.PopulatePeople(p.Result.ToArray(), people));

            var addresses = Task.Run(() => GetSomeAddress(sample));

            await Task.WhenAll(peeps, addresses);

            return people.ToArray();

        }

        private void PopulatePeople(PersonMajor[] peeps, List<People> people)
        {
            for (int i = 0; i < sample; i++)
            {
                people.Add(new People() { First = peeps[i].ItemPersonData.First, Last = peeps[i].ItemPersonData.Last });
            }
        }

        private void PopulatePeopleAddresses(ServiceReference1.Address[] addys, List<People> people)
        {
            for (int i = 0; i < sample; i++)
            {
                people[i].ZipCode = addys[i].ZipCode;
            }
        }
    }
}

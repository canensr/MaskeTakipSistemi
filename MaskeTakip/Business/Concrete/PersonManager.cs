using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService 
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }
        public async Task<bool>  CheckPerson(Person person)
        {//mernis kontrolü

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var response = await client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear);
            return response.Body.TCKimlikNoDogrulaResult;
                
        }
    }
}

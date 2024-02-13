using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference1;
using System;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                person.NationalIdentity,
                person.FirstName, 
                person.LastName, 
                person.DateOfBirthYear
                ).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}



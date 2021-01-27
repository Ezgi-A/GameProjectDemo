using GameProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract.Adapters
{
    public class ServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(member.NationalityId, member.Name, member.LastName.ToUpper(),
                member.DateOfBirth.Year);
        }
    }
}

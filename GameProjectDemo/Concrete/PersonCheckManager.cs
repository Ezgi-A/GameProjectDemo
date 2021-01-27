using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public interface PersonCheckManager:IPersonCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            if (CheckIfRealPerson(member))
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid person");
            }
            
        }
    }
}

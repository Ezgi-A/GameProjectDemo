using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class DataBaseLoggerManager:ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} Database'e eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} Database'den silindi.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} güncellendi.");
        }
    }
}

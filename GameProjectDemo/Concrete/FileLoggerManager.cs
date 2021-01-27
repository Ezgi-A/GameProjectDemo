using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class FileLoggerManager:ILoggerService
    {

        public void Add(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} dosyaya eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} dosyadan silindi.");

        }

        public void Update(IEntity entity)
        {
            Console.WriteLine($"Dosyadaki {entity.Name} güncellendi.");
        }
    }
}

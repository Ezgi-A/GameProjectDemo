using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ILoggerService
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
    }
}

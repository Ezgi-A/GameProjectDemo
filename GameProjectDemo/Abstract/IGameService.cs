using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface IGameService
    {
        void Add(IEntity game);
        void Delete(IEntity game);
        void Update(IEntity game);
    }
}

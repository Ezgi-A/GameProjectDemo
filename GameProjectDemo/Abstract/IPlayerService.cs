using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IPlayerService
    {
        void Add(IEntity player);
        void Delete(IEntity player);
        void Update(IEntity player);
        void Add(object ezgi);
    }
}

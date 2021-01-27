using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPersonCheckService _personCheckService;
        private List<ILoggerService> _loggerServices;

        public PlayerManager(IPersonCheckService personCheckService, List<ILoggerService> loggerServices)
        {
            _personCheckService = personCheckService;
            _loggerServices = loggerServices;
        }
        public void Add(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Add(object ezgi)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity player)
        {
            throw new NotImplementedException();
        }
    }
}

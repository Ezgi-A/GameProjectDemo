using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        private List<ILoggerService> _loggerServices;

        public GameManager(List<ILoggerService> loggerServices)
        {
            this._loggerServices = loggerServices;
        }

        public void Add(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Delete(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(game);
            }
        }

        public void Update(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }
    }
}

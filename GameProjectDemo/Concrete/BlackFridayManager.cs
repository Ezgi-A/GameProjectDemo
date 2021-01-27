using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class BlackFridayManager : ISalesService

    {

        private List<ILoggerService> _loggerServices;

        public BlackFridayManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void Discount(Game game)
        {
            game.UnitPrice *= (double)0.75;
        }
    }
}

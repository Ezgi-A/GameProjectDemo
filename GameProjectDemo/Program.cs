using GameProject.Abstract;
using GameProject.Abstract.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args, IEntity ezgi, IEntity batın, IEntity betül, IEntity mortalcombat, IEntity sims4, IEntity asasinscreed)
        {
            IPersonCheckService personCheck = new ServiceAdapter();
            ILoggerService databaseLogger = new DatabaseLoggerManager();
            ILoggerService fileLogger = new FileLoggerManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { fileLogger };

            IPlayerService playerManager = new PlayerManager(personCheck, loggerServices);

            IEntity selim = new Player() { Name = "Ezgi", LastName = "Arslan", UserName = "andrewia", Password = "3356987", DateOfBirth = new DateTime(1997, 05, 16), NationalityId = 18965471236 };
            IEntity emre = new Player() { Name = "Batın", LastName = "Kaya", UserName = "btm", Password = "1234524", DateOfBirth = new DateTime(1996, 12, 19), NationalityId = 12345698741 };
            IEntity mehmet = new Player() { Name = "Betül", LastName = "Arap", UserName = "barap", Password = "1234567", DateOfBirth = new DateTime(1982, 05, 11), NationalityId = 15659716971 };

            playerManager.Add(ezgi);
            playerManager.Add(batın);
            playerManager.Add(betül);



            IEntity MortalCombat = new Game() { Name = "MortalCombat", UnitPrice = (double)109.90 };
            IEntity Sims4 = new Game() { Name = "Sims4", UnitPrice = (double)60.90 };
            IEntity AssasinsCreed = new Game() { Name = "AssasinsCreed ", UnitPrice = (double)155.90 };

            IGameService gameManager = new GameManager(loggerServices);

            gameManager.Add(mortalcombat);
            gameManager.Add(sims4);
            gameManager.Add(asasinscreed);




            ISalesService blackSales = new BlackFridayManager(loggerServices);


            IPlatformService platformManager = new SteamPlatformManager(new List<ISalesService> { blackSales });
            platformManager.BuyGameFromPlayer(ezgi, mortalcombat);
            platformManager.BuyGameFromPlayer(batın, sims4);
            platformManager.BuyGameFromPlayer(betül, asasinscreed);
            platformManager.RefundGameFromPlayer(batın, sims4);

        }
    }
}

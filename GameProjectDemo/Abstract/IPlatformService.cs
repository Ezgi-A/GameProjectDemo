using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface IPlatformService
    {
        void BuyGameFromPlayer(IEntity player, IEntity game);
        void RefundGameFromPlayer(IEntity player, IEntity game);
    }
}

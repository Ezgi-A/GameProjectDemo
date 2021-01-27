using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public  class Game:IEntity
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public double UnitPrice { get; set; }
    }
}

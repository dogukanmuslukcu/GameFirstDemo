using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    interface IGameService
    {
        void Add(Player player);
        void Remove(Player player);
        void Update(Player player);
    }
}

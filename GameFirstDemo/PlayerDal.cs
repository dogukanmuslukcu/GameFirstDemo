using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class PlayerDal : IGameDal
    {
        public void Add()
        {
            Console.WriteLine("Player added.");
        }

        public void Remove()
        {
            Console.WriteLine("Player Removed.");
        }

        public void Update()
        {
            Console.WriteLine("Player Updated.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class PlayerDal : IGameService
    {
        ICheckService _checkService;
        public PlayerDal(ICheckService checkService)
        {
            _checkService = checkService;
        }
        public void Add(Player player)
        {
            if (_checkService.Check(player))
            {
                Console.WriteLine("Player added.");
            }
            else
            {
                Console.WriteLine("Player  wasn't added");
            }

        }

        public void Remove(Player player)
        {
            Console.WriteLine("Player Removed.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player Updated.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class SalesManager
    {
        public void SellCoin(Players player,List<ICampaigns> campaigns )
        {
            foreach (var item in campaigns)
            {
                item.Add();
            }
            if (player.PlayerExperience > 5000 && campaigns.Count>=1) 
            {
                Console.WriteLine("Coin satın alınmıştır"+campaigns+" 'in "+"indirimi uygulanmıştır");
            }
        }
    }
}

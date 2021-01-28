using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class SalesManager
    {
        public void SellCoin(Player player, List<ICampaignsService> campaigns)
        {
            if (player.PlayerExperience >= 5000)
            {
                Console.WriteLine("Coin satın alınmıştır"); 
                
                foreach (var item in campaigns)
                {
                    item.Add();
                }

            }
            else
            {
                Console.WriteLine("Tecrübe puanınız yetersizdir.");

            }


        }
    }
}

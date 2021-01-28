using System;
using System.Collections.Generic;

namespace GameFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.ID = 1;
            player1.FirstName = "Doğukan";
            player1.LastName = "Muslukçu";
            player1.TCNumber = "1234567890";
            player1.PlayerExperience = 4000;

            ChristmassCampaignDal christmassCampaignDal = new ChristmassCampaignDal();
            ClassicCampaignDal classicCampaignDal = new ClassicCampaignDal();


            List<ICampaignsService> campaigns = new List<ICampaignsService>() { christmassCampaignDal,classicCampaignDal };

            PlayerDal playerDal = new PlayerDal(new EDevletCheckManager());
            playerDal.Add(player1);


        }
    }
}

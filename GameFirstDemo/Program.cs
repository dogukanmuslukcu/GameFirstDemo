using System;
using System.Collections.Generic;

namespace GameFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player1 = new Players();
            player1.ID = 1;
            player1.FirstName = "Doğukan";
            player1.LastName = "Muslukçu";
            player1.TCNumber = "1234567890";
            player1.PlayerExperience = 4000;

            ChristmassCampaignDal christmassCampaignDal = new ChristmassCampaignDal();
            ClassicCampaignDal classicCampaignDal = new ClassicCampaignDal();


            List<ICampaigns> campaigns = new List<ICampaigns>() { christmassCampaignDal,classicCampaignDal };



            EDevletCheck eDevletCheck = new EDevletCheck();
           eDevletCheck.Check(player1,"mustafa","demir","1235468977890");
           eDevletCheck.Check(player1, "Doğukan", "Muslukçu", "1234567890");

            SalesManager salesManager = new SalesManager();
            salesManager.SellCoin(player1,campaigns);



        }
    }
}

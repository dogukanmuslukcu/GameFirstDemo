using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class ClassicCampaignDal : ICampaignsService
    {
        public void Add()
        {
            Console.WriteLine(" Klasik kampanya eklendi.");
        }

        public void Remove()
        {
            Console.WriteLine(" Klasik kampanya kaldırıldı.");
        }

        public void Update()
        {
            Console.WriteLine("Klasik Kampanya güncellendi.");
        }
    }
}

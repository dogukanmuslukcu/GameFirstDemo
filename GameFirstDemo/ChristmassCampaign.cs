using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class ChristmassCampaign : ICampaigns
    {
        public void Add()
        {
            Console.WriteLine("Yılbaşı kampanyası eklendi.");
        }

        public void Remove()
        {
            Console.WriteLine("Yılbaşı kampanyası kaldırıldı.");  
        }

        public void Update()
        {
            Console.WriteLine(" Yılbaşı kampanyası güncellendi.");
        }
    }
}

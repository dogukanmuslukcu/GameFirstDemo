using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class EDevletCheckManager : ICheckService
    {
        public bool Check(Player player)
        {
            if (player.FirstName=="Doğukan" && player.LastName == "Muslukçu" && player.TCNumber == "1234567890") 
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}

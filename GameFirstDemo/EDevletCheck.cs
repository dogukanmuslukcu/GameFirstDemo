using System;
using System.Collections.Generic;
using System.Text;

namespace GameFirstDemo
{
    class EDevletCheck
    {
        string userWriteName;
        string userWriteLastName;
        string userWriteTcNum;
        string userWriteBirthDate;
        public void Check(Players player, string userWriteName, string userWriteLastName, string userWriteTcNum)
        {
            if (userWriteBirthDate == player.BirthdayDate && userWriteLastName == player.LastName && userWriteTcNum == player.TCNumber)
            {
                Console.WriteLine(player.FirstName +" Hoşgeldiniz.");
                Console.WriteLine("Hesabınıza başarıyla yönlerndiriliyorsunuz.");
            }
            else
            {
                Console.WriteLine("Üzgünüz yanlış bilgi girdiniz lütfen tekrar deneyiniz.");
            }
        }
    }
}

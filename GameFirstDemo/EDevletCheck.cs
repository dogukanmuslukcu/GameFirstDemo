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
        public void check(Players players)
        {
            if (userWriteBirthDate == players.BirthdayDate && userWriteLastName == players.LastName && userWriteTcNum == players.TCNumber)
            {
                Console.WriteLine("Hesabınıza başarıyla yönlerndiriliyorsunuz.");
            }
            else
            {
                Console.WriteLine("Üzgünüz yanlış bilgi girdiniz lütfen tekrar deneyiniz.");
            }
        }
    }
}

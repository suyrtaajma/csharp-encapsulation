using System;
using System.Collections.Generic;
using System.Text;

namespace rumahsakit
{
    class dokter : user
    {
        private string blank;

        public object biodataDokter()
        {
            nomorhp = "08233123";
            Console.WriteLine("Nomor HP    : " + nomorhp);
            nomorID = "B0001";
            Console.WriteLine("Nomor ID    : " + nomorID);
            bangsal = "Dua";
            Console.WriteLine("Bangsal     : " + bangsal);
            blank = " ";
            Console.WriteLine(blank);
            return blank;
        }
    }
}
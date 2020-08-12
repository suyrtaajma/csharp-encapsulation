using System;
using System.Collections.Generic;
using System.Text;

namespace latihanenkapsulasi
{
    class osis : student
    {
        public void organisasi()
        {
            base.alamat = "purwokerto";
            Console.WriteLine(alamat);

            gender = "Pria";
        }
    }
}

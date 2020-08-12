using System;

namespace latihanenkapsulasi
{
    class Program
    {
        static void Main(string[] args)
        {
            student siswa = new student();
            siswa.nama = "lulu";
            siswa.gender = "perempuan";

            siswa.Nilai = 50;

            osis osis1 = new osis();
            osis1.organisasi();
            osis1.gender = "pria";
            

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace latihanenkapsulasi
{
    class student
    {
        //modifier yang bisad diakses oleh class lain
        public string nama;
        //modifier yg hanya bisa diakses olaeh class ana
        protected string alamat;
        //modifer yg hany bisa diakses oleh
        internal string gender;
        //modifer yang  hanya bisa diakses oleh class itu
        private int nilai = 50  ;
        // abstraction\

        // method getter : mendapatkan
        public int getnilai()
        {
            return nilai;
        }

        //  method setter : menetapkan, mengatur, memodifikasi, menyiapkan

        public int setnilai()
        {
            int nilai1 = 50;
            nilai += nilai1;
            Console.WriteLine(nilai);
            return nilai;
        }


        //class propertio
        public int Nilai
        {
            get { return nilai;  }
            set {
                nilai += value;
            }
        }     



    }
}

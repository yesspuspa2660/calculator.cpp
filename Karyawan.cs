using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemprograman2660
{
    class Karyawan
    {
        public string Nama;
        public int NIK;
        public int GajiBulanan;
        public Karyawan(string arg0, int arg1, int arg2)
        {
            Nama = arg0;
            NIK = arg1;
            GajiBulanan = arg2;

            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
        }
       
    }
}

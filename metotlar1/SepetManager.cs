using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar1
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunadi, double fiyati, string aciklama, int stokAdedi )
        {
            Console.WriteLine("tebrikler sepete eklendi : " + urunadi);
        }

    }
}

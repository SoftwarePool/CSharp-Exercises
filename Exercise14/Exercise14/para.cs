using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise14
{
    class para
    {
        public islemSonuc firlat(int kacdefa, int turaYuzdesi)
        {
            Random _random = new Random();

            List<int> yuzde = new List<int>();
            for (int x = 1; x < 101; x++)
                yuzde.Add(x);

            islemSonuc i = new islemSonuc() { bilgi = "İşlem Başlamadı", turaSayisi = 0, yaziSayisi = 0, kacdefa = kacdefa, gelenYuzler = new List<string>() };
            if (kacdefa % 2 == 0 && kacdefa > 0 && turaYuzdesi <= 100 && turaYuzdesi >= 0)
            {
                for (int de = 1; de <= kacdefa; de++)
                {
                    int a = _random.Next(1, 101);

                    if (a <= turaYuzdesi)
                    {
                        i.gelenYuzler.Add("tura");
                        i.turaSayisi = i.turaSayisi + 1;
                    }
                    else
                    {
                        i.yaziSayisi = i.yaziSayisi + 1;
                        i.gelenYuzler.Add("yazi");
                    }
                }
            }
            return i;
        }
    }
}

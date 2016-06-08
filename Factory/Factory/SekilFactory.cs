using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public enum ESekilTur
    {
        cember,
        dikdortgen,
        kare
    };
    public class SekilFactory
    {

        public ISekil getSekil(ESekilTur sekilTipi)
        {
            switch (sekilTipi)
            {
                case ESekilTur.cember:
                    return new Cember();
                case ESekilTur.dikdortgen:
                    return new Dikdortgen();
                case ESekilTur.kare:
                    return new Kare();
                default:
                    return null;
            }
        }
    }
}

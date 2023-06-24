using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesaplama.Lib
{
    public class SözlesmeliPersonel : BasePersonel
    {
        #region Fields

        private double saatlikÜcret;
        private double calistiğiSaat;

        #endregion

        public SözlesmeliPersonel(double sicilNumarasi, string adi, string soyadi, double saatlikÜcreti, double calistiğiSaati) : base(adi, soyadi, sicilNumarasi)
        {
            saatlikÜcret = saatlikÜcreti;
            calistiğiSaat = calistiğiSaati;
        }

        #region Properties

        public double AylikÜcret { get => saatlikÜcret; set => saatlikÜcret = Math.Abs(value); }
        public double İzin { get => calistiğiSaat; set => calistiğiSaat = Math.Abs(value); }

        #endregion

        #region Methods 

        public string AdSoyadGetir()
        {
            return $"Adi : {Adi}, Soyadi : {Soyadi}";
        }

        public override double AylikGetir()
        {
            return saatlikÜcret * calistiğiSaat;
        }
        #endregion
    }
}

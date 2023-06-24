using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesaplama.Lib
{
    public class StajyerPersonel : BasePersonel
    {
        #region Fields

        private double günlükÜcret;
        private double günlükSaat;

        #endregion

        public StajyerPersonel(double sicilNumarasi, string adi, string soyadi, double günlükÜcreti, double günlükSaati) : base(adi, soyadi, sicilNumarasi)
        {
            GünlükÜcret = günlükÜcreti;
            GünlükSaat = günlükSaati;
        }
        

        #region Properties

        public double GünlükÜcret { get => günlükÜcret; set => günlükÜcret = Math.Abs(value); }
        public double GünlükSaat { get => günlükSaat; set => günlükSaat = Math.Abs(value); }

        #endregion

        #region Methods 

        public string AdSoyadGetir()
        {
            return $"Adi : {Adi}, Soyadi : {Soyadi}";
        }

        public override double AylikGetir()
        {
            return günlükÜcret * günlükSaat;
        }
        #endregion
    }
}

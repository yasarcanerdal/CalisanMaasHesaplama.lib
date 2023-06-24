using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesaplama.Lib
{
    public class KadroluPersonel : BasePersonel
    {
        #region Fields

        private double aylikÜcret;
        private double izin;

        #endregion

        public KadroluPersonel(double sicilNumarasi, string adi, string soyadi, double aylikÜcreti, double izin) : base(adi,soyadi,sicilNumarasi)  
        {
            AylikÜcret = aylikÜcreti;
            İzin = izin;
        }

        #region Properties

        public double AylikÜcret { get => aylikÜcret; set => aylikÜcret = Math.Abs(value); }
        public double İzin { get => izin; set => izin = Math.Abs(value); }

        #endregion

        #region Methods 

        public string AdSoyadGetir()
        {
            return $"Adi : {Adi}, Soyadi : {Soyadi}";
        }

        public override double AylikGetir()
        {
            if (İzin <= 5)
                return AylikÜcret;
            else
                return AylikÜcret - (AylikÜcret / 30) * İzin;

        }

        #endregion
    }
}

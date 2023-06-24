namespace CalisanMaasHesaplama.Lib
{
    public class BasePersonel
    {
        #region Fields

        private double sicilNumarasi;
        private string adi;
        private string soyadi;

        #endregion

        #region Constructors

        public BasePersonel()
        {

        }
        public BasePersonel(string adi, string soyadi, double sicilNumarasi)
        {
            SicilNumarasi = sicilNumarasi;
            Adi = adi;
            Soyadi = soyadi;
        }
        #endregion

        #region Properties

        public double SicilNumarasi { get => sicilNumarasi; set => sicilNumarasi = Math.Abs(value); }
        public string Adi
        {
            get => adi;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Boş Olamaz.");
                }
                adi = value.Trim().ToUpper();
            }
        }
        public string Soyadi
        {
            get => soyadi;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Boş Olamaz.");
                }
                soyadi = value.Trim().ToUpper();
            }
        }

        #endregion

        #region Methods 

        public string BasePersonelBilgileriniGetir()
        {
            return $"Adi : {Adi}\nSoyadi : {Soyadi}\nSicilNumarasi : {SicilNumarasi}\nAylikÜcret";
        }

        public string AdSoyadGetir()
        {
            return $"Adi : {Adi} Soyadi : {Soyadi}";
        }

        public virtual double AylikGetir()
        {
            return 0 ;
        }

        #endregion
    }
}
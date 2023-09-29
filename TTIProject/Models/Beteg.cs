namespace TTIProject.Models
{
    public class Beteg 
    {
        private string _nev;
        public string Nev
        {
            get => _nev;
            set { _nev = value; }
        }

        private double _suly;
        public double Suly
        {
            get => _suly;
            set { _suly = value; }
        }

        private double _magassag;
        public double Magassag
        {
            get => _magassag;
            set { _magassag = value; }
        }

        public Beteg()
        {
            _nev = string.Empty;
            _suly = 60;
            _magassag = 1.6;
        }

        public double TTI
        {
            get
            {
                double tti = _suly / Math.Pow(_magassag, 2);
                double roundedTTI = Math.Round(tti, 2);
                return roundedTTI;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return $"{_nev} beteg testőmeg indexe:  {TTI}";
            }
        }   
    }
}

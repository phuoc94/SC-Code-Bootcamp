using System;

public class Auto
{
    
        public int Nopeus { get; private set; }

        public int Huippunopeus { get; set; }

        public Auto(int huippunopeus) => Huippunopeus = huippunopeus;

        public void Kiihdytä()
        {
            Nopeus += 5;

            if ((Huippunopeus > 0) && (Nopeus > Huippunopeus))
            {
                Nopeus = Huippunopeus;
            }
        }

        public void Jarruta()
        {
            Nopeus -= 5;

            if (Nopeus < 0)
            {
                Nopeus = 0;
            }
        }


}
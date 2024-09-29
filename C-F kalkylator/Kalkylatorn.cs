namespace C_F_kalkylator
{
    public class KalkylatornCtoF
    {
        public double Celsius { get; set; }
        public double Farenhite {  get; set; }


        public void ConvertCtoF()
        {
            Farenhite = (Celsius * 9 / 5) + 32;
        }

    }



}

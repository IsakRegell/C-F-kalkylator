namespace C_F_kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KalkylatornCtoF kalkylator = new KalkylatornCtoF();

            Console.Write("Hej! Skriv in hur många Celsius det är idag : ");
            Double Celsius = Convert.ToDouble(Console.ReadLine());

            kalkylator.Celsius = Celsius;

            kalkylator.ConvertCtoF();


            Console.WriteLine($"Detta är hur många grader det är i Farenhite : {kalkylator.Farenhite}");
        }

   
    }
}   

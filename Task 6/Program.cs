namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ay daxil edin: ");
            int Ay = int.Parse(Console.ReadLine());      
            int il = Ay / 12;
            int ay = Ay  % 12 ;

            if (Ay > 1 && Ay < 1188)
                Console.WriteLine($"{il} il {ay} ay");
            else
                Console.WriteLine("Eded verilen araliqda deyil!");



        }
    }
}
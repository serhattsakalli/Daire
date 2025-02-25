namespace Daire;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen çizmek istediğiniz dairenin yarı çapını giriniz...");
        int Yaricap= int.Parse(Console.ReadLine());
        string space=" ";
        for (int i = 1; i <= Yaricap; i++)
        {
            for (int b = 0; b <= Yaricap-i; b++)
            {
                Console.Write("  ");
            }
            for (int b = 1; b <= 4* i; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = Yaricap; i >= 1; i--)
        {
            for (int b = Yaricap-i; b >= 0; b--)
            {
                Console.Write("  ");
            }
            for (int b = 4* i; b >= 1; b--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

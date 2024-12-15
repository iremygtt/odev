namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("başlangıç değerini giriniz:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("bitiş değerini giriniz:");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("tek sayılar mı olsun çift sayılar mı?");
            string cevap = Console.ReadLine().ToLower();

            if (bas > bit)
            {
                int temp = bas;
                bas = bit;
                bit = temp;
            }

            int sonuc = 0;
            
            for (int i = bas; i <= bit; i++)
            
            {
                if (i % 2 == 0 && cevap == "çift")
                {
                    Console.WriteLine(i);
                    sonuc += i;
                }

            else if (i % 2 == 1 && cevap == "tek")
                {
                    Console.WriteLine(i);
                    sonuc += i;
                }
                
                if (i % 2 == (cevap == "tek" ? 1 : 0))
            
                {
                    Console.WriteLine(i);
                    sonuc += i;
                }
            }
            Console.WriteLine($"Sayıların Toplamı:{sonuc}");
        }
    }
}

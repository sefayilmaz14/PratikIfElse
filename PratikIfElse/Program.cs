Console.WriteLine("Lütfen Bir Sayı Giriniz:");

string giris = Console.ReadLine();
int sayi = Convert.ToInt32(giris);

if (sayi < 10)
{
    Console.WriteLine("Sayı 10'dan küçüktür.");
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Sayı Çift sayıdır.");
    }
    else
    {
        Console.WriteLine("Sayı Tek Sayıdır.");
    }
    
}
else if (sayi == 10)
{
    Console.WriteLine("Sayı 10'a eşittir");
    Console.WriteLine("Sayı Çift Sayıdır.");
}

else
{
    Console.WriteLine("Sayı 10'dan büyüktür.");
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Sayı Çift Sayıdır.");
    }
    else
    {
        Console.WriteLine("Sayı Tek Sayıdır.");
    }
}
Console.WriteLine("Kim Milyoner Olmak İster ? \nYarışmamıza Hoşgediniz! \nYarışmamız 3 sorudan oluşan kısa bir yarışma.\nHer soruda iki şık bulunmaktadır.\nSizden ricamız cevapları a veya b şeklinde cevap vermeniz.\n");
// Burada verilen doğru cevapları sayabilmemiz için bir değişken oluşturduk.
int dogruCevapSayısı = 0;

//Soruları sorduk ve cevap doğruysa doğru cevap sayısını bir artırır
Console.WriteLine("Soru 1: Türkiyenin başkenti neresidir ? \nA) İstanbul \nB) Ankara");
    string cevap1  = Console.ReadLine().ToLower();
if (cevap1 == "b" )
{
    dogruCevapSayısı ++;
    Console.WriteLine("Doğru cevap verdiniz!");
}
else
{
    Console.WriteLine("Yanlış cevap verdiniz!");
}

Console.WriteLine("Soru 2: Dünyanın şekli nedir ? \nA) Geoid \nB) Düz");
string cevap2 = Console.ReadLine().ToLower();
if (cevap2 == "a")
{
    dogruCevapSayısı ++;
    Console.WriteLine("Doğru cevap verdiniz!");
}
else
{
    Console.WriteLine("Yanlış cevap verdiniz!");
}

//Eğer Yarışmacı 2 soruyu da doğru bildiyse 3.soruyu sormadan direkt kazandınız mesajı verir.
if (dogruCevapSayısı == 1 )
{
    Console.WriteLine("Soru 3: Kızınca tüküren hayvan nedir? \nA) Lama \nB) Deve");
    string cevap3 = Console.ReadLine().ToLower();
    if (cevap3 == "a")
    {
        dogruCevapSayısı ++;
        Console.WriteLine("Doğru cevap verdiniz!\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
    }
    else
    {
        Console.WriteLine("Yanlış cevap verdiniz! \nÜzgünüz, büyük ödülü kazanamadınız.");
    }
}
else if (dogruCevapSayısı == 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else if (dogruCevapSayısı <= 1)
{
    Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız.");
}
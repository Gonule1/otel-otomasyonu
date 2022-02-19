class Program
{
public static double bakiye=0;
public static void anamenu()
{
Console.Write(” —ANA MENU —-: \n 1-yiyecekler \n 2-icecekler \n 3 -hesapode”);
Console.Write (“seciminizi giriniz: ” );
int secim =int.Parse(Console.ReadLine());
switch(secim){
case 1: yiyecekler();
break;

case 2: icecekler();
break;

case 3: hesap(); break;
default: Console.WriteLine(“yanlis secim yaptiniz ,lüten gecerli bir secim yapiniz : “); anamenu(); break;
}
}
public static void yiyecekler()
{
Console.WriteLine(“YİYCEKLER —: \n 1-etyemegi 5tl \n 2- manti \n 4tl 3-tavuk 3tl”);
Console.Write(“Yemek Seçiniz = “);
string secim=Console.ReadLine();
switch (secim)
{
case “1”: bakiye+=5; anamenu(); break;
case “2” : bakiye+=4; anamenu(); break;
case “3” : bakiye+=3 ;anamenu(); break;

}
}
public static void icecekler()
{
Console.WriteLine(“İCECEKLER :—– \n 1- ayran 1tl\n 2- kola 2tl 3-limonata 1.5 tl “);
int sec=int.Parse(Console.ReadLine());
switch(sec){
case 1: bakiye += 1; anamenu(); break;
case 2: bakiye += 2; anamenu(); break;
case 3: bakiye += 1.5; anamenu(); break;
default: Console.WriteLine(“yanlis secim yaptiniz ,lüten gecerli bir secim yapiniz : “); anamenu(); break;
}

}
public static void hesap()
{
Console.WriteLine(” “);
Console.WriteLine(“ödemeniz gerekn toplam ücret :  ” + bakiye + ” TL dir” );  // 😉
}

static void Main(string[] args)
{

//bir lokanta için menğ programi metodlr sayesinde çalışmaktadır .ilk önce ana menü listelencel,daha sorna secilen degerlerin alt listesi açılcak.müşteri secimi bitirildiklten

//sonra secimden hesabı sececek Version karsısına ödemesi gereken Para miktarı gösterilecek
//kullanıcı menü programlama:
anamenu();

 

Console.ReadKey(); ;

}
}
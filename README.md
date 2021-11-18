# C# Method Nedir?

## Merhaba 👋

Bugün ufak bir döküman olarak Nesne Yönelimli Programlama'nın temel konularından biri olan Method'ların ne olduğunu ve nasıl kullanacağımızı anlatıyorum.

## Method Nedir?

C#’ta açtığımız **Classlar/Sınıflar** içerisinde yazılan kod blokları gruplandırmamızı sağlayan yapılardır. 
Methodlar sınıfların **eylemlerini/davranışlarını** yönetmemizi sağlayan yapılardır.

### Avantajları

Methodlar aynı kod bloklarını tekrar tekrar yazmamızı engeller ve programlarımıza esneklik kazandırır.
Böylece kod karmaşasından kurtulurken aynı anda programımızın daha **stabil ve hızlı** çalışmasını sağlar.
Ayrıyetten projelerimizde hata kontrolü basit bir şekilde yapılır.

## Method Oluşturma

Class içinde method oluşturmak için bize **erişim seviyesi, dönecek veri tipi, method adı,parametreler** ve bu method için bir **niteliyici** gerekiyor.
Hemen kısaca bu gereken şeylerin ne olduğunun tanımını yapayım.

### Erişim Seviyeleri

#### Public
Public seviyesindeki methoda proje dışından ve proje içerisindeki dosyalardan erişilebilir.

#### Internal
Internal seviyesindeki methoda sadece proje içerisindeki dosyalardan erişilebilir.

#### Private
Public seviyesinin tam tersine tanımlanan class dışındaki **hiçbir şey** bu methoda ulaşamaz.

#### Protected
Public ile Private seviyelerinin arasındadır, clas içerisinde protected olarak işaretlenen eleman sadece o class içinden veya o classtan kalıtım alan sınıflar
içerisinden erişilebilir olmaktadır. O classın instance'ı için private, o classtan türeyen sınıfların ve o class içinde ise public özellik göstermektedir.

#### Void
Geriye parametre döndürmeyecek olan methodlar Void olarak tanımlanır.
Void kullanıldığı zaman return kullanılamaz ve eğer giriş parametresi yoksa parantez içi boş bırakılır.

### Dönecek Veri Tipleri

Methodun çalışması sonucu gönderilecek veri tipini belirler.
Bunlar int,string gibi önceden tanımladığımız veri tipleri veya kendi yazdığımız bir veri tipide olabilir. 

### Niteliyiciler

Opsiyonel bir seçenektir yani kullanmak zorunda değilsiniz. İleri seviye programlama olan OOP'de **static, abstract, virtual** kelimelerinden birini temsil eder.
Method içerisinde genelde **static** kullanılır.

### Parametreler

Bazı methodlar dışarıdan değişken almak zorundadır, bu değişkenlere parametre deriz.

#### Params

Methodlarda değişken tanımlandığında sadece bir adet parametre alabilirsiniz fakat parantezin içerisine **params** ifadesini yazarsanız tanımladığınız değişken
dizi değişkeni olarak tanımlanır böylecene birden fazla parametre alabilirsiniz.

```C#
public int YasHesaplama(params int[] x) { } 
```

#### Overload

Aynı methodun birden fazla versiyonu varsa bu method **Overload** olur. Mesela yaş hesaplama methodunu hem string ile hem int ile ayrı ayrı olarak yaparsak bu method
Overload olacaktır.

```C#
string Toplama(){}   
int Toplama(int sayi) {}
```

### Method Imzası

Methodu çağırırken kullanacağımız addır. Mümkün olduğunca method'u anımsatacak isimler verilir.

## Method Yazmak Ve Kullanmak

### Parametreli Method

Konsol projesi açıyoruz ve Program.cs'te anlatımımı yapacağım.proje içerisinde Methodlar.cs adında class oluşturdum.
Methodlar.cs 'e girince

```C#
public int Toplama  (int sayi1, int sayi2)
        {
            int Sonuc = sayi1 + sayi2;
            return Sonuc;
        }
```

Toplama adında bir method yaptım,  **sayi1** ve **sayi2** olarak  2 tane **int parametre** alacak.
Sonra sonuc adında bir değişken oluşturdum bu değişken  sayi1 ve sayi2 'nin toplamını **return Sonuc;** kodu sayesinde verecek.
Şimdi Program.cs'e geldim ve
> Static Void Main arasına

```C#
 Console.WriteLine("1. Sayıyı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            
            int sayi2 = int.Parse(Console.ReadLine());

            methodlar sanalisim = new methodlar();
            Console.WriteLine(sanalisim.Toplama(sayi1, sayi2));
            Console.ReadKey();
```
yazdım.

Konsola girilen her değer **string** olarak alınır, bizim alacağımız değişkenler **integer** olduğu için bunu string'ten integer'a dönüştürmemiz lazım.
Parse sayesinde string'ten integer'a değiştirdik. Sonra classımızı türettik böylecene sanal isim ile Toplama methodunu kullanabileceğiz.
En sonda toplama işlemini yazdırmak için console.writeline arasına sanalisim.Toplama(sayi1,sayi2) yazdım böylecene gönderdiğimiz değişkenler alınacak
ve işlem yapılıp döndürülecek.

### Parametresiz Method 

Bunu direk **Program.cs**'e yazdım.

```C#
    public static void Merhaba() {
         Console.WriteLine("Merhaba");
      }

      static void Main(string[] args)
      {
         Merhaba();
      }


```
NOT : Dökümanları kendimi geliştirmek için hazırlıyorum. Kesinlikle eğitim amaçlı değildir.

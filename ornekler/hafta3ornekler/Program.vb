Imports System

Module Program
    Sub Main(args As String())

        ' '###### Degiskenler
        ' Dim yas As Integer = 20
        ' Dim agirlik As Double = 70.5
        ' Dim isim As String = "Ahmet"
        ' Dim aktifMi As Boolean = True
        
        ' console.WriteLine(yas)
        ' Console.WriteLine(agirlik)
        ' Console.WriteLine(isim)
        ' Console.WriteLine(aktifMi)

        ' '###### Aritmetik operatorler
        ' Dim sonuc As Integer 
        ' Dim sayi1 As Integer = 5
        ' Dim sayi2 As Integer = 3

        ' sonuc = (sayi1 + sayi2) * (2 + 3)
        ' Console.WriteLine(sonuc)

        ' sonuc = sayi1 / sayi2
        ' Console.WriteLine(sonuc)

        ' sonuc = sayi1 Mod sayi2
        ' Console.WriteLine(sonuc)

        ' sonuc = sayi1 ^ sayi2
        ' Console.WriteLine(sonuc)

        ' '##### mantiksal operatorler
        ' Dim sonuc As Boolean
        ' Dim sayi1 As Integer
        ' Dim sayi2 As Integer
        
        ' sayi1 = 5
        ' sayi2 = 6
        ' sonuc = sayi1 >= sayi2
        ' Console.WriteLine(sonuc)

        '## mantiksal operatorler
        ' L degeri 100 ile 200 arasinda oldugunda veya M degeri 50 den buyuk oldugunda
        ' W degeri 100den kucuk oldugunda
        ' run degeri True olacak
        ' 
        
        ' Dim sonuc As Boolean
        ' Dim run As Boolean
        ' Dim L As Integer
        ' Dim M As Integer
        ' Dim W As Integer
        ' L = 150
        ' M = 40
        ' W = 100

        ' sonuc = ((L >= 100) And (L <= 200)) Or (M > 50)
        ' run = sonuc And (W < 100)
        ' Dim sonuc2 As Boolean
        ' Console.WriteLine(run)
        ' sonuc2 = Not run
        ' Console.WriteLine(sonuc2)

        ' ''' Metin birlestirme
        ' Dim adSoyad As String
        ' Dim isim As String = "Yasin"
        ' Dim soyIsim As String = "Kurt"
        ' Dim space As String = " "
        ' Dim extension As String = ".txt"

        ' adSoyad = isim + space + soyIsim + extension

        ' Console.WriteLine(adSoyad)

        ' ' sayac degiskenini olustur
        ' Dim sayac As Integer = 0
        ' ' sayac'i ekrana yaz
        ' ' A detayini konumlandir

        ' ' Sol kenardaki holleri konumlandir

        ' Console.WriteLine(sayac)
        ' sayac = sayac + 1
        ' Console.WriteLine(sayac)

        '''''' Yorum satirlari
        ' Tek satir yorum, bu satir derlenmez, calistirilmaz
        ' Yorum satirlari kodun anlasilmasi icin kullanilir
        
        ' Coklu yorum satiri eklemek icin ozel bir yontem bulunmuyor
        ' ikinci satiri da ayni sekilde ekliyoruz

        '''' If
        ' Dim yas As Integer = 15
        ' Dim limit As Integer = 18
        ' Dim resitMi As Boolean

        ' resitMi = (yas >= limit)

        ' ' If (yas >= limit) Then
        ' '     Console.WriteLine("Resitsiniz")
        ' ' Else
        ' '     Console.WriteLine("Resit degilsiniz")
        ' ' End If
        ' ' If resitMi Then
        ' '     Console.WriteLine("Resitsiniz")
        ' ' Else
        ' '     Console.WriteLine("Resit degilsiniz")
        ' ' End If

        ' Dim ehliyetimVarMi As Boolean = True

        ' If resitMi Then
        '     If ehliyetimVarMi Then
        '         Console.WriteLine("Arac kullanabilirsiniz")
        '     Else
        '         Console.WriteLine("Arac kullanamazsiniz")
        '     End If
        ' Else
        '     Console.WriteLine("Arac kullanamazsiniz")
            
        ' End If

        ' If resitMi And ehliyetimVarMi Then
        '     Console.WriteLine("Arac kullanabilirsiniz")
        ' Else
        '     Console.WriteLine("Arac kullanamazsiniz")
        ' End If

        '''''''''''''''''''''''''''''''''''''''''''
        ' Dim sicaklik As Integer = 0
        ' Dim cokSicakLimiti As Integer = 30
        ' Dim ilikLimiti As Integer = 20
        ' Dim sogukLimiti As Integer = 10

        ' If (sicaklik >= 30) Then
        '     Console.WriteLine("Cok sicak")
        ' ElseIf (sicaklik >= ilikLimiti) Then
        '     Console.WriteLine("Ilik")
        ' ElseIf (sicaklik >= sogukLimiti) Then
        '     Console.WriteLine("Soguk")
        ' Else
        '     Console.WriteLine("Donacaksin")
        ' End If

        ' '''''''''''''''''''''''''''''''''''''''''''
        ' ' ● Farklı 2 sayıyı karşılaştırıp sonucun yazdırılması
        ' ' ○ 2 sayı değişkeni tanımla ve istediğin değerleri ata
        ' ' ○ Kontrol 1: 1. sayı büyük
        ' ' ○ Kontrol 2: 2. sayı büyük
        ' ' ○ Kontrol 3: Sayılar eşit
        ' Dim x As Integer = 7
        ' Dim y As Integer = 6
        ' Dim outputText As String

        ' ' iki yontemi ayni anda aktif edersem ekranda ayni ciktiyi 2 kez gorurum
        ' ' yontem1 dogrudan if blogu icinde ekrana yazdiriyor
        ' ' yontem2 ise if blogu icinde outputText degiskenine atama yapiyor, sonra
        ' ' sonucu if blogunun disina ciktiktan sonra ekrana yazdiriyor
        ' If (x > y) Then
        '     ' Console.WriteLine("x buyuk") ' yontem1
        '     outputText = "x buyuk" ' yontem2
        ' ElseIf (y > x) Then
        '     ' Console.WriteLine("y buyuk") ' yontem1
        '     outputText = "y buyuk" ' yontem2
        ' Else ' ElseIf (x = y) Then olarak da yazabilirdim ama gerek yok, cunku sadece 3 durum var
        '     ' Console.WriteLine("sayilar esit") ' yontem1
        '     outputText = "sayilar esit" ' yontem2
        ' End If
        ' Console.WriteLine(outputText) ' yontem2

        ' '''''''''''''''''''''''''''''''''''''''''''
        ' ' 3 sınav notunun ortalamasını alıp geçer not ile karşılaştırarak başarı durumunu yazdır
        ' ' ○ 3 sınav notu değişkeni tanımla ve rasgele değerler ata
        ' ' ○ Geçer not değişkenini tanımla ve rasgele değer ata
        ' ' ○ Ortalamayı geçer not ile karşılaştırarak “Başarılı/Başarısız” bilgisini ekrana yazdır
        ' Dim not1, not2, not3, gecerNot As Integer
        ' Dim ortalama As Double

        ' not1 = 45
        ' not2 = 60
        ' not3 = 90
        ' gecerNot = 65

        ' ortalama = (not1 + not2 + not3) / 3

        ' ' Ortalama degerini gormek ve sonucun dogrulugunu onaylamak amacli ortalamayi
        ' ' ekrana yazdiriyorum
        ' Console.WriteLine("Ortalama: ")
        ' Console.WriteLine(ortalama)

        ' If (ortalama >= gecerNot) Then
        '     Console.WriteLine("Basarili")
        ' Else
        '     Console.WriteLine("Basarisiz")
        ' End If

        ' '''''''''''''''''''''''''''''''''''''''''''
        ' ' Bir sayının pozitif, negatif veya sıfır olup olmadığının kontrol edilmesi
        ' Dim birSayi As Integer = -1

        ' If birSayi > 0 Then
        '     Console.WriteLine("Pozitif sayi girdiniz")
        ' ElseIf (birSayi < 0) Then
        '     Console.WriteLine("Negatif sayi girdiniz")
        ' Else
        '     Console.WriteLine("Sifir girdiniz")
        ' End If

        ' '''''''''''''''''''''''''''''''''''''''''''
        ' ' Kullanıcı yaşına göre bilet indirimini hesaplayıp bilet fiyatının yazdırılması
        ' ' ○ Bilet fiyatı: 100
        ' ' ○ Kullanıcı yaşı: herhangi bir değer
        ' ' ○ yaş 12’den küçük ise %70 indirim, yaş 65’ten büyük ise %50 indirim, değilse normal fiyat
        ' ' ■ İndirimli fiyatı hesaplamak için normal fiyatı indirim oranı ile çarpma şeklinde kodlayınız
        ' Dim biletFiyati As Integer = 100
        ' Dim yas As Integer = 10
        ' Dim indirimliOran As Double = 1

        ' If yas < 12 Then
        '     indirimliOran = 0.3
        ' ElseIf yas > 65 Then
        '     indirimliOran = 0.5
        ' End If

        ' Console.WriteLine("Bilet fiyati: ")
        ' Console.WriteLine(biletFiyati * indirimliOran)

        ' '''''''''''''''''''''''''''''''''''''''''''
        ' ' Sayının tek/çift kontrolü
        ' ' ○ 2’ye bölümü 0 olan sayılar çift sayıdır. Kontrol için Mod kullanın
        ' ' Dim odevNo As Integer
        ' ' odevNo = Console.ReadLine()
        ' Dim sayi As Integer = 5

        ' If (sayi Mod 2) = 0 Then
        '     Console.WriteLine("Cift sayi")
        ' Else
        '     Console.WriteLine("Tek sayi")
        ' End If

        '''''''''''''''''''''''''''''''''''''''''''

    End Sub
End Module

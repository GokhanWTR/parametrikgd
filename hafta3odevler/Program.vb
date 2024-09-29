Imports System
 
Module Program
     Sub Main(args As String())

    
    'test1
    '     Dim sayi1 As Double = 5
    '     Dim sayi2 As Double = 4.5
    '     Dim islem As Double
    '     islem = (sayi1 * 8) / sayi2
 
    '     Console.WriteLine( islem )
 
    ' ' test2
 
    ' Dim saat As Integer = 22
    ' If  ( 6 <= saat ) And (saat<= 10) Then
    ' Console.WriteLine( "gunaydın" )
    ' ElseIf ( 12 < saat) And ( saat <= 16 ) Then
    ' Console.WriteLine( "iyigunler" )
    ' ElseIf ( 18 < saat) And ( saat <= 22 ) Then
    ' Console.WriteLine( "iyiaksamlar" )
    ' Else
    ' Console.WriteLine( "iyigeceler" )
 
    ' End If
 
    ' odev3
    ' Dim kilo As Integer = 85
    ' Dim Boy As Double  = 1.80
    ' Dim BMI As Double
    ' BMI = ( kilo / Boy ^ 2)
 
    '     If ( BMI < 18.5 ) Then    
    '     Console.WriteLine( "zayif" )
    '     ElseIf (18.5 <= BMI) And ( BMI <= 24.9)
    '      Console.WriteLine( "normalkılolu" )
    '     ElseIf (25 <= BMI) And ( BMI <= 29.9)
    '      Console.WriteLine( "fazlakılolu" )
    '      ElseIf (BMI>= 30 )
    '      Console.WriteLine( "obez" )
    '      End If
 
    'test4
 
     Dim sayi1 As Integer = 30
     Dim sayi2 As Integer = 20
     Dim sayi3 As Integer = 24
 
     If ( sayi1 > sayi2 ) And ( sayi1 > sayi3) Then
     Console.WriteLine( "sayi1" )
     ElseIf ( sayi2 > sayi1 ) And ( sayi2 > sayi3 ) Then
     Console.WriteLine( "sayi2" )
     ElseIf ( sayi3 > sayi1 ) And ( sayi3 > sayi2 ) Then
     Console.WriteLine( "sayi3" )
 
     End If
 
    'test5
 
     'Dim kenar1 As Integer = 5

        'Dim kenar2 As Integer = 5
        'Dim kenar3 As Integer = 6
        'Dim sonucu As String = ""
 
        'If ((kenar1 + kenar2) > kenar3) And ((kenar1 + kenar3) > kenar2) And ((kenar2 + kenar3) > kenar1) Then
           ' If (kenar1 = kenar2) And (kenar2 = kenar3) Then
           '     sonucu = "Eskenar Ucgen"
           ' ElseIf (kenar1 = kenar2) Or (kenar1 = kenar3) Or (kenar2 = kenar3) Then
           '     sonucu = "Ikizkenar Ucgen"
           ' Else
            '    sonucu = "Cesitkenar Ucgen"
            'End If
        'Else
                'sonucu = "Bu kenarlarla ucgen olusturulamaz"
       ' End If
   
              '  Console.WriteLine("sonucu: " + sonucu)
       
    End Sub
End Module
 


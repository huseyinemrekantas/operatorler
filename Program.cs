﻿using System;

using System;
namespace operatorler{
     class Program{
         static void Main(string[] args)
         {
            Console.WriteLine("*** Atama Ve islemli atama operatörler");
             // Atama Ve islemli atama
             int x = 3;
             int y =3;
             y = y+2;
            Console.WriteLine(y);
             y += 2;
            Console.WriteLine(y);
             y/=1;
            Console.WriteLine(y);
             x *=2;
             Console.WriteLine(x);


            Console.WriteLine("*** Mantiksal Operatörler");
              
             //Mantiksal Operatörler
             // &&, ||, !
             bool isSuccess = true;
             bool isCompleted = false;
             if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
             if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
             if (isSuccess && !isCompleted)
                 Console. WriteLine("Fine!");

            Console.WriteLine("*** ilişkisel operatörler");
            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*** Aritmetik operatörler");
            // /, *, +, - 

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;// bu aşamada sayının değeri atamadan sonra arttığı için değer görünmez.
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1;// burada artırılmış halini görebiliriz.
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
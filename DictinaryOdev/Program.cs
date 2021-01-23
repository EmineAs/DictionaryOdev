using System;

namespace DictionaryOdev
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Sandık sandık1 = new Sandık()
            {
                SandıkNo = 1001,
                MahalleAdi = "Ağa Köy Mahallesi",
                GorevliAdi = "Emine AŞÇI"
                               
            };

            Sandık sandık2 = new Sandık()
            {
                SandıkNo = 1002,
                MahalleAdi = "Bahçelievler Mahallesi",
                GorevliAdi = "Ayşe YILMAZ"

            };

            Sandık sandık3 = new Sandık()
            {
                SandıkNo = 1003,
                MahalleAdi = "Beyciler Mahallesi",
                GorevliAdi = "Fatma AYDIN"

            };
            
            MyDictionary<int,Sandık> myDictionary = new MyDictionary<int, Sandık>();

            myDictionary.Add(sandık1.SandıkNo, sandık1);
            myDictionary.Add(sandık2.SandıkNo, sandık2);
            myDictionary.Add(sandık3.SandıkNo, sandık3);

            for (int i = 0; i < myDictionary.tKey.Count; i++)
            {
                if (myDictionary.tKey[i] == myDictionary.tValue[i].SandıkNo) 
                {
                    Console.WriteLine(myDictionary.tValue[i].SandıkNo);
                    Console.WriteLine(myDictionary.tValue[i].MahalleAdi);
                    Console.WriteLine(myDictionary.tValue[i].GorevliAdi);
                    Console.WriteLine("*************************************");

                }
            }

        }

    }
}
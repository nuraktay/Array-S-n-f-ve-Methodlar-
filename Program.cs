namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort: Sıralı dizmek için.
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};
            Console.WriteLine("****** Sırasız Dizi *******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            Console.WriteLine("****** Sıralı Dizi *******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear:Verdiğin indekste dizinin o elemanına 0 atar.
            Console.WriteLine("****** Array Clear *******");

            Array.Clear(sayiDizisi, 2, 2);
            //2.indeksten itibaren 2 elemanı 0lar.
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Reverse:Verdiğimiz diziyi ortadan itibaren aynalıyormuş gibi çeviriyo, ilk/son olur.

            Console.WriteLine("****** Array Reverse *******");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //İndexOf:Verdiğimiz elemanın indexini verir.
            Console.WriteLine("****** Array İndexOf *******");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize: Yeniden Boyutlandırma.
            Console.WriteLine("****** Array Resize *******");    
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        }
    }
} 
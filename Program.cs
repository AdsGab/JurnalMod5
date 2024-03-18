
using System.ComponentModel;

public class Penjumlahan
{
    public static T jumlahTigaAngka<T>(T t1, T t2, T t3)
    {
        dynamic t4 = t1;
        dynamic t5 = t2;
        dynamic t6 = t3;
        return t4 + t5 + t6;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        double nim1 = 13;
        double nim2 = 02;
        double nim3 = 22;
        Console.WriteLine("Hasil Penjumlahan : " + Penjumlahan.jumlahTigaAngka(nim1, nim2, nim3));
    }
}
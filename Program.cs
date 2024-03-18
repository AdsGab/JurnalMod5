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
        SimpleDataBase<double> dataBase1 = new SimpleDataBase<double>();
        dataBase1.addNewData(nim1);
        dataBase1.addNewData(nim2);
        dataBase1.addNewData(nim3);
        dataBase1.printAllData();
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void addNewData(T t1)
    {
        storedData.Add(t1);
        inputDates.Add(DateTime.Now);
    }
    public void printAllData()
    {
        int i;
        for (i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
        }
    }

}


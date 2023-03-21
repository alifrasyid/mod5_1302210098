
﻿public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T satu, T dua, T tiga)
    {
        dynamic satu1 = satu;
        dynamic dua2 = dua;
        dynamic tiga3 = tiga;

        Console.WriteLine("Jumlah = " + (satu1 + dua2 + tiga3));
    }
}

﻿public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAlldata()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();
        int input1 = 13;
        int input2 = 02;
        int input3 = 21;
        jumlah.JumlahTigaAngka(input1, input2, input3);

        string[] arr = { "13", "02", "21" };
        SimpleDataBase<string> SDB = new SimpleDataBase<string>();
        for(int x = 0; x < arr.Length; x++)
        {
            SDB.AddNewData(arr[x]);
        }
        SDB.PrintAlldata();
    }
}

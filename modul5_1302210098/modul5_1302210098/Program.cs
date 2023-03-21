public class SimpleDataBase<T>
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
        string[] arr = { "13", "02", "21" };
        SimpleDataBase<string> SDB = new SimpleDataBase<string>();
        for(int x = 0; x < arr.Length; x++)
        {
            SDB.AddNewData(arr[x]);
        }
        SDB.PrintAlldata();
    }
}
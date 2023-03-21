public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T satu, T dua, T tiga)
    {
        dynamic satu1 = satu;
        dynamic dua2 = dua;
        dynamic tiga3 = tiga;

        Console.WriteLine("Jumlah = " + (satu1 + dua2 + tiga3));
    }
}

class main
{
    static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();
        int input1 = 13;
        int input2 = 02;
        int input3 = 21;
        jumlah.JumlahTigaAngka(input1, input2, input3);
    }
}

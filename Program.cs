public enum Produk
{
    Laptop,
    Smartphone,
    Tablet,
    Headset,
    Keyboard,
    Mouse,
    Printer,
    Monitor,
    Smartwatch,
    Kamera

}

public class Program()
{
    public static void Main(string[] args)
    {
        KodeProduk kd = new KodeProduk();
        Produk produk = Produk.Laptop;

        Console.WriteLine(kd.kodeProduk(produk));
    }
}

public class KodeProduk()
{
    public string kodeProduk(Produk produk)
    {
        string[] listKode = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

        return listKode[(int)produk];
    }
}
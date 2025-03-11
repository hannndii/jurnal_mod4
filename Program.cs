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

public enum stateLaptop
{
    Quiet,
    Balanced,
    Perfomance,
    Turbo
}

public enum triggerLaptop
{
    Mode_Down,
    Mode_Up,
    Turbo_Shortcut

}

public class Program()
{
    public static void Main(string[] args)
    {
        KodeProduk kd = new KodeProduk();
        Produk produk = Produk.Laptop;

        Console.WriteLine(kd.kodeProduk(produk));

        FanLaptop fan = new FanLaptop();
        stateLaptop newState = fan.TriggerLaptop(triggerLaptop.Mode_Up, stateLaptop.Quiet);
        fan.GetState(newState);
        stateLaptop newState1 = fan.TriggerLaptop(triggerLaptop.Turbo_Shortcut, stateLaptop.Quiet);
        fan.GetState(newState1);
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

public class FanLaptop()
{ 

    public stateLaptop TriggerLaptop(triggerLaptop trigger, stateLaptop currentState)
    {
        switch (trigger)
        {
            case triggerLaptop.Mode_Up:
                if(currentState == stateLaptop.Quiet)
                {
                    currentState = stateLaptop.Balanced;
                    return currentState;
                }
                else if (currentState == stateLaptop.Balanced)
                {
                    currentState = stateLaptop.Perfomance;
                    return currentState;
                }
                else if (currentState == stateLaptop.Perfomance)
                {
                    currentState = stateLaptop.Turbo;
                    return currentState;
                }
                break;
            case triggerLaptop.Turbo_Shortcut:
                if(currentState == stateLaptop.Quiet)
                {
                     currentState = stateLaptop.Turbo;
                    return currentState;
                }
                else if (currentState == stateLaptop.Turbo)
                {
                     currentState = stateLaptop.Quiet;
                    return currentState;
                }
                break;      
            case triggerLaptop.Mode_Down:
                if (currentState == stateLaptop.Turbo)
                {
                     currentState = stateLaptop.Perfomance;
                    return currentState;
                }
                else if (currentState == stateLaptop.Perfomance)
                {
                     currentState = stateLaptop.Balanced;
                    return currentState;
                }
                else if (currentState == stateLaptop.Balanced)
                {
                     currentState = stateLaptop.Quiet;
                    return currentState;
                }
                break;

        }
        return currentState;
    }

    public void GetState(stateLaptop currentState)
    {
        if (currentState == stateLaptop.Quiet)
        {
            Console.WriteLine($"“Fan Quiet berubah menjadi {currentState}");
        }
        else if (currentState == stateLaptop.Balanced)
        {
            Console.WriteLine($"“Fan Quiet berubah menjadi {currentState}");
        }
        else if (currentState == stateLaptop.Perfomance)
        {
            Console.WriteLine($"“Fan Quiet berubah menjadi {currentState}");
        }
        else if (currentState == stateLaptop.Turbo)
        {
            Console.WriteLine($"“Fan Quiet berubah menjadi {currentState}");
        }
    }
}
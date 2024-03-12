// See https://aka.ms/new-console-template for more information
using static KodePos;

public class KodePos
{
    public enum Kelurahan
    {
        BATUNUNGGAL = 40266,
        KUJANGSARI = 40287,
        MENGGGER = 40267,
        WATES = 40256,
        CIJAURA = 40287,
        JATISARI = 40286,
        MARGASARI = 40286,
        SEKEJATI = 40286,
        KEBONWARU = 40272,
        MALEER = 40274,
        SAMOJA = 40273
    }
    public static int GetKodePos(Kelurahan kelurahan)
    {
        return (int)kelurahan;
    }
    //public static void Main(string[] args)
    //{
    //Console.WriteLine("Kode Pos untuk Batununggal: " + GetKodePos(Kelurahan.BATUNUNGGAL));
    //Console.WriteLine("Kode Pos untuk Kujangsari: " + GetKodePos(Kelurahan.KUJANGSARI));
    //}
}
public class DoorMachine
{
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    private DoorState currentState;

    public DoorMachine()
    {
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (currentState == DoorState.Terkunci)
        {
            currentState = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void KunciPintu()
    {
        if (currentState == DoorState.Terbuka)
        {
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        DoorMachine doorMachine = new DoorMachine();

        doorMachine.BukaPintu();

        doorMachine.KunciPintu();
    }
}

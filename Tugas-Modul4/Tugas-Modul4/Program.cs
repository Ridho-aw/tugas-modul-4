using System;
public class KodeBuah
{
    private static string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
    enum Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
    }
    public static void Main()
    {
        int Kode = 0;
        string gKodeBuah;
        foreach (Buah buah in Enum.GetValues(typeof(Buah)))
        {
            Console.WriteLine($"{buah.ToString()} {kodeBuah[Kode]} ");
            Kode++;
        }
        Console.Write("Masukan Buah : ");
        String ibuah = Console.ReadLine();
        Kode = 0;
        foreach (Buah buah in Enum.GetValues(typeof(Buah)))
        {
            if (ibuah.Equals(buah.ToString()))
            {
                gKodeBuah = getKodeBuah(Kode);
                Console.WriteLine($"Buah {ibuah} Kode Buah {gKodeBuah}");
                break;
            }
            else
            {
                Kode++;
            }
        }
    }

    private static string getKodeBuah(int kode)
    {
        return kodeBuah[kode];
    }
}
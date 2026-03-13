using System;
public class PosisiKarakterGame
{
    enum PosisiKarakter
    {
        Terbang, Berdiri, Jongkok, Tengkurap, exit
    }
    public static void Main()
    {
        KarakterTransition();
    }
    public static void Print(int print)
    {
        if (print == 1)
        {
            Console.WriteLine("tombol arah bawah ditekan");
        }
        else if (print == 2)
        {
            Console.WriteLine("tombol arah atas ditekan");
        }
    }

    public static void KarakterTransition()
    {
        PosisiKarakter state = PosisiKarakter.Terbang;
        string[] Event = { "S", "W", "X"};
        while (state != PosisiKarakter.exit)
        {
            Console.WriteLine($"Posisi Karakter {state}");
            Console.WriteLine("");
            Console.Write("event : ");

            string command = Console.ReadLine();
            Console.WriteLine("");

            switch (state)
            {
                case PosisiKarakter.Terbang:
                    if (command == Event[0])
                    {
                        Print(1);
                        state = PosisiKarakter.Berdiri;
                    }
                    else if (command == Event[2])
                    {
                        state = PosisiKarakter.Jongkok;
                    }
                    else
                    {
                        state = PosisiKarakter.Terbang;
                    }
                    break;
                case PosisiKarakter.Berdiri:
                    if (command == Event[0])
                    {
                        Print(1);
                        state = PosisiKarakter.Jongkok;
                    }
                    else if (command == Event[1])
                    {
                        Print(2);
                        state = PosisiKarakter.Terbang;
                    }
                    else
                    {
                        state = PosisiKarakter.Berdiri;
                    }
                    break;
                case PosisiKarakter.Jongkok:
                    if (command == Event[0])
                    {
                        Print(1);
                        state = PosisiKarakter.Tengkurap;
                    }
                    else if (command == Event[1])
                    {
                        Print(2);
                        state = PosisiKarakter.Berdiri;
                    }
                    else
                    {
                        state = PosisiKarakter.Jongkok;
                    }
                    break;
                case PosisiKarakter.Tengkurap:
                    if (command == Event[0])
                    {
                        state = PosisiKarakter.exit;
                    }
                    else if (command == Event[1])
                    {
                        Print(2);
                        state = PosisiKarakter.Jongkok;
                    }
                    else
                    {
                        state = PosisiKarakter.Tengkurap;
                    }
                    break;
            }
        }
    }
}
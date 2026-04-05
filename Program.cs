using TP_MOD6_103022400093;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Lagu Santai");

        // test normal
        lagu1.IncreasePlayCount(5);

        // test overflow (loop biar cepat)
        for (int i = 0; i < 100; i++)
        {
            lagu1.IncreasePlayCount(int.MaxValue);
        }

        lagu1.PrintTrackDetails();
    }
}

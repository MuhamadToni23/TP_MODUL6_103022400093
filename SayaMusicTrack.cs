using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD6_103022400093
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;
        private static Random rand = new Random();
        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Title tidak boleh null");
            Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter");

            this.title = title;
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Count terlalu besar");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow!");
            }
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
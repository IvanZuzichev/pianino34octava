using System;

namespace pianinopract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Octava(); 
        }
        static void Octava()
        {
            Console.WriteLine("Пианино с третьей и четвертой октавой");
            Console.WriteLine("Чтобы перключить актавы нажмите 'z' и затем 'F3' или 'F4'");
            Console.WriteLine("Выберите актаву:");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            List<int[]> tabl = new List<int[]>
            { new int[] {130,138,146,155,164,174,185,196,207,220,233,246},
                new int[] {261,277,293,311,329,349,370,392,415,440,466,493}
            };
            if (Clavisha.Key == ConsoleKey.F3)
            {
                Octava3(tabl[0]);
            }
            if (Clavisha.Key == ConsoleKey.F4)
            {
                Octava4(tabl[1]);
            }
        }
        static void Octava3(int[] sound)
        {
            Console.WriteLine("Третья октава.");
            Console.WriteLine("Для переключения октав нажмите 'Z'");
            for (ConsoleKeyInfo oct = Console.ReadKey(); oct.Key != ConsoleKey.Z;)
            {
                if (oct.Key == ConsoleKey.A)
                {
                    Console.Beep(sound[0], 400);
                }
                if (oct.Key == ConsoleKey.Q)
                {
                    Console.Beep(sound[1], 400);
                }
                if (oct.Key == ConsoleKey.S)
                {
                    Console.Beep(sound[2], 400);
                }
                if (oct.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[3], 400);
                }
                if (oct.Key == ConsoleKey.E)
                {
                    Console.Beep(sound[4], 400);
                }
                if (oct.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[5], 400);
                }
                if (oct.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[6], 400);
                }
                if (oct.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[7], 400);
                }
                if (oct.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[8], 400);
                }
                if (oct.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[9], 400);
                }
                if (oct.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[10], 400);
                }
                if (oct.Key == ConsoleKey.U)
                {
                    Console.Beep(sound[11], 400);
                }
                oct = Console.ReadKey();
            }
            Octava();
        }
        static void Octava4(int[] sound)
        {
            Console.WriteLine("Четвертая октава.");
            Console.WriteLine("Для переключения октав нажмите 'Z'");
            for (ConsoleKeyInfo oct = Console.ReadKey(); oct.Key != ConsoleKey.Z;)
            {
                if (oct.Key == ConsoleKey.A)
                {
                    Console.Beep(sound[0], 400);
                }
                if (oct.Key == ConsoleKey.Q)
                {
                    Console.Beep(sound[1], 400);
                }
                if (oct.Key == ConsoleKey.S)
                {
                    Console.Beep(sound[2], 400);
                }
                if (oct.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[3], 400);
                }
                if (oct.Key == ConsoleKey.E)
                {
                    Console.Beep(sound[4], 400);
                }
                if (oct.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[5], 400);
                }
                if (oct.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[6], 400);
                }
                if (oct.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[7], 400);
                }
                if (oct.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[8], 400);
                }
                if (oct.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[9], 400);
                }
                if (oct.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[10], 400);
                }
                if (oct.Key == ConsoleKey.U)
                {
                    Console.Beep(sound[11], 400);
                }
                oct = Console.ReadKey();
            }
            Octava();
        }
    }
}
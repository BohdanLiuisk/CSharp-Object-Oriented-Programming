using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelentPupil();
            Pupil p3 = new ExcelentPupil();

            ClassRoom group = new ClassRoom(p1, p2, p3);

            group.Study();
            Console.WriteLine(new string('-', 30));
            group.Read();
            Console.WriteLine(new string('-', 30));
            group.Write();
            Console.WriteLine(new string('-', 30));
            group.Relax();

            Console.ReadKey();
        }
    }
}

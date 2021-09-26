using System;

namespace ArrayColetion
{
    class Program
    {
        static void Main(string[] args)
        {
               string[] alunosams= new string[5]{
               
               "Dani",
               "Maju",
               "Bruno",
               "Ramon",
               "Sofi"
            };
           Console.WriteLine(alunosams[2]);

            for (int i = 0; i < alunosams.Length ; i++)
            {
                Console.WriteLine($" Os alunos apresentados são: {alunosams[i]}");
            }
        }
    }
}

using System;
using System.Globalization;
using Week1_ex1;
using Week1_ex1._7;

namespace Week1_ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the exercise to test (1-7), or enter -1 to exit:");
                string choice = Console.ReadLine();

                if (choice == "-1")
                {
                    break; 
                }

                switch (choice)
                {
                    case "1":
                        TestEx1();
                        break;
                    case "2":
                        TestEx2();
                        break;
                    case "3":
                        TestEx3();
                        break;
                    case "4":
                        TestEx4();
                        break;
                    case "5":
                        TestEx5();
                        break;
                    case "6":
                        TestEx6();
                        break;
                    case "7":
                        TestEx7();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 7, or enter -1 to exit.");
                        break;
                }
            }
        }

        static void TestEx1()
        {
            ex1 ex1Instance = new ex1();
            Console.WriteLine("Suma a 2 numere fara + (5, 7): " + ex1Instance.SumWithoutPlus(5, 7));
            Console.WriteLine("Suma a 2 numere (5, 7): " + ex1Instance.Sum(5, 7));
            Console.WriteLine("Suma a 2 numere (5.3, 7.2): " + ex1Instance.Sum(5.3, 7.2));
            Console.WriteLine("Suma a 3 numere (5, 7, 9): " + ex1Instance.Sum(5, 7, 9));
            Console.WriteLine("Suma a 5 numere (5, 7, 9, 2, 4): " + ex1Instance.Sum(5, 7, 9, 2, 4));
        }

        static void TestEx2()
        {
            ex2 ex2Instance = new ex2();
            string input1 = "The quick brown Fox Jumps over the LaZy dog";
            Console.WriteLine($"Input1: {input1}");
            bool isPangram1 = ex2Instance.IsPangram(input1);
            Console.WriteLine(isPangram1 ? "Este propozitie holoalfabetica." : "Nu este propozitie holoalfabetica.");

            string input2 = "This is a bad example";
            Console.WriteLine($"Input2: {input2}");
            bool isPangram2 = ex2Instance.IsPangram(input2);
            Console.WriteLine(isPangram2 ? "Este propozitie holoalfabetica." : "Nu este propozitie holoalfabetica.");
        }

        static void TestEx3()
        {
            ex3 ex3Instance = new ex3();
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            ex3Instance.Swap(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");

            string a2 = "Variabila 1";
            string b2 = "Variabila 2";
            Console.WriteLine($"Before swap: a2 = {a2}, b2 = {b2}");
            ex3Instance.Swap(ref a2, ref b2);
            Console.WriteLine($"After swap: a2 = {a2}, b2 = {b2}");
        }

        static void TestEx4()
        {
            ex4 ex4Instance = new ex4();
            string input = "Aaanna Iissss Aattt SsscHHhhhhoooool";
            string output = ex4Instance.CountCharacters(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {output}");
        }

        static void TestEx5()
        {
            ex5 ex5Instance = new ex5();
            HashSet<int> generatedNumbers = ex5Instance.GenerateRandomNumbers(6, 1, 49);

            Console.WriteLine("Introdu 6 numere unice intre 1 si 49:");
            HashSet<int> userNumbers = new HashSet<int>();

            while (userNumbers.Count < 6)
            {
                if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 49 && userNumbers.Add(number))
                {
                    Console.WriteLine($"Numarul {number} a fost adaugat.");
                }
                else
                {
                    Console.WriteLine("Introducere invalida sau numar deja introdus. Incearca din nou.");
                }
            }

            bool isWinner = userNumbers.SetEquals(generatedNumbers);

            Console.WriteLine($"Numerele generate au fost: {string.Join(", ", generatedNumbers)}");
            Console.WriteLine(isWinner ? "Felicitari! Ai castigat!" : "Nu ai castigat. Mai incearca!");
        }

        static void TestEx6()
        {
            ex6 ex6Instance = new ex6();
            List<string> studentNames = new List<string>
            {
                "Alina", "Alex", "maria", "Ovidiu", "George", "alina", "Ana", "Ava", "Marian", "paul", "Elena", "Ioana"
            };
            Console.WriteLine("Lista de nume:");
            foreach (var name in studentNames)
            {
                Console.Write(name);
                Console.Write(" ");
            }

            Console.WriteLine("\n\na. Nume ce contin cel putin o data litera 'a':");
            var namesWithA = ex6Instance.GetNamesContainingLetter(studentNames, 'a');
            namesWithA.ForEach(Console.WriteLine);

            Console.WriteLine("\nb. Nume cu cel putin 5 litere:");
            var namesWithMinLength = ex6Instance.GetNamesWithMinLength(studentNames, 5);
            namesWithMinLength.ForEach(Console.WriteLine);

            Console.WriteLine("\nc. Numele cel mai scurt din lista:");
            List<string> shortestNames = ex6Instance.GetShortestNames(studentNames);
            foreach (var name in shortestNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nd. Numele cel mai lung din lista:");
            var longestName = ex6Instance.GetLongestNames(studentNames);
            foreach (var name in longestName)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\ne. Numarul de aparitii al numelui 'Alina':");
            var countAlina = ex6Instance.GetNameCount(studentNames, "Alina");
            Console.WriteLine(countAlina);
        }

        static void TestEx7()
        {
            Profesor prof1 = new Profesor("Popescu", "Ion", "1234567890123");
            Student stud1 = new Student("Ionescu", "Ana", "9876543210987");
            Student stud2 = new Student("Marinescu", "George", "1928374650912");

            Curs curs1 = new Curs("Programare Orientată pe Obiecte", 40, 2, prof1);

            prof1.CursuriPredate.Add(curs1);
            stud1.Cursuri.Add(curs1);
            stud2.Cursuri.Add(curs1);

            curs1.AdaugaStudent(stud1);
            curs1.AdaugaStudent(stud2);

            curs1.AtribuieNota(stud1, 9.5);
            curs1.AtribuieNota(stud2, 8.7);

            prof1.AfiseazaDetalii();
            stud1.AfiseazaDetalii();
            stud2.AfiseazaDetalii();
        }
    }
}

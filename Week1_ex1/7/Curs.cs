using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ex1._7;

class Curs
{
    public string Denumire { get; set; }
    public int Durata { get; set; } 
    public int NumarLocuri { get; set; }
    public Profesor ProfesorCurs { get; set; }
    public List<Student> Studenti { get; set; }
    public Dictionary<Student, double> Note { get; set; } 

    public Curs(string denumire, int durata, int numarLocuri, Profesor profesor)
    {
        Denumire = denumire;
        Durata = durata;
        NumarLocuri = numarLocuri;
        ProfesorCurs = profesor;
        Studenti = new List<Student>();
        Note = new Dictionary<Student, double>();
    }

    public void AdaugaStudent(Student student)
    {
        if (Studenti.Count < NumarLocuri)
        {
            Studenti.Add(student);
            Console.WriteLine($"Studentul {student.Nume} {student.Prenume} a fost adăugat la cursul {Denumire}.");
        }
        else
        {
            Console.WriteLine("Nu mai sunt locuri disponibile la acest curs.");
        }
    }

    public void AtribuieNota(Student student, double nota)
    {
        if (Studenti.Contains(student))
        {
            Note[student] = nota;
            Console.WriteLine($"Nota {nota} a fost atribuită studentului {student.Nume} {student.Prenume} la cursul {Denumire}.");
        }
        else
        {
            Console.WriteLine($"Studentul {student.Nume} {student.Prenume} nu este înscris la cursul {Denumire}.");
        }
    }
}

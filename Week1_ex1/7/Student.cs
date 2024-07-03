using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ex1._7;
class Student : Persoana
{
    public List<Curs> Cursuri { get; set; }

    public Student(string nume, string prenume, string cnp) : base(nume, prenume, cnp)
    {
        Cursuri = new List<Curs>();
    }

    public override void AfiseazaDetalii()
    {
        Console.WriteLine($"Student: {Nume} {Prenume}, CNP: {CNP}");
    }
}

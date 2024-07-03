using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ex1._7;
class Profesor : Persoana
{
    public List<Curs> CursuriPredate { get; set; }

    public Profesor(string nume, string prenume, string cnp) : base(nume, prenume, cnp)
    {
        CursuriPredate = new List<Curs>();
    }

    public override void AfiseazaDetalii()
    {
        Console.WriteLine($"Profesor: {Nume} {Prenume}, CNP: {CNP}");
    }
}

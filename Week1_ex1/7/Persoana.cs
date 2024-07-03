using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ex1._7;
abstract class Persoana : IPersoana
{
    private string cnp;

    public string Nume { get; set; }
    public string Prenume { get; set; }

    public string CNP
    {
        get { return cnp; }
        set
        {
            if (value.Length == 13)
            {
                cnp = value;
            }
            else
            {
                throw new ArgumentException("CNP-ul trebuie să aibă 13 caractere.");
            }
        }
    }

    public Persoana(string nume, string prenume, string cnp)
    {
        Nume = nume;
        Prenume = prenume;
        CNP = cnp;
    }

    public abstract void AfiseazaDetalii();
}
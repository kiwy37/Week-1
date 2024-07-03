using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_ex1._7;
interface IPersoana
{
    string Nume { get; set; }
    string Prenume { get; set; }
    string CNP { get; set; }

    void AfiseazaDetalii();
}

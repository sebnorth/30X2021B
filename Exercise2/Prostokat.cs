using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Prostokat : IComparable
    {
        private int szerokosc;
        private int wysokosc;

        public Prostokat(int v1, int v2)
        {
            this.szerokosc = v1;
            this.wysokosc = v2;
        }

        //int szerokosc;
        //int wysokosc;

        public int CompareTo(object obj) {

            if (obj == null) return 1;

            Prostokat innyProstokat = obj as Prostokat;
            if (innyProstokat != null)
            {

                /* jeśli pole prostokąta(daną instancję -> słówko this) jest większe niż pole innyProstokat zwróć 1
                 * jeśli pole prostokąta jest mniejsze niż pole innyProstokat zwróć -1
                 * heśli są równe to 0
                 */

                int pole = this.szerokosc * this.wysokosc;
                int poleInnegoProstokata = innyProstokat.szerokosc * innyProstokat.wysokosc;

                if (pole > poleInnegoProstokata)
                {
                    return 1;
                }

                if (pole < poleInnegoProstokata)
                {
                    return -1;
                }

                return 0;
            }
            else
                throw new ArgumentException("Object is not a Prostokat");


        
        }
    }
}

/**************************************************************************
 *                                                                        *
 *  File:        Meniu                                                    *
 *  Copyright:   (c) 2022,Petruca Marco-Alexandru                         *
 *  E-mail:      marco-alexandru.petruca@student.tuiasi.ro                *
 *  Description: Clasa Meniu                                              *
 *               Clasa utilizata pentru a crea un meniu si a pastra       *
 *               informatiile despre produse in acesta.                   *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// Clasa folosita pentru crearea unui meniu
    /// </summary>
    public class Meniu
    {

        private static Meniu _instantaMeniu;

        List<Produs> _produse;

        /// <summary>
        /// Constructorul clasei Meniu - initializarea cu lista de produse
        /// </summary>
        /// <param name="produse">Produsele din meniu</param>
        private Meniu(List<Produs> produse)
        {
            _produse = new List<Produs>();

            foreach (Produs produs in produse)
            {
                _produse.Add(produs);
            }
        }

        /// <summary>
        /// Metoda utilizata pentru a obtine instanta Singleton a meniului.
        /// </summary>
        /// <returns>Instanta Singleton a meniului</returns>
        public static Meniu InstantaMeniu(List<Produs> produse = null)
        {
            if (_instantaMeniu == null)
            {
                //punem totul intr-un try-catch ca sa nu primim eroare cand incercam sa returnam instanta meniului.
                try
                {
                    _instantaMeniu = new Meniu(produse);
                }
                catch
                {
                    //Console.WriteLine("Produse=null...");
                }
            }
            return _instantaMeniu;
        }

        /// <summary>
        /// Metoda utilizata pentru a afisa lista de produse din meniu
        /// </summary>
        /// <returns>Lista produselor din meniu</returns>
        public string AfisareMeniu()
        {
            string rezultat = "";

            foreach (Produs produs in _produse)
            {
                rezultat += produs.AfisareProdus() + "\n";
            }

            return rezultat;
        }

    }
}

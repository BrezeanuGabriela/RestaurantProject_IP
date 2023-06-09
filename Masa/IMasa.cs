/**************************************************************************
 *                                                                        *
 *  File:        IMasa                                                    *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@tuiasi.ro                              *
 *  Description: Clasa abstracta utilizata pentru a descrie operatiile de *
 *               baza de la o masa din restaurant.                        *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace Restaurant
{
    /// <summary>
    /// Clasa utilizata pentru abstractizarea unei mese din restaurant
    /// </summary>
    public abstract class IMasa
    {
        protected List<IComanda> _comenzi;
        public List<IComanda> Comenzi
        {
            get { return _comenzi; }
        }
        protected int index;
        protected static int _nrMese = 0;
        
        /// <summary>
        /// Metoda utilizata pentru adaugarea unei comenzi in lista comenzilor de la masa respectiva
        /// </summary>
        /// <param name="comanda">Comanda care va fi adaugata</param>
        public abstract void AddComanda(IComanda comanda);

        /// <summary>
        /// Metoda utilizata pentru returnarea unei comenzi
        /// </summary>
        /// <param name="index">Indexul comenzii din lista ce va fi returnata</param>
        /// <param name="comanda">Comanda returnata prin referinta</param>
        public abstract void GetComanda(int index, ref IComanda comanda);

        /// <summary>
        /// Metoda apelata pentru stergerea unei comenzi din lista celor de la masa
        /// </summary>
        /// <param name="comanda">Comanda care va fi stearsa</param>
        public abstract void StergeComanda(IComanda comanda);

        /// <summary>
        /// Metoda utilizata pentru a insuma costul tuturor comenzilor emisa la masa
        /// </summary>
        /// <returns>Suma totala incasata</returns>
        public abstract double TotalCostComenziMasa();
    }
}
/**************************************************************************
 *                                                                        *
 *  File:        IComanda                                                 *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@tuiasi.ro                              *
 *  Description: Clasa abstracta utilizata pentru a descrie operatiile    *
 *               de baza dintr-o comanda.                                 *
 *                                                                        *
 **************************************************************************/

using System;

namespace Restaurant
{
    /// <summary>
    /// Clasa abstracta ce va fi utilizata pentru 
    /// </summary>
    public abstract class IComanda
    {
        protected static int _nrComenzi = 0;

        /// <summary>
        /// Metoda abstracta folosita pentru a calcula costul total al comenzii
        /// </summary>
        /// <returns>Costul total</returns>
        public abstract double Facturare();

        /// <summary>
        /// Metoda care va fi apelata pentru afisarea detaliilor despre comanda
        /// </summary>
        /// <returns></returns>
        public abstract String AfiseazaComanda();

        /// <summary>
        /// Metoda utilizata pentru emiterea bonului
        /// </summary>
        /// <returns></returns>
        public abstract String TiparesteBon();

        public abstract String GetRezumatComanda();
    }
}


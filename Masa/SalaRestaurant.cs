/**************************************************************************
 *                                                                        *
 *  File:        SalaRestaurant                                           *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@tuiasi.ro                              *
 *  Description: Clasa utilizata pentru a simula o sala de restaurant     *
 *               care e alcatuita din mai multe mese si implementeaza     *
 *               operatiile necesare pentru manevrarea acesteia.          *
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
    /// Clasa Singleton pentru construirea unei sali de restaurant
    /// </summary>
    public sealed class SalaRestaurant
    {
        private static SalaRestaurant _instance;

        private List<IMasa> _listaMese;
        private int _indexMasaCurenta;

        public List<IMasa> ListaMese
        {
            get { return _listaMese; }
        }

        /// <summary>
        /// Constructorul clasei SalaRestaurant
        /// </summary>
        private SalaRestaurant()
        {
            _listaMese = new List<IMasa>();
            _indexMasaCurenta = 0;
        }

        /// <summary>
        /// Metoda care returneaza instanta clasei SalaRestaurant
        /// </summary>
        /// <returns>Instanta clasei SalaRestaurant</returns>
        public static SalaRestaurant Instance()
        {
            if( null == _instance)
            {
                _instance = new SalaRestaurant();
            }
            return _instance;
        }


        /// <summary>
        /// Metoda utilizata pentru adaugarea unei noi mese in lista meselor din cadrul restaurantului
        /// </summary>
        /// <param name="masa"></param>
        public void AddTable(IMasa masa)
        {
            _listaMese.Add(masa);
        }

        /// <summary>
        /// Metoda care returneaza o anumita masa din cele prezente in restaurant
        /// </summary>
        /// <param name="indexMasa"></param>
        /// <returns></returns>
        public IMasa GetCurrentTable(int indexMasa)
        {
            if (indexMasa < _listaMese.Count)
            {
                _indexMasaCurenta = indexMasa;
                return _listaMese[_indexMasaCurenta];
            }
            return null;
        }

        /// <summary>
        /// Metoda care returneaza o lista cu toate comenzile date pentru masa curenta
        /// </summary>
        /// <returns></returns>
        public List<IComanda> GetComenziMasaCurenta()
        {
            if (_indexMasaCurenta < _listaMese.Count)
            {
                return _listaMese[_indexMasaCurenta].Comenzi;
            }
            else
            {
                throw new Exception("Nu exista nicio masa inregistrata");
            }
        }
    }
}

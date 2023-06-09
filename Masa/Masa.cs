/**************************************************************************
 *                                                                        *
 *  File:        Masa                                                     *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@tuiasi.ro                              *
 *  Description: Clasa utilizata pentru construirea unei mese si          *
 *           implementeaza operatiile de baza de la o masa din restaurant.*
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    /// <summary>
    /// Clasa utilizata pentru crearea unei mese din restaurant
    /// </summary>
    public class Masa : IMasa
    {
        
        private int _index;

        public Masa()
        {
            _index = _nrMese;
            _nrMese++;
            _comenzi = new List<IComanda>();
        }

        ///<summary>
        ///Metoda care adauga comanda curenta la lista de comenzi de pe masa
        ///</summary>
        ///<param name="comanda">Comanda care a fost data la masa</param>
        public override void AddComanda(IComanda comanda)
        {
            _comenzi.Add(comanda);
        }

        /// <summary>
        /// Metoda utilizata pentru returnarea unei comenzi
        /// </summary>
        /// <param name="index">Indexul comenzii din lista ce va fi returnata</param>
        /// <param name="comanda">Comanda returnata prin referinta</param>
        public override void GetComanda(int index, ref IComanda comanda)
        {
            if (index < _comenzi.Count)
            {
                comanda = (IComanda)_comenzi[index];
            }
            else
            {
                throw new Exception("Index-ul comenzii este prea mare!");
            }
        }

        /// <summary>
        /// Metoda apelata pentru stergerea unei comenzi din lista celor de la masa
        /// </summary>
        /// <param name="comanda">Comanda care va fi stearsa</param>
        public override void StergeComanda(IComanda comanda)
        {
            if (_comenzi.Count>0 &&_comenzi.Contains(comanda))
            {
                _comenzi.Remove(comanda);
            }
            else
            {
                throw new Exception("Comanda nu exista!");
            }
        }

        /// <summary>
        /// Metoda utilizata pentru a insuma costul tuturor comenzilor emisa la masa
        /// </summary>
        /// <returns>Suma totala incasata</returns>
        public override double TotalCostComenziMasa()
        {
            double cost = 0.0;
            double indiceComanda = 1;
            foreach(IComanda comanda in _comenzi)
            {
                if (comanda.GetType() == typeof(Comanda))
                {
                    Comanda comandaAuxiliara = (Comanda)comanda;
                    if (comandaAuxiliara.Finalizata == false)
                    {
                        return -indiceComanda;
                    }
                }
                else if(comanda.GetType() == typeof(DeliveryComanda))
                {
                    DeliveryComanda comandaAuxiliara = (DeliveryComanda)comanda;
                    if (comandaAuxiliara.Finalizata == false)
                    {
                        return -indiceComanda;
                    }
                }
                cost += comanda.Facturare();
                indiceComanda++;
            }
            return cost;
        }

    }
}

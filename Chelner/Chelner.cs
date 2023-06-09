/**************************************************************************
 *                                                                        *
 *  File:        Chelner                                                  *
 *  Copyright:   (c) (c)2022, Dobos Raluca                                *
 *  E-mail:      raluca.dobos@student.tuiasi.ro                           *
 *  Description: Clasa utilizata pentru a crea un Chelner si a            *
 *               implementeaza operatiile specifice acesteia              *
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
    /// Clasa Singleton pentru construirea chelnerului restaurantului
    /// </summary>
    public sealed class Chelner
    {
        private static Chelner _instance;

        private Chelner()
        {

        }

        /// <summary>
        /// Metoda care returneaza instanta clasei Chelner
        /// </summary>
        /// <returns>Instanta clasei Chelner</returns>
        public static Chelner Instance()
        {
            if (_instance == null)
            {
                _instance = new Chelner();
            }
            return _instance;
        }

        /// <summary>
        /// Metoda prin care chelnerul preia comanda de la masa curenta 
        /// </summary>
        /// <param name="comanda"></param>
        /// <param name="indexMasa"></param>
        /// <exception cref="Exception"></exception>
        public void PreiaComanda(IComanda comanda, int indexMasa)
        {
            if (indexMasa < SalaRestaurant.Instance().ListaMese.Count)
            {
                IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
                if (masa != null)
                {
                    masa.AddComanda(comanda);
                }
                else
                {
                    throw new Exception("Nu exista vreo masa");
                }
            }
            else
            {
                throw new Exception("Indexul mesei este prea mare.");
            }
        }

        /// <summary>
        /// Metoda prin care chelnerul emite bonul pentru masa curenta, a comenzii selectate
        /// </summary>
        /// <param name="indexMasa">Id-ul mesei curente</param>
        /// <param name="indexComandaSelectata">Id-ul comenzii selectate pentru emitere</param>
        /// <returns></returns>
        public String EmiteBon(int indexMasa, int indexComandaSelectata)
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(indexMasa);
            if (masa != null)
            {
                IComanda comanda = null;
                try 
                { 
                    masa.GetComanda(indexComandaSelectata, ref comanda);
                    return comanda.TiparesteBon();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            return "";
        }

        /// <summary>
        /// Metoda pentru inchiderea restaurantului atunci cand toate comenzile au fost finalizate,
        /// nu mai exista comenzi curente 
        /// </summary>
        /// <returns>Costul total al comenzilor din sesiunea curenta de comenzi</returns>
        public double InchideCasa()
        {
            IMasa masa = SalaRestaurant.Instance().GetCurrentTable(0);
            return masa.TotalCostComenziMasa();
        }

    }
}

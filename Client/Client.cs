/**************************************************************************
 *                                                                        *
 *  File:        Client                                                   *
 *  Copyright:   (c) (c)2022, Dobos Raluca                                *
 *  E-mail:      raluca.dobos@student.tuiasi.ro                           *
 *  Description: Clasa utilizata pentru a crea un client si a efectua     *  
 *               operatiile specifice acesteia                            * 
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
    /// Clasa utilizata pentru construirea unui client
    /// </summary>
    public class Client
    {
        private int _idClient;
        private int _indexMasa;
        private List<Produs> _produsList = new List<Produs>();
        private String _observatii;
        private bool _delivery;
        private String _adresa;

        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }
        public int IndexMasa
        {
            get { return _indexMasa; }
            set { _indexMasa = value; }
        }

        public String Observatii
        {
            get { return _observatii; }
            set { _observatii = value; }
        }

        public List<Produs> ProdusList
        {
            get { return _produsList; }
        }

        public bool Delivery
        {
            get { return _delivery; }
            set { _delivery = value; }
        }

        public String Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }

        /// <summary>
        /// Constructorul clasei Client - initializarea membrilor 
        /// </summary>
        /// <param name="idClient">Id-ul aferent unui client</param>
        /// <param name="indexMasa">Id-ul mesei asociat clientului</param>
        public Client(int idClient, int indexMasa)
        {
            _idClient = idClient;
            _indexMasa = indexMasa;
            _delivery = false;
        }

        /// <summary>
        /// Metoda utilizata pentru adaugarea unui produs in lista de produse in vederea comenzii
        /// </summary>
        /// <param name="produs"> Produsul aferent </param>
        public void AdaugaProdus(Produs produs)
        {
            _produsList.Add(produs);
        }

        /// <summary>
        /// Metoda face legatura dintre client si chelner, inregistrarea comenzii 
        /// </summary>
        public void TrimiteComanda()
        {
            IComanda comanda;

            if (_delivery == false)
            {
                comanda = new Comanda(_idClient, _produsList, _observatii);
            }
            else
            {
                comanda = new DeliveryComanda(_idClient, _produsList, _observatii, _adresa);
            }
            try
            {
                Chelner.Instance().PreiaComanda(comanda, _indexMasa);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

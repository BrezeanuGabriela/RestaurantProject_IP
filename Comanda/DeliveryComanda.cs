/**************************************************************************
 *                                                                        *
 *  File:        DelveryComanda                                           *
 *  Copyright:   (c) 2022,Brezeau Gabriela                                *
 *  E-mail:      gabriela.brezeanu@student.tuiasi.ro                      *
 *  Description: Clasa DeliveryComanda                                    *
 *               Clasa utilizata pentru a crea o comanda si a efectua     *
 *               operatiile specifice acesteia cu livrare la domiciliu.   *
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
    /// Clasa utilizata pentru construirea unei comenzi cu livrare la domiciliu
    /// </summary>
    public class DeliveryComanda : IComanda
    {
        #region Fields
        protected int _idClient;
        protected int _idComanda;
        protected String _observatii;
        protected String _adresa;

        protected List<Produs> _produseComandate;
        protected double _costTotal;
        protected bool _finalizata;

        #region GetAndSet
        public String Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }
        public String Observatii
        {
            get { return _observatii; }
        }
        public bool Finalizata
        {
            get { return _finalizata; }
            set { _finalizata = value; }
        }
        public double CostTotal
        {
            get { return _costTotal; }
        }
        public int IdClient
        {
            get { return _idClient; }
        }
        #endregion

        #endregion

        /// <summary>
        /// Constructorul clasei DeliveryComanda
        /// </summary>
        /// <param name="idClient">Id-ul clientului care a emis comanda</param>
        /// <param name="produse">Lista de produse comandate</param>
        /// <param name="observatii">aobservatiile clientului</param>
        /// <param name="adresa">Adresa de livrare</param>
        public DeliveryComanda(int idClient, List<Produs> produse, String observatii, String adresa)
        {
            _idClient = idClient;

            _nrComenzi++;
            _idComanda = _nrComenzi;

            _produseComandate = produse;

            _observatii = observatii;
            _adresa = adresa;
            _costTotal = 0;

            _finalizata = false;
        }

        /// <summary>
        /// Metoda utilizata pentru a calcula costul total al comenzii
        /// </summary>
        /// <returns>Costul total</returns>
        public override double Facturare()
        {
            _costTotal = 0;
            double costAmbalaj = 1.0;
            foreach (Produs produs in _produseComandate)
            {
                _costTotal += produs.Pret + costAmbalaj;
            }

            return _costTotal;
        }

        /// <summary>
        /// Metoda care returneaza un sir de caractere cu toate detaliile comenzii
        /// </summary>
        /// <returns>Textul ce descrie comanda</returns>
        public override String AfiseazaComanda()
        {
            string comanda = "";

            //preluam id-ul comenzii si al clientului
            comanda += "Comanda cu id-ul " + this._idComanda.ToString() + " la clientul " + this._idClient.ToString() + System.Environment.NewLine;

            //adaugam produsele din comanda
            foreach (Produs produs in _produseComandate)
            {
                comanda += produs.Denumire + " - " + produs.Pret + " lei" + System.Environment.NewLine;
            }

            //calculam costul total
            Double cost = this.Facturare();
            comanda += System.Environment.NewLine + "Cost Total: " + cost.ToString() + " lei";
            comanda += System.Environment.NewLine + "Diferenta de bani o reprezinta ambalajele folosite pentru impachetare. ";

            //verificam statusul comenzii, daca are sau nu bonul emis
            string status = _finalizata ? "incheiata" : "neincheiata";
            comanda += System.Environment.NewLine + "Status comanda: " + status;

            comanda += System.Environment.NewLine + System.Environment.NewLine + "Adresa de livrare: " + _adresa;

            return comanda;
        }

        /// <summary>
        /// Metoda utilizata in interfata chelnerului pentru a putea identifica usor id-ul comenzii si al clientului
        /// </summary>
        /// <returns></returns>
        public override String GetRezumatComanda()
        {
            return "Comanda " + this._idComanda.ToString() + ", Clientul " + this._idClient.ToString();
        }

        /// <summary>
        /// Metoda apelata pentru tiparirea butonului cu toate detaliile comenzii
        /// </summary>
        /// <returns>Un sir de caractere ce reprezinta bonul comenzii</returns>
        public override String TiparesteBon()
        {
            //verificam sa nu aiba deja bonul emis
            if (Finalizata == false)
            {
                //marcam ca s-a emis bonul
                _finalizata = true;

                string bon = "";
                bon += "ID comanda: " + this._idComanda.ToString() + System.Environment.NewLine;
                bon += "Produse comandate: " + System.Environment.NewLine;

                //adaugam produsele comandate
                foreach (Produs produs in _produseComandate)
                {
                    bon += produs.Denumire + " - " + produs.Pret + " lei" + System.Environment.NewLine;
                }

                //adaugam costul total
                this.Facturare();
                bon += System.Environment.NewLine + "Cost Total: " + _costTotal.ToString() + " lei";
                bon += System.Environment.NewLine + "Diferenta de bani o reprezinta ambalajele folosite pentru impachetare. ";

                //daca sunt observatii, le adaugam
                if (_observatii != "")
                {
                    bon += System.Environment.NewLine + "Observatii: " +  _observatii + System.Environment.NewLine;
                }

                bon += System.Environment.NewLine + "Adresa de livrare: " + _adresa;

                //mesaj de multumire
                bon += System.Environment.NewLine + "Va multumim pentru ca ati mancat la noi si va mai asteptam!";

                return bon;
            }
            //deja s-a emis un buton pentru comanda, nu mai poate fi emis altul
            return "Comanda are deja bonul emis!";
        }
    
    }
}

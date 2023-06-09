/**************************************************************************
 *                                                                        *
 *  File:        Produs                                                   *
 *  Copyright:   (c) 2022,Petruca Marco-Alexandru                         *
 *  E-mail:      marco-alexandru.petruca@student.tuiasi.ro                *
 *  Description: Clasa Produs                                             *
 *               Clasa utilizata pentru a crea un produs, a pastra        *
 *               informatiile despre un produs si operatiile necesare     *
 *               acestuia                                                 *
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
    /// Clasa folosita pentru crearea unui produs din meniu
    /// </summary>
    public class Produs
    {
        private string _denumire;
        public String Denumire
        {
            get { return _denumire; }
            set { _denumire = value; }
        }

        private Double _pret;
        public Double Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }
        private List<String> _ingrediente;

        /// <summary>
        /// Constructorul clasei Produs - initializeaza membrilor acesteia
        /// </summary>
        /// <param name="denumire">Denumirea produsului</param>
        /// <param name="pret">Pretul produsului (in lei)</param>
        /// <param name="ingredinte">Lista de ingrediente aferenta produsului</param>
        public Produs(String denumire, Double pret, List<String> ingredinte)
        {
            _denumire = denumire;
            _pret = pret;
            _ingrediente = new List<string>();

            if (ingredinte != null)
            {
                foreach (String ingredient in ingredinte)
                {
                    _ingrediente.Add(ingredient);
                }
            }
        }


        /// <summary>
        /// Metoda utilizata pentru afisarea listei de ingrediente a unui produs
        /// </summary>
        /// <returns>Ingredientele unui produs</returns>
        private string AfisareIngrediente()
        {
            string rezultat = "";

            if(_ingrediente.Count <=0)
            {
                return rezultat;
            }

            for (int i = 0; i < _ingrediente.Count; i++)
            {
                rezultat += _ingrediente[i] + ", ";
            }

            return rezultat.Substring(0, rezultat.Length - 2);//trebuie sa eliminam de ultimul ", "
        }

        /// <summary>
        /// Metoda utilizata pentru a afisa toate detaliile unui produs
        /// </summary>
        /// <returns>Detaliile unui produs</returns>
        public string AfisareProdus()
        {
            return Denumire + "(" + AfisareIngrediente() + ")" + " -  " + Pret.ToString() + " lei" ;
        }
    }
}

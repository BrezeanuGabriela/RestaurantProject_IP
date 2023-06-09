/**************************************************************************
 *                                                                        *
 *  File:        ComandaTests                                             *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@student.tuiasi.ro                      *
 *  Description: Unit-test pentru clasa Comanda                           *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Tests
{
    [TestClass()]
    public class ComandaTests
    {
        private Comanda _comanda;

        [TestMethod()]
        public void ComandaTest()
        {
            _comanda = new Comanda(0, null, "");
            Assert.IsNotNull(_comanda);
        }

        [TestMethod()]
        public void FacturareTest()
        {
            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);
            Produs produs1 = new Produs("porc", 21.2, null);
            listaProduse.Add(produs1);

            IComanda comanda = new Comanda(0, listaProduse, "");

            double costTotal = comanda.Facturare();
            Assert.AreEqual(42.4, costTotal);
        }

        [TestMethod()]
        public void AfiseazaComandaTest()
        {
            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);
            Produs produs1 = new Produs("porc", 21.2, null);
            listaProduse.Add(produs1);

            IComanda comanda = new Comanda(0, listaProduse, "");

            String detaliiComanda = comanda.AfiseazaComanda();
            Assert.AreNotEqual("", detaliiComanda);
        }

        [TestMethod()]
        public void GetRezumatComandaTest()
        {
            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);
            Produs produs1 = new Produs("porc", 21.2, null);
            listaProduse.Add(produs1);

            Comanda comanda = new Comanda(0, listaProduse, "");

            String detaliiComanda = comanda.GetRezumatComanda();
            Assert.AreNotEqual("", detaliiComanda);
        }

        [TestMethod()]
        public void TiparesteBonTest()
        {
            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);
            Produs produs1 = new Produs("porc", 21.2, null);
            listaProduse.Add(produs1);

            IComanda comanda = new Comanda(0, listaProduse, "");

            String detaliiComanda = comanda.TiparesteBon();
            Assert.AreNotEqual("", detaliiComanda);
        }
    }
}
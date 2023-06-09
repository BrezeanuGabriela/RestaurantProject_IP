/**************************************************************************
 *                                                                        *
 *  File:        DeliveryComandaTests                                     *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@student.tuiasi.ro                      *
 *  Description: Unit-test pentru clasa DeliveryComanda                   *
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
    public class DeliveryComandaTests
    {
        private IComanda _comanda;

        [TestMethod()]
        public void DeliveryComandaTest()
        {
            _comanda = new DeliveryComanda(0, null, "", "");
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

            _comanda = new DeliveryComanda(0, listaProduse, "", "");

            double costTotal = _comanda.Facturare();
            Assert.AreEqual(44.4, costTotal);
        }

        [TestMethod()]
        public void AfiseazaComandaTest()
        {
            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);
            Produs produs1 = new Produs("porc", 21.2, null);
            listaProduse.Add(produs1);

            _comanda = new DeliveryComanda(0, listaProduse, "", "dacia");

            String detaliiComanda = _comanda.AfiseazaComanda();
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

            _comanda = new DeliveryComanda(0, listaProduse, "", "");

            String detaliiComanda = _comanda.GetRezumatComanda();
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

            _comanda = new DeliveryComanda(0, listaProduse, "", "");

            String detaliiComanda = _comanda.TiparesteBon();
            Assert.AreNotEqual("", detaliiComanda);
        }
    }
}
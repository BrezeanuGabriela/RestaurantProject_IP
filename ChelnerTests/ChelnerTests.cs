/**************************************************************************
 *                                                                        *
 *  File:        ChelnerTests                                             *
 *  Copyright:   (c) 2022, Dobos Raluca                                   *
 *  E-mail:      raluca.dobos@student.tuiasi.ro                           *
 *  Description: Unit-test pentru clasa Chelner                           *
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
    public class ChelnerTests
    {
        private SalaRestaurant _salaRestaurant;

        [TestMethod]
        public void InstanceTest()
        {
            Chelner chelner = Chelner.Instance();
            Assert.IsNotNull(chelner);

        }

        [TestMethod]
        public void PreiaComandaTest()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            IMasa masa = new Masa();
            _salaRestaurant.AddTable(masa);
            Assert.AreEqual(1, _salaRestaurant.ListaMese.Count);

            Chelner chelner = Chelner.Instance();
            Assert.IsNotNull(chelner);

            IComanda comanda = new Comanda(3, new List<Produs>(), "fara branza");

            Client client = new Client(2, 0);
            Assert.IsNotNull(client);

            chelner.PreiaComanda(comanda, client.IndexMasa);
            String bon = chelner.EmiteBon(0, 0);
            Assert.AreNotEqual("", bon);
            Assert.AreEqual(comanda.Facturare(), 0);
        }
    }
}
/**************************************************************************
 *                                                                        *
 *  File:        MasaTests                                                *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@student.tuiasi.ro                      *
 *  Description: Unit-test pentru clasa SalaRestaurant                    *
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
    public class SalaRestaurantTests
    {
        private SalaRestaurant _salaRestaurant;

        [TestMethod()]
        public void InstanceTest()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);
        }

        [TestMethod()]
        public void AddTableTest()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            IMasa masa = new Masa();
            _salaRestaurant.AddTable(masa);
            Assert.AreEqual(1, _salaRestaurant.ListaMese.Count);
        }

        [TestMethod()]
        public void GetCurrentTableTest_0Table()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            IMasa masa = null;
            masa = _salaRestaurant.GetCurrentTable(0);
            Assert.IsNull(masa);
        }

        [TestMethod()]
        public void GetCurrentTableTest()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            IMasa masa = new Masa();
            _salaRestaurant.AddTable(masa);
            Assert.AreEqual(1, _salaRestaurant.ListaMese.Count);

            masa = null;
            masa = _salaRestaurant.GetCurrentTable(0);
            Assert.IsNotNull(masa);
        }

        [TestMethod()]
        public void GetComenziMasaCurentaTest_1Comanda()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            IMasa masa = new Masa();
            _salaRestaurant.AddTable(masa);
            Assert.AreEqual(1, _salaRestaurant.ListaMese.Count);

            masa = null;
            masa = _salaRestaurant.GetCurrentTable(0);
            Assert.IsNotNull(masa);

            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);

            IComanda comanda = new Comanda(0, listaProduse, "");
            masa.AddComanda(comanda);

            Assert.AreEqual(1, _salaRestaurant.GetComenziMasaCurenta().Count);
        }

        [TestMethod()]
        public void GetComenziMasaCurentaTest_0Comenzi()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            IMasa masa = new Masa();
            _salaRestaurant.AddTable(masa);
            Assert.AreEqual(1, _salaRestaurant.ListaMese.Count);

            masa = null;
            masa = _salaRestaurant.GetCurrentTable(0);
            Assert.IsNotNull(masa);

            Assert.AreEqual(0, _salaRestaurant.GetComenziMasaCurenta().Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetComenziMasaCurentaTest_0Mese()
        {
            _salaRestaurant = SalaRestaurant.Instance();
            Assert.IsNotNull(_salaRestaurant);

            int nrComenziMasaCurenta = _salaRestaurant.GetComenziMasaCurenta().Count;
        }
    }
}
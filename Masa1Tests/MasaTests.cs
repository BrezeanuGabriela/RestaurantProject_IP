/**************************************************************************
 *                                                                        *
 *  File:        MasaTests                                                *
 *  Copyright:   (c) 2022, Brezeanu Gabriela                              *
 *  E-mail:      gabriela.brezeanu@student.tuiasi.ro                      *
 *  Description: Unit-test pentru clasa Masa                              *
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
    public class MasaTests
    {
        private IMasa _masa;
        [TestMethod()]
        public void CreateMasa()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);
        }

        [TestMethod()]
        public void AddComandaTest()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);

            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);

            IComanda comanda = new Comanda(0, listaProduse, "");
            _masa.AddComanda(comanda);

            Assert.AreEqual(_masa.Comenzi.Count, 1);
        }

        [TestMethod()]
        public void GetComandaTest()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);

            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);

            IComanda comanda = new Comanda(0, listaProduse, "");
            _masa.AddComanda(comanda);

            IComanda comandaReturnata = null;
            _masa.GetComanda(0, ref comandaReturnata);
            Assert.IsNotNull(comandaReturnata);
        }

        [TestMethod()]
        public void StergeComandaTest()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);

            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);

            IComanda comanda = new Comanda(0, listaProduse, "");
            _masa.AddComanda(comanda);

            IComanda comandaReturnata = null;
            _masa.GetComanda(0, ref comandaReturnata);
            Assert.IsNotNull(comandaReturnata);

            _masa.StergeComanda(comandaReturnata);
            Assert.AreEqual(0, _masa.Comenzi.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void StergeComandaTest_NicioComandaInregistrata()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);

            IComanda comandaReturnata = null;
            _masa.GetComanda(0, ref comandaReturnata);
            Assert.IsNull(comandaReturnata);

            _masa.StergeComanda(comandaReturnata);
        }

        [TestMethod()]
        public void TotalCostComenziMasaTest_ComandaFaraBonEmis()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);

            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);

            IComanda comanda = new Comanda(0, listaProduse, "");
            _masa.AddComanda(comanda);

            IComanda comandaReturnata = null;
            _masa.GetComanda(0, ref comandaReturnata);
            Assert.IsNotNull(comandaReturnata);

            double costTotal = _masa.TotalCostComenziMasa();
            //comanda nu are bonul emis
            Assert.AreEqual(costTotal, -1);
        }

        [TestMethod()]
        public void TotalCostComenziMasaTest_ComandaCuBonEmis()
        {
            _masa = new Masa();
            Assert.IsNotNull(_masa);

            List<Produs> listaProduse = new List<Produs>();
            Produs produs = new Produs("pui", 21.2, null);
            listaProduse.Add(produs);

            IComanda comanda = new Comanda(0, listaProduse, "");
            _masa.AddComanda(comanda);

            IComanda comandaReturnata = null;
            _masa.GetComanda(0, ref comandaReturnata);
            Assert.IsNotNull(comandaReturnata);

            String bon = comanda.TiparesteBon();

            double costTotal = _masa.TotalCostComenziMasa();
            //comanda are bonul emis
            Assert.AreEqual(costTotal, 21.2);
        }
    }
}
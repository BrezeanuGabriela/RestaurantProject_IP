/**************************************************************************
 *                                                                        *
 *  File:        ClientTests                                              *
 *  Copyright:   (c) 2022, Dobos Raluca                                   *
 *  E-mail:      raluca.dobos@student.tuiasi.ro                           *
 *  Description: Unit-test pentru clasa Client                            *
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
    [TestClass]
    public class ClientTests
    {

        [TestMethod]
        public void ClientTest()
        {

            Client client = new Client(1, 1);
            Assert.IsNotNull(client);

        }

        [TestMethod]
        public void AdaugaProdusTest1()
        {
            Client client = new Client(2, 2);
            Assert.IsNotNull(client);

            client.AdaugaProdus(new Produs("piept de pui la gratar", 35, new List<string>()));
            client.AdaugaProdus(new Produs("salata de legume", 15, new List<string>()));

            Assert.AreEqual(client.ProdusList.Count, 2);
        }

        [TestMethod]
        public void AdaugaProdusTest2()
        {
            Client client = new Client(6, 3);
            Assert.IsNotNull(client);

            client.AdaugaProdus(new Produs("cartofi la cuptor", 20, new List<string>()));
            client.AdaugaProdus(new Produs("salata de fructe", 15, new List<string>()));
            client.AdaugaProdus(new Produs("tiramisu", 30, new List<string>()));

            Assert.AreEqual(client.ProdusList.Count, 3);
        }


    }
}
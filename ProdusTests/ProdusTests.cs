/**************************************************************************
 *                                                                        *
 *  File:        UnitTestProdusMeniu                                      *
 *  Copyright:   (c) 2022,Petruca Marco-Alexandru                         *
 *  E-mail:      marco-alexandru.petruca@student.tuiasi.ro                *
 *  Description: Clasa UnitTestProdusMeniu                                *
 *               Clasa utilizata pentru testarea unitatilor Produs        *
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
    public class ProdusTests
    {
        [TestMethod]
        public void TestAfisareProdusNormal()
        {
            List<string> ingrediente = new List<string> { "ciorba", "ulei" };
            Produs p = new Produs("ciorba", 25, ingrediente);
            Assert.AreEqual("ciorba(ciorba, ulei) -  25 lei", p.AfisareProdus());
        }

        [TestMethod]
        public void TestAfisareProdusIngredienteGol()
        {
            List<string> ingrediente = new List<string> {};
            Produs p = new Produs("ciorba", 25, ingrediente);
            Assert.AreNotEqual("", p.AfisareProdus());
        }

        [TestMethod]
        public void TestAfisareProdusNumeGol()
        {
            List<string> ingrediente = new List<string> { "ciorba", "ulei" };
            Produs p = new Produs("", 25, ingrediente);
            Assert.AreEqual("(ciorba, ulei) -  25 lei", p.AfisareProdus());
        }
    }
}
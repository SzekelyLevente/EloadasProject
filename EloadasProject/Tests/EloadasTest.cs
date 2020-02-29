using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject.Tests
{
    [TestFixture]
    class EloadasTest
    {
        [TestCase]
        public void ujEloadasRossz()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas e = new Eloadas(2, 0); });
        }

        [TestCase]
        public void foglalas()
        {
            Eloadas e = new Eloadas(1, 1);
            Assert.AreEqual(true, e.Foglalas());
            Assert.AreEqual(false, e.Foglalas());
        }

        [TestCase]
        public void szabadHelyekSzama()
        {
            Eloadas e = new Eloadas(3, 3);
            e.Foglalas();
            e.Foglalas();
            Assert.AreEqual(7, e.SzabadHelyek());
        }

        [TestCase]
        public void TelivanE()
        {
            Eloadas e = new Eloadas(1, 1);
            e.Foglalas();
            Assert.AreEqual(true, e.Teli());
            Eloadas e2 = new Eloadas(1, 2);
            e2.Foglalas();
            Assert.AreEqual(false, e2.Teli());
        }

        [TestCase]
        public void FoglaltE()
        {
            Eloadas e = new Eloadas(1, 2);
            e.Foglalas();
            Assert.AreEqual(true, e.Foglalt(1,1));
            Assert.AreEqual(false, e.Foglalt(1, 2));
        }

        [TestCase]
        public void FoglaltERossz()
        {
            Eloadas e = new Eloadas(1, 2);
            e.Foglalas();
            Assert.Throws<ArgumentException>(() => { e.Foglalt(0, 1); });
        }
    }
}

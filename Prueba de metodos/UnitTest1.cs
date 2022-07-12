using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Prueba_de_metodos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaDeSqlCmd()
        {
            var names = Programa_Principal.Controllers.CPlatillo.GetNamePlatillos();

            var listaesperada = new List<string>
            {
                "Tajadas con queso",
                "Carne asada",
                "Cerdo asado",
            };
            Assert.AreEqual("Tajadas con queso", names.Find(x => x == "Tajadas con queso"));
        }
    }
}

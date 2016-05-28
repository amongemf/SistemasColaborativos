using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.Tests
{
    [TestClass]
    public class Sumas
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            //Definir el escenario de la pruba =>Paso 1
            var elPrimerOperando = 1;
            var elSegundoOperando = 2;
            var elResultadoEsperado = 3;

            //Invocar el metodo que se desea validar =>Paso 2
            var laSuma = new Suma();
            var elResultadoReal = laSuma.Operar(elPrimerOperando, elSegundoOperando);

            //Verificacion o Comparacion del Resultado obtenido con el esperado =>Paso 3
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);
        }
    }
}

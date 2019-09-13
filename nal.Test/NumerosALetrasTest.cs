using nal.Classes;
using Xunit;

namespace nal.Test
{
    public class NumerosALetrasTest
    {

        [Fact]
        public void ConvertirNumerosALetras_FueraDeRango_RetornaError()
        {
            var respuesta = NumerosALetras.ConvertirNumerosALetras(12345678901234567);

            Assert.Equal("Número fuera de rango.", respuesta);
        }

        [Fact]
        public void ConvertirNumerosALetras_Nuemero_RetornaLetra()
        {
            var respuesta = NumerosALetras.ConvertirNumerosALetras(-1);
            Assert.Equal("MENOS UNO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(0);
            Assert.Equal("CERO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1);
            Assert.Equal("UNO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1.16);
            Assert.Equal("UNO CON 16/100", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(2);
            Assert.Equal("DOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(4);
            Assert.Equal("CUATRO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(5);
            Assert.Equal("CINCO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(7);
            Assert.Equal("SIETE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(8);
            Assert.Equal("OCHO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(9);
            Assert.Equal("NUEVE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(10);
            Assert.Equal("DIEZ", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(11);
            Assert.Equal("ONCE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(12);
            Assert.Equal("DOCE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(13);
            Assert.Equal("TRECE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(14);
            Assert.Equal("CATORCE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(15);
            Assert.Equal("QUINCE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(16);
            Assert.Equal("DIECISÉIS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(20);
            Assert.Equal("VEINTE", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(21);
            Assert.Equal("VEINTIUNO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(22);
            Assert.Equal("VEINTIDÓS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(23);
            Assert.Equal("VEINTITRÉS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(26);
            Assert.Equal("VEINTISÉIS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(32);
            Assert.Equal("TREINTA Y DOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(40);
            Assert.Equal("CUARENTA", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(64);
            Assert.Equal("SESENTA Y CUATRO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(70);
            Assert.Equal("SETENTA", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(80);
            Assert.Equal("OCHENTA", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(90);
            Assert.Equal("NOVENTA", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(100);
            Assert.Equal("CIEN", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(128);
            Assert.Equal("CIENTO VEINTIOCHO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(256);
            Assert.Equal("DOSCIENTOS CINCUENTA Y SEIS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(500);
            Assert.Equal("QUINIENTOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(700);
            Assert.Equal("SETECIENTOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(900);
            Assert.Equal("NOVECIENTOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1000);
            Assert.Equal("MIL", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1100);
            Assert.Equal("MIL CIEN", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(2256);
            Assert.Equal("DOS MIL DOSCIENTOS CINCUENTA Y SEIS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(121000);
            Assert.Equal("CIENTO VEINTIÚN MIL", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1000000);
            Assert.Equal("UN MILLÓN", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1256000);
            Assert.Equal("UN MILLÓN DOSCIENTOS CINCUENTA Y SEIS MIL", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(5000500);
            Assert.Equal("CINCO MILLONES QUINIENTOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1000000000000);
            Assert.Equal("UN BILLÓN", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(1000000256000);
            Assert.Equal("UN BILLÓN DOSCIENTOS CINCUENTA Y SEIS MIL", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(5000000000000);
            Assert.Equal("CINCO BILLONES", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras(5000000256000);
            Assert.Equal("CINCO BILLONES DOSCIENTOS CINCUENTA Y SEIS MIL", respuesta);
        }

        [Fact]
        public void Reemplazar_Valor_RetornaReemplazo()
        {
            var respuesta = NumerosALetras.Reemplazar("Hola Mundo", "Mundo", "NAL");

            Assert.Equal("Hola NAL", respuesta);
        }

    }
}

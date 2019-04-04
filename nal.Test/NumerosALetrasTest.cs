using nal.Classes;
using Xunit;

namespace nal.Test
{
    public class NumerosALetrasTest
    {

        [Fact]
        public void ConvertirNumerosALetras_NoNumero_RetornaError()
        {
            var respuesta = NumerosALetras.ConvertirNumerosALetras("Hola Mundo");

            Assert.Equal("No es un número.", respuesta);
        }

        [Fact]
        public void ConvertirNumerosALetras_FueraDeRango_RetornaError()
        {
            var respuesta = NumerosALetras.ConvertirNumerosALetras("12345678901234567");

            Assert.Equal("Número fuera de rango.", respuesta);
        }

        [Fact]
        public void ConvertirNumerosALetras_Vacio_RetornaVacio()
        {
            var respuesta = NumerosALetras.ConvertirNumerosALetras("");

            Assert.Equal("", respuesta);
        }

        [Fact]
        public void ConvertirNumerosALetras_Nuemero_RetornaLetra()
        {
            var respuesta = NumerosALetras.ConvertirNumerosALetras("0");
            Assert.Equal("CERO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("1");
            Assert.Equal("UNO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("2");
            Assert.Equal("DOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("4");
            Assert.Equal("CUATRO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("8");
            Assert.Equal("OCHO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("16");
            Assert.Equal("DIECISÉIS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("32");
            Assert.Equal("TREINTA Y DOS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("64");
            Assert.Equal("SESENTA Y CUATRO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("128");
            Assert.Equal("CIENTO VEINTIOCHO", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("256");
            Assert.Equal("DOSCIENTOS CINCUENTA Y SEIS", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("1000000");
            Assert.Equal("UN MILLÓN", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("1256000");
            Assert.Equal("UN MILLÓN DOSCIENTOS CINCUENTA Y SEIS MIL", respuesta);

            respuesta = NumerosALetras.ConvertirNumerosALetras("1000000256000");
            Assert.Equal("UN BILLÓN DOSCIENTOS CINCUENTA Y SEIS MIL", respuesta);
        }

        [Fact]
        public void Reemplazar_Valor_RetornaReemplazo()
        {
            var respuesta = NumerosALetras.Reemplazar("Hola Mundo", "Mundo", "NAL");

            Assert.Equal("Hola NAL", respuesta);
        }

    }
}

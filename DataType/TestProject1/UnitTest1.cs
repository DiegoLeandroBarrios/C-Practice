using consola1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DebeSumar1mas1yRetornar2()
        {
            var calc = new consola1.Calculadora();
            var resultado = calc.Sumar(1,1);
            Assert.Equal(2, resultado);
            
        }

        [Fact]
        public void DebeSumar1mas2yRetornar3()
        {
            var calc = new consola1.Calculadora();
            var resultado = calc.Sumar(1, 2);
            Assert.Equal(3, resultado);

        }
        [Fact]
        public void DebeMultiplicarPorSiMismo()//por valor solo queda en la funcion.
        {
            var numero1 = 2;
            var numero2 = numero1;
            var calc = new consola1.Calculadora();
            calc.DemoValor(numero1);

            Assert.Equal(2, numero1);
            Assert.Equal(2, numero2);

            numero1 = 10;
            Assert.Equal(10, numero1);
            Assert.Equal(2, numero2 );

        }
        [Fact]
        public void DebeMultiplicarPor2LaCadenaDelItemValor()
        {
            var item1 = new ItemValor();
            item1.Nombre = "UTN";

            var item2 = item1;//esta diciendo que item2 e item1 son iguales.

            var calc = new consola1.Calculadora();
            
            Assert.Equal("UTN", item2.Nombre);
            
            calc.DemoReferencia(item1);//vemos como cambia el valor del item2 tambien

            Assert.Equal("UTNUTN", item1.Nombre);
            Assert.Equal("UTNUTN", item2.Nombre);

            item2.Nombre = "Yoda";

            Assert.Equal("Yoda", item1.Nombre);
            Assert.Equal("Yoda", item2.Nombre);

            calc.DemoReferencia(item2);

            Assert.Equal("YodaYoda", item1.Nombre);
            Assert.Equal("YodaYoda", item2.Nombre);


        }
        [Fact]
        public void DebeMultiplicarPor2LaCadena()
        {
            var cadena1 = "UTN";
            var cadena2 = cadena1;

            var calc = new Calculadora();//como ya pusimos el using consola1 ya se puede utilizar en todo el code.
            calc.DemoReferencia(ref cadena1);

            Assert.Equal("UTNUTN", cadena1);
            Assert.Equal("UTN", cadena2);
        }
        [Fact]
        public void DemoIgualdad()
        {
            var item1 = new ItemValor();
            item1.Nombre = "UTN";

            var item2 = item1;

            var item3 = new ItemValor();
            item3.Nombre = "UTN";

            Assert.Equal("UTN", item1.Nombre);

            Assert.Equal("UTN", item2.Nombre);


            Assert.Equal(item1.Nombre , item3.Nombre);


            Assert.True(item1 == item1);

            Assert.True(item1 == item2);

            Assert.True(item2 == item2);

            Assert.False(item1 == item3);// es falso porque son distintos objetos pero tienen el mismo valor.

        }
    }
}
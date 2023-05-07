using ConsoleApp3;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PiedraGanaContraTijera()
        {
            //Arrange
            var tijera = new Tijera();
            var piedra = new Piedra();
            //Act
            var result = tijera.ResultadoContra(piedra);
            //Assert
            Assert.Equal("gana", result);
        }
        [Fact]
        public void PiedraEmpataContraPiedra()
        {
            //Arrange
            var piedra2 = new Piedra();
            var piedra = new Piedra();
            //Act
            var result = piedra2.ResultadoContra(piedra);
            //Assert
            Assert.Equal("empate", result);
        }
        [Fact]
        public void PiedraGanaContraPapel()
        {
            //Arrange
            var papel = new Papel();
            var piedra = new Piedra();
            //Act
            var result = papel.ResultadoContra(piedra);
            //Assert
            Assert.Equal("pierde", result);
        }
        [Fact]
        public void TijeraPierdeContraPiedra()
        {
            //Arrange
            var tijera = new Tijera();
            var piedra = new Piedra();
            //Act
            var result = piedra.ResultadoContra(tijera);
            //Assert
            Assert.Equal("pierde", result);
        }
        [Fact]
        public void TijeraEmpataContraTijera()
        {
            //Arrange
            var tijera = new Tijera();
            var tijera2 = new Tijera();
            //Act
            var result = tijera.ResultadoContra(tijera2);
            //Assert
            Assert.Equal("empate", result);
        }
        [Fact]
        public void TiejraGanaContraPapel()
        {
            //Arrange
            var tijera = new Tijera();
            var papel = new Papel();
            //Act
            var result = papel.ResultadoContra(tijera);
            //Assert
            Assert.Equal("gana", result);
        }
        [Fact]
        public void PapelPierdeContraTijera()
        {
            //Arrange
            var tijera = new Tijera();
            var papel = new Papel();
            //Act
            var result = tijera.ResultadoContra(papel);
            //Assert
            Assert.Equal("pierde", result);
        }
        [Fact]
        public void PapelEmpataContraPapel()
        {
            //Arrange
            var papel = new Papel();
            var papel2 = new Papel();
            //Act
            var result = papel2.ResultadoContra(papel);
            //Assert
            Assert.Equal("empate", result);
        }
        [Fact]
        public void PapelGanaContraPiedra()
        {
            //Arrange
            var papel = new Papel();
            var piedra = new Piedra();
            //Act
            var result = piedra.ResultadoContra(papel);
            //Assert
            Assert.Equal("gana", result);
        }
    }
}
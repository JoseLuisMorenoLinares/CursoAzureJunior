using prueba2;

namespace prueba;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void Suma_5_mas_3_da_8()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 5;
        int numero2 = 3;
        int resultadoEsperado = 8;

        //Act
        int resultado = calculadora.Suma(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Suma_3_mas_3_da_6()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 3;
        int numero2 = 3;
        int resultadoEsperado = 6;

        //Act
        int resultado = calculadora.Suma(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Suma_menos_4_mas_menos_4_da_menos_8()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = -4;
        int numero2 = -4;
        int resultadoEsperado = -8;

        //Act
        int resultado = calculadora.Suma(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }


    [TestMethod]
    public void Resta_5_menos_3_da_2()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 5;
        int numero2 = 3;
        int resultadoEsperado = 2;

        //Act
        int resultado = calculadora.Resta(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Resta_3_menos_2_da_1()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 3;
        int numero2 = 2;
        int resultadoEsperado = 1;

        //Act
        int resultado = calculadora.Resta(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplica_5_por_3_da_15()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 5;
        int numero2 = 3;
        int resultadoEsperado = 15;

        //Act
        int resultado = calculadora.Multiplica(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplica_3_por_4_da_12()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 3;
        int numero2 = 4;
        int resultadoEsperado = 12;

        //Act
        int resultado = calculadora.Multiplica(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Divide_10_entre_2_da_5()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 10;
        int numero2 = 2;
        int resultadoEsperado = 5;

        //Act
        int? resultado = calculadora.Divide(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Divide_8_entre_2_da_4()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 8;
        int numero2 = 2;
        int resultadoEsperado = 4;

        //Act
        int? resultado = calculadora.Divide(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Divide_10_entre_0_da_null()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int numero1 = 10;
        int numero2 = 0;
        int? resultadoEsperado = null;

        //Act
        int? resultado = calculadora.Divide(numero1, numero2);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Suma2_2_menos_division_por_cero_me_da_null()
    {
        //Arrange
        Calculadora calculadora = new Calculadora();
        int sumando1 = 2;
        int sumando2 = 2;
        int dividendo = 4;
        int divisor = 0;
        int? resultadoEsperado = null;

        //Act
        int suma = calculadora.Suma(sumando1, sumando2);
        int? division = calculadora.Divide(dividendo, divisor);
        var resultado = suma - division;

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

}
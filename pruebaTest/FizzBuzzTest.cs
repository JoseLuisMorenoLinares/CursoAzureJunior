namespace katas;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void Multiplo_3_da_verdadero()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 3;
        bool resultadoEsperado = true;
        //string resultadoEsperado = "Fizz";

        //Act
        bool resultado = fizzBuzz.Multiplo_de_3(numero1);
        //string resultado = fizzBuzz.Multiplo_de_3(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_3_da_falso()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 2;
        bool resultadoEsperado = false;
        //string resultadoEsperado = "2";

        //Act
        bool resultado = fizzBuzz.Multiplo_de_3(numero1);
        //string  resultado = fizzBuzz.Multiplo_de_3(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_5_da_verdadero()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 5;
        bool resultadoEsperado = true;

        //Act
        bool resultado = fizzBuzz.Multiplo_de_5(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_5_da_falso()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 6;
        bool resultadoEsperado = false;

        //Act
        bool resultado = fizzBuzz.Multiplo_de_5(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_de_3_5_daverdadero()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 15;
        bool resultadoEsperado = true;

        //Act
        bool resultado = fizzBuzz.Multiplo_de_3(numero1) && fizzBuzz.Multiplo_de_5(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_de_3_5_dafalso()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 16;
        bool resultadoEsperado = false;

        //Act
        bool resultado = fizzBuzz.Multiplo_de_3(numero1) && fizzBuzz.Multiplo_de_5(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_3_da_Fizz()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 303;
        string resultadoEsperado = "Fizz";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void No_Multiplo_3_da_numero()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 1;
        string resultadoEsperado = "1";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_5_da_Buzz()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 305;
        string resultadoEsperado = "Buzz";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void No_Multiplo_5_da_numero()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 4;
        string resultadoEsperado = "4";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_3_5_da_FizzBuzz()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 300;
        string resultadoEsperado = "FizzBuzz";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
    [TestMethod]

    public void No_Multiplo_3_5_da_FizzBuzz_da_numero()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 16;
        string resultadoEsperado = "16";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]

   public void El_numero_es_7()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 7;
        bool resultadoEsperado = true;

        //Act
        bool resultado = fizzBuzz.Multiplo_de_7(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

     [TestMethod]

   public void El_numero_no_es_7()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 8;
        bool resultadoEsperado = false;

        //Act
        bool resultado = fizzBuzz.Multiplo_de_7(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }

    [TestMethod]
    public void Multiplo_3_5_7_da_FizzBuzzSUERTE()
    {
        //Arrange
        FizzBuzz fizzBuzz = new FizzBuzz();
        int numero1 = 105;
        string resultadoEsperado = "FizzBuzzSUERTE";

        //Act
        string resultado = fizzBuzz.Multiplo_de_3_5_7_FizzBuzzSUERTE(numero1);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
}
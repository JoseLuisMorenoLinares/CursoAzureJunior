namespace katas;
// Mi primer CI

public class FizzBuzz
{
    public bool Multiplo_de_3(int numero1)
    {
        return (numero1 % 3) == 0;

    }

    public bool Multiplo_de_5(int numero1)
    {
        return (numero1 % 5) == 0;
    }
    
    public bool Multiplo_de_7(int numero1)
    {
        return (numero1 % 7) == 0;
    }

    public string Multiplo_de_3_5_7_FizzBuzzSUERTE(int numero1)
    {
        string retorno = string.Empty;
        
        if (!Multiplo_de_3(numero1) && !Multiplo_de_5(numero1) && !Multiplo_de_7(numero1)) 
        {
            retorno = numero1.ToString();
        }

        if (Multiplo_de_3(numero1)) 
        {
            retorno += "Fizz";
        }

        if (Multiplo_de_5(numero1))
        {
            retorno += "Buzz";
        }

        if (Multiplo_de_7(numero1))
        {
            retorno += "SUERTE";
        }

        return retorno;
    }

}

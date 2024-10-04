namespace prueba2;

public class Calculadora
{
    public int Suma(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public int? Resta(int numero1, int? numero2)
    {
        return numero1 - numero2;
    }

    public int Multiplica(int numero1, int numero2)
    {
        return numero1 * numero2;
    }

    public int? Divide(int numero1, int numero2)
    {
        int? valorRetorno = null;

        if (numero2 > 0)
        {
            return numero1 / numero2;
        }
        else
        {
            return valorRetorno;
        }
    }
}
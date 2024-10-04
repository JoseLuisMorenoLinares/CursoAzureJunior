// El siguiente comando permite desde consola agregar la referencia al projecto de test (pruebaTest) sobre este projecto (prueba)
// dotnet add pruebaTest\pruebaTest.csproj reference prueba\prueba.csproj

// El siguiente comando permite desde consola crear un nuevo proyecto con un metodo main
// dotnet new console --framework net8.0 --use-program-main
// dotnet new console --framework net8.0 --use-program-main --force

namespace prueba;
using prueba2;

class Program
{
    static void Main(string[] args)
    {
        /*
        var calculadora = new Calculadora();
        Console.WriteLine(calculadora.Suma(2, 2));
        Console.WriteLine(calculadora.Resta(2, 2));
        */

//        This code instantiates a value and then calls the ChangeValue method
//        to update the value. The code then prints the updated value to the console.

//        int x = 5;

//        ChangeValue(out x);

//        Console.WriteLine(x);
    }

    static void ChangeValue(out int value) 
    {
        value = 10;
    }
}

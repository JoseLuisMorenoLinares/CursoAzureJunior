// See https://aka.ms/new-console-template for more information


/*
Console.WriteLine("Congratulations!");
Console.Write("");
Console.WriteLine("You wrote your firts lines of code.");
*/


/*
string firstName;

firstName = "Bob";
Console.WriteLine(firstName);

firstName = "Liem";
Console.WriteLine(firstName);

firstName = "Isabella";
Console.WriteLine(firstName);

firstName = "Yasmin";
Console.WriteLine(firstName);
*/


/*
string firstName;
Console.WriteLine(firstName);
*/


/*
var message = "Hello word!";
Console.WriteLine(message);
*/


/*
var message = "Hello word!";
message = 10;
*/

/*
var message;
*/


/*
int numero = 10;
var numeroGrande = numero;
*/


/*
int numero = 10;
double numeroGrande = numero;
*/

/*
//Desafío: Mostrar valores literales y variables
string nombre = "Bob";
int numeroMensajes = 3;
double temperatura = 34.4;

Console.WriteLine("Hello, " + nombre + "! You have " + numeroMensajes + " messages in you inbox. The temperature is " + temperatura + " celsius."); //Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
*/


/*
using System.Text;

Console.WriteLine("su nombre:\"pepe\" y apellidos");
Console.WriteLine("su nombre:\tpepe\n y apellidos");

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("\u3053\u3093\u3068\u3061\u30536F World!");
*/


/*
Console.Clear();
string greeting = "Hola";
string firstName = "Pepe";

string message = $"{greeting} {firstName}!";

Console.WriteLine(greeting + " " + firstName + "!");
Console.WriteLine(message);
*/

/*
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);
 message = $"{updateText} {version}!";
Console.WriteLine(message);
*/


/*
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

var path = $@"C:\Output\{projectName}\Data";
Console.WriteLine(path);
*/


/*
//Desafío: aplicación de formato y visualización de las instrucciones

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");
Console.WriteLine($"{russianMessage}\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");
*/

/*
//SOLUCION 
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
*/


/*
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
*/


/*
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
*/


/*
int numero1 = 100;
int numero2 = 15;
double num1 = 1532.27;
double num2 = 72.69;

Console.Clear();
Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 * numero2));
Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2) + " y resto = " + (numero1 % numero2));
Console.WriteLine(numero1 + " / " + numero2 + " = " + ((decimal)numero1 / numero2) + " division no entera");
Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2) + " y resto = " + (num1 % num2));
*/


/*
int value = 0;     // value is now 0.
Console.WriteLine("value = " + value);
value = value + 5; // value is now 5.
Console.WriteLine("value = " + value);
value += 5;        // value is now 10.
Console.WriteLine("value = " + value);
*/


/*
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
*/


/*
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
*/

//Desafío: Cálculo de los grados Celsius según la temperatura actual en grados Fahrenheit
//Para convertir temperaturas de grados Fahrenheit a Celsius, primero reste 32 y luego multiplique por cinco novenos (5/9).

/*
int fahrenheit = 94;

Console.Clear();
Console.WriteLine("The temperature is " + (((decimal)fahrenheit - 32) * 5 / 9 ) + " Celsius.");
Console.WriteLine("The temperature is " + (((decimal)fahrenheit - 32) * ((decimal)5 / 9)) + " Celsius.");
Console.WriteLine("The temperature is " + ((fahrenheit - 32) * ((decimal)5 / 9)) + " Celsius.");

var celsius = (fahrenheit - 32) * (5 / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
Console.WriteLine("The temperature is " + Math.Round(celsius, 1) + " Celsius.");
Console.WriteLine("The temperature is " + celsius.ToString("##.#") + " Celsius.");
Console.WriteLine("The temperature is " + decimal.Round(celsius, 1) + " Celsius.");
*/


/*
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
int[] sophia = {93, 87, 98, 95, 100};

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

var mediaSophia = ((sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (decimal)currentAssignments);
var mediaNicolas = ((nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (decimal)currentAssignments);
var mediaZahirah = ((zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (decimal)currentAssignments);
var mediaJeong = ((jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (decimal)currentAssignments);

Console.Clear();
Console.WriteLine("Student\tGrade");
Console.WriteLine("Sophia\t" + Math.Round(mediaSophia, 1) + "\t" + (mediaSophia >= 90 ? "A" : "B"));
Console.WriteLine("Nicolas\t" + Math.Round(mediaNicolas, 1) + "\t" + (mediaNicolas >= 90 ? "A" : "B"));
Console.WriteLine("Zahirah\t" + Math.Round(mediaZahirah, 1) + "\t" + (mediaZahirah >= 90 ? "A" : "B"));
Console.WriteLine("Jeong\t" + Math.Round(mediaJeong, 1) + "\t" + (mediaJeong >= 90 ? "A" : "B"));
*/
/*
Console.Clear();

string studentName = "Sophia Johnson";

string[] courseName = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};
int[] courseCredit = {3, 3, 4, 4, 3};
int[] courseGrade = {4, 3, 3, 3, 4};

int sumaGeneral = 0, sumaCredit = 0;

for (int i = 0 ; i < courseGrade.Length ; i++)
{
    sumaGeneral += courseCredit[i] * courseGrade[i];
    sumaCredit += courseGrade[i];
}

Console.WriteLine("sumaGeneral: " + sumaGeneral + " - sumaCredit: " + sumaCredit + " - resultado = " + (decimal)sumaGeneral/sumaCredit);
//Console.WriteLine("Student: " + studentName
*/
/*
Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/


/*
Console.Clear();
Random dice = new Random();
for(int i = 1 ; i < 100 ; i++)
{
    int roll = dice.Next(1, 7);
    Console.WriteLine(roll);
}
*/


/*
//Random dice = new Random();
Console.Clear();
for(int i = 1 ; i < 100 ; i++)
{
    Console.WriteLine(new Random().Next(1, 7));
}
*/


/*
//Desafío de código: implemente un método de la clase Math que devuelva el mayor de dos números.

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);


Console.WriteLine(largerValue);
*/


/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.Clear();
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
*/


/*
int total = 0;
int[] tirada = new int[3];
Console.Clear();
Console.Write("Dice roll: ");

for(int i = 0 ; i < 3 ; i++)
{
    tirada[i] =  new Random().Next(1,7);
    total += tirada[i];

//    Opcion 1
//    if(i < 2)
//    {
//        Console.Write(" + ");
//    }

//    Opcion 2
    Console.Write($"{tirada[i]}" + (i < 2 ? " + " : "\n"));
}


if(tirada[0] == tirada[1] || tirada[0] == tirada[2] || tirada[1] == tirada[2])
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((tirada[0] == tirada[1]) && (tirada[1] == tirada[2])) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

Console.Write($"TOTAL = {total}\n");

if (total > 9)
{
    Console.WriteLine("You win!");
}

if (total < 10)
{
    Console.WriteLine("Sorry, you lose.");
}
*/


/*
//Desafío: Mejora de la tasa de renovación de las suscripciones
Random random = new Random();
//int daysUntilExpiration = random.Next(12);
int daysUntilExpiration;
int discountPercentage = 0;

// Your code goes here

//for(int i = 0 ; i <= 100 ; )

bool continuar = true;
while(continuar)
{
    daysUntilExpiration = random.Next(12);
    Console.Clear();
    Console.WriteLine("daysUntilExpiration = " + daysUntilExpiration);

    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired.");
    }else if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
    }else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    }else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }

    Console.WriteLine("Pulse una tecla para volver a evaluar");
    var tecla = Console.ReadKey();
    if (tecla.KeyChar == 'x')
    {
        continuar = false;
    }
}
*/


/*
//Desafío de código: Notificar los identificadores de pedido que necesitan una investigación más detallada
Console.Clear();
string[] codigos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(string codigo in codigos)
{
    if (codigo.StartsWith("B"))
    {
        Console.WriteLine(codigo);
    }
}
*/


/*
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/


/*
// Opcion con arrays
string[] alumnos = {"Sophia", "Andrew", "Emma", "Logan", "Pepe", "Juan"};
int[][] notas = new int[][]
{
    new int[] {90, 86, 87, 98, 100},
    new int[] {92, 89, 81, 96, 90},
    new int[] {90, 85, 87, 98, 68},
    new int[] {90, 95, 87, 88, 96},
    new int[] {90, 95, 87, 88, 96},
    new int[] {92, 89, 81, 96, 90}
};

int indiceDeAlumno = 0;
decimal sumaDeNotas = 0;

Console.Clear();

if (alumnos.Length != notas.Length)
{
    Console.WriteLine("El numero de alumnos no coincide con el numero de notas");
}
else
{

    foreach(string alumno in alumnos)
    {
        sumaDeNotas = 0;

    // Opcion recorriendo array de notas
    //    foreach(int nota in notas[indiceDeAlumno])
    //    {
    //        sumaDeNotas += nota;
    //    }

    // Opcion sin recorrer array de las notas
        sumaDeNotas =+ notas[indiceDeAlumno].Sum();

        var media = sumaDeNotas / (notas[0].Length);
        indiceDeAlumno++;
        string notaEnLetra;

        if (media <= 59)
        {
            notaEnLetra = "F";
        } else if (media <= 62)
        {
            notaEnLetra = "D-";
        } else if (media <= 66)
        {
            notaEnLetra = "D";
        } else if (media <= 69)
        {
            notaEnLetra = "D+";
        } else if (media <= 72)
        {
            notaEnLetra = "C-";
        } else if (media <= 76)
        {
            notaEnLetra = "C";
        } else if (media <= 79)
        {
            notaEnLetra = "C+";
        } else if (media <= 82)
        {
            notaEnLetra = "B-";
        } else if (media <= 86)
        {
            notaEnLetra = "B";
        } else if (media <= 89)
        {
            notaEnLetra = "B+";
        } else if (media <= 92)
        {
            notaEnLetra = "A-";   
        } else if (media <= 96)
        {
            notaEnLetra = "A";
        } else if (media <= 100)
        {
            notaEnLetra = "A+";
        }
        else
        {
            notaEnLetra = "Fuera de rango";
        }

        Console.WriteLine($"Nombre: {alumno}\t Nota: {media}\t{notaEnLetra}");
    }
}
*/


/*
int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
*/


/*
Console.Clear();
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

//if (product[0] == "01")
//{
//    type = "Sweat shirt";
//} else if (product[0] == "02")
//{
//    type = "T-Shirt";
//} else if (product[0] == "03")
//{
//    type = "Sweat pants";
//}
//else
//{
//    type = "Other";
//}

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

//if (product[1] == "BL")
//{
//    color = "Black";
//} else if (product[1] == "MN")
//{
//    color = "Maroon";
//} else
//{
//    color = "White";
//}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

//if (product[2] == "S")
//{
//    size = "Small";
//} else if (product[2] == "M")
//{
//    size = "Medium";
//} else if (product[2] == "L")
//{
//    size = "Large";
//} else
//{
//    size = "One Size Fits All";
//}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

/*
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
Console.WriteLine("Discount: " + (saleAmount > 1000 ? 100 : 50));
//Console.WriteLine(String.Format("Discount: {0} ", (saleAmount > 1000 ? 100 : 50));
*/


/*
//Desafío de código: escribir código para mostrar el resultado de un cara o cruz
Random moneda = new Random();
int flip = moneda.Next(0, 2);

Console.WriteLine("Resultado: " + (flip == 0 ? "Cara" : "Cruz"));

Console.WriteLine("Resultado: " + (new Random().Next(0, 2) == 0 ? "Cara" : "Cruz"));
*/

/*
string permission = "Manager"; //Admin|Manager
int level = 5;

//Console.WriteLine(permission.Contains("Admin") ? level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user." : level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");

Console.WriteLine(permission.Contains("Admin") ? level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user." : permission.Contains("Manager") ? level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges." : "You do not have sufficient privileges.");
*/


/*
Console.Clear();

for(int i = 0 ; i <= 100 ; i++)
{
    Console.Write(i);

    if(i % 3 == 0 && i % 5 == 0) Console.WriteLine(" - FizzBuzz");
    else if(i % 3 == 0) Console.WriteLine(" - Fizz");
    else if(i % 3 == 0 && i % 5 == 0) Console.WriteLine(" - Buzz");
    else Console.WriteLine();

//    if(i % 3 == 0)
//    {
//        if(i % 5 == 0)
//        {
//            Console.WriteLine(" - FizzBuzz");
//        }
//        else
//        {
//            Console.WriteLine(" - Fizz");
//        }
//    }
//    else
//    {
//        if(i % 5 == 0)
//        {
//            Console.WriteLine(" - Buzz");
//        }
//        else
//        {
//            Console.WriteLine();
//        }
//    }

}
*/

/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

int saludHeroe = 10;
int saludMontruo = 10;
int ataque;
Random dados = new Random();
bool IsHeroe = true; // solo para opcion 3

Console.Clear();
do
{

// OPCION 1    
//    Console.WriteLine("Salud Heroe = " + saludHeroe);
//    Console.WriteLine("Salud Monstruo = " + saludMontruo);

//    ataque = dados.Next(1, 11);
//    Console.WriteLine("Pulse para ataque del Heroe");
//    Console.ReadKey();
//    saludMontruo -= ataque;
//    if(saludMontruo <= 0) continue;

//    ataque = dados.Next(1, 11);
//    Console.WriteLine("Pulse para ataque del Monstruo");
//    Console.ReadKey();
//    saludHeroe -= ataque;
//    if(saludHeroe <= 0) continue;

//    Console.WriteLine("Siguiente ronda\n");

// OPCION 2    
//    Console.WriteLine("Press for Hero attack");
//    Console.ReadKey();
//    ataque = dados.Next(1, 11);
//    saludMontruo -= ataque;
//    Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {saludMontruo} health.");
//    if(saludMontruo <= 0) continue;

//    Console.WriteLine("Press for Monster attack");
//    Console.ReadKey();
//    ataque = dados.Next(1, 11);
//    saludHeroe -= ataque;
//    Console.WriteLine($"Hero was damaged and lost {ataque} health and now has {saludHeroe} health.");
//    if(saludHeroe <= 0) continue;

//    Console.WriteLine("Next Round\n");

    Console.ReadKey();
    ataque = dados.Next(1, 11);
    if (IsHeroe)
    {
        saludMontruo -= ataque;
        Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {saludMontruo} health.");
    }
    else
    {
        saludHeroe -= ataque;
        Console.WriteLine($"Hero was damaged and lost {ataque} health and now has {saludHeroe} health.");
    }

    IsHeroe = !IsHeroe;
// OPCION 3

}while(saludHeroe > 0 && saludMontruo > 0);

/*
Console.WriteLine("\nFin Partida");
Console.WriteLine("Salud Heroe = " + saludHeroe);
Console.WriteLine("Salud Montruo = " + saludMontruo);
Console.WriteLine("GANA " + (saludHeroe > saludMontruo ? "HEROE" : "MONSTRUO"));
*/
Console.WriteLine("\n" + (saludHeroe > saludMontruo ? "HERO" : "MONSTER") + " WINS!");

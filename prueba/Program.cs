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
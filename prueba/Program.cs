﻿// See https://aka.ms/new-console-template for more information


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

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

var path = $@"C:\Output\{projectName}\Data";
Console.WriteLine(path);
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("gustavo", new DateTime(1977,02,04), "25646638");
            Persona persona2 = new Persona("marcelo", new DateTime(2001, 02, 04), "25646637");
            Persona persona3 = new Persona("carlos", new DateTime(2020, 02, 04), "25646636");

            Console.WriteLine(persona1.Mostrar() + persona1.EsMayorDeEdad() + "\n");

            Console.WriteLine(persona2.Mostrar() + persona2.EsMayorDeEdad() + "\n");
         
            Console.WriteLine(persona3.Mostrar() + persona3.EsMayorDeEdad());
        }
    }
}
/*Ejercicio I02 - ¿Vos cuántas primaveras tenés?
Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.

EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.

Mostrar quiénes son mayores de edad y quiénes no.*/
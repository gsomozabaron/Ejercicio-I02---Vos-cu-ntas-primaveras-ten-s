using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string Dni { get => dni; set => dni = value; }

        private int CalcularEdad()
        {
            DateTime anioActual = DateTime.Now;
            int edad = anioActual.Year - this.fechaDeNacimiento.Year;
            return edad;
        }
        public string Mostrar()
        {
            int edad = this.CalcularEdad();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} tiene {edad} años");
            sb.AppendLine($"su fecha de nacimiento es: {this.fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"y su DNI es: {this.dni}");
            return sb.ToString();
        }
        public string EsMayorDeEdad()
        {
            string respuesta = "es menor";
            int edad = this.CalcularEdad();
            if ( edad > 18)
            {
                respuesta = "es mayor de edad";
            }
            return respuesta;
        }

    }
}
/*
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
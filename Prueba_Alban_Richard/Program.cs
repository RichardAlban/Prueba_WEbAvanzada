using System;
class Program
{
	static void Main()
	{
		bool salir = false;

		while (!salir)
		{
			Console.WriteLine("Prueba Parcial Desarrollo Web Avanzado \n");
			Console.WriteLine("Seleccione un ejercicio \n");
			Console.WriteLine("1. Variables y Operadores en C#");
			Console.WriteLine("2. Estructuras de Control en C#");
			Console.WriteLine("3. Programación Orientada a Objetos - Clases y Objetos");
			Console.WriteLine("4. Programación Orientada a Objetos - Métodos");
			Console.WriteLine("5. Programación Orientada a Objetos - Herencia");
			Console.WriteLine("0. Salir \n");
			Console.WriteLine("Ingrese una opcion");

			int opcion = int.Parse(Console.ReadLine());

			switch (opcion)
			{
				case 1:
					Ejercicio1();
					Console.WriteLine("---------------------------------------------------------");
					Console.WriteLine("\n\n");
					break;
				case 2:
					Ejercicio2();
					Console.WriteLine("---------------------------------------------------------");
					Console.WriteLine("\n\n");
					break;
				case 3:
					Ejercicio3();
					Console.WriteLine("---------------------------------------------------------");
					Console.WriteLine("\n\n");
					break;
				case 4:
					Ejercicio4();
					Console.WriteLine("---------------------------------------------------------");
					Console.WriteLine("\n\n");
					break;
				case 5:
					Ejercicio5();
					Console.WriteLine("---------------------------------------------------------");
					Console.WriteLine("\n\n");
					break;
				case 0:
					salir = true;
					break;
				default:
					Console.WriteLine("La opción no es valida");
					break;
			}
		}
	}

	static void Ejercicio1()
	{
		Console.WriteLine("Variables y Operadores en C#");
		int num1 = 5;
		int num2 = 10;
		int res = num1 + num2;
		Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + res);
	}

	static void Ejercicio2()
	{
		Console.WriteLine("Estructuras de Control en C#");
		int edad = 20;
		Console.WriteLine("La edad de la persona es: " + edad);

		if (edad >= 18)
		{
			Console.WriteLine("La persona es mayor de edad.");
		}
		else
		{
			Console.WriteLine("La persona no es mayor de edad.");
		}
	}

	static void Ejercicio3()
	{
		Estudiante estudiante1 = new Estudiante
		{
			Nombre = "Juan",
			Edad = 20,
			Calificacion = 85.5
		};

		Console.WriteLine("Información:");
		Console.WriteLine("Nombre: " + estudiante1.Nombre);
		Console.WriteLine("Edad: " + estudiante1.Edad);
		Console.WriteLine("Calificación: " + estudiante1.Calificacion);
	}

	static void Ejercicio4()
	{
		Estudiante estudiante1 = new Estudiante
		{
			Nombre = "Andres",
			Edad = 24,
			Calificacion = 12.5
		};

		estudiante1.MostrarInformacion();
	}

	static void Ejercicio5()
	{
		EstudianteGraduado graduado1 = new EstudianteGraduado
		{
			Nombre = "Carlos",
			Edad = 24,
			Calificacion = 14.55,
			Titulo = "Ingeriero en Software"
		};

		graduado1.MostrarInformacion();
		Console.WriteLine("Título obtenido: " + graduado1.Titulo);
	}
}

class Estudiante
{
	public string Nombre { get; set; }
	public int Edad { get; set; }
	public double Calificacion { get; set; }
}

class EstudianteGraduado : Estudiante
{
	public string Titulo { get; set; }
}

static class EstudianteExtensions
{
	public static void MostrarInformacion(this Estudiante estudiante)
	{
		Console.WriteLine("Información:");
		Console.WriteLine("Nombre: " + estudiante.Nombre);
		Console.WriteLine("Edad: " + estudiante.Edad);
		Console.WriteLine("Calificación: " + estudiante.Calificacion);
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: BRANDON
 * Fecha: 20/4/2022
 * Hora: 14:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
// Guía:8
// Ejercicio:6
// Fecha: 23/4/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia8Ejercicio6
{
	//Descripcion del programa:
   /*ingresan las temperaturas de cada dia de la semana, determinar e informar:
     a. Promedio de temperatura semanal
     b. El día mas frio y el más caluroso
     c. Porcentaje de temperaturas bajo cero*/

	class Program
	{
		public static void Main(string[] args)
		{
	    //Identificacion del programa en pantalla
		Console.Title=("Calculo de temperaturas en los dias de la semana");
		Console.WriteLine("Calculo de temperaturas en los dias de la semana ");
		Console.WriteLine("Autor:Brandon Gomez");
	    
		//DECLARACION DE VARIABLES
		double temperatura,porcentajeBajoCero; porcentajeBajoCero=0;
		double tempProm; tempProm=0;
		double conTemp; conTemp=0;
		double sumaDia; sumaDia=0;
		double contBajoCero; contBajoCero=0;
		double dia;dia=1;
		double diaCalor;diaCalor=1;
		double diaFrio;diaFrio=1;
		double diaMasFrio; diaMasFrio=0;
		double diaMasCalor; diaMasCalor=0;
		int e; e=1; int a; a=1;
		
		//PROCESO DE DATOS
		while (a<=1)
		{
			
			for (e = 1; e <= 7; e++)
			{
				temperatura=TemperaturaDia(e);
				conTemp=conTemp+temperatura;
				sumaDia=temperatura;
				dia=e;
					
				if (e==1)
				{
				 diaMasCalor=sumaDia;
				 diaMasFrio=sumaDia;
				 contBajoCero=sumaDia;
				}
				else
				{	
				  if(sumaDia>diaMasCalor)
					{
				  	diaMasCalor=sumaDia;
				 	diaCalor=dia;
				     }
					
					if (sumaDia<diaMasFrio)
					{
					diaMasFrio=sumaDia;
					diaFrio=dia; 
					}
					
				   if (sumaDia<0)
				   contBajoCero=dia;
					
				}
			}
			
			//PROCESO DE DATOS
			tempProm=conTemp/7;
			porcentajeBajoCero=contBajoCero*100/7;
			
			a++;
		}	
		ImprimirResultado(diaCalor,diaFrio,tempProm,porcentajeBajoCero);
		Console.ReadKey(true);
	}
	
		public static double TemperaturaDia (int e)
		{double temperatura;
	    //ENTRADA DE DATOS
	    Console.Write("Ingrese la temperatura del dia {0}: ",e); temperatura=double.Parse(Console.ReadLine());
	    return temperatura;}
		
		public static void ImprimirResultado(double diaCalor,double diaFrio,double tempProm,double porcentajeBajoCero)
		{//SALIDA DE DATOS
		Console.WriteLine("-------------------------------------------------------------------------------------------- ");
		Console.WriteLine("Dia mas caluroso: [lUNES=1; Martes=2; Miercoles=3; Jueves=4; Viernes=5; Sabado=6; Domingo=7;]");
		Console.WriteLine("Dia: {0}. ",diaCalor);
		Console.WriteLine("-------------------------------------------------------------------------------------------- ");
		Console.WriteLine(" ");
		Console.WriteLine("Dia mas frio: [lUNES=1; Martes=2; Miercoles=3; Jueves=4; Viernes=5; Sabado=6; Domingo=7;]");
		Console.WriteLine("Dia: {0}. ",diaFrio);
		Console.WriteLine("-------------------------------------------------------------------------------------------- ");
		Console.WriteLine(" ");
		Console.WriteLine("temperatura promedio:{0:0.0} Grados celcius ",tempProm);
		Console.WriteLine("-------------------------------------------------------------------------------------------- ");
		Console.WriteLine(" ");
		Console.WriteLine("El porcentaje de temperaturas bajo cero durante la semana es:{0:0.0}% ",porcentajeBajoCero);}
		
	}
}
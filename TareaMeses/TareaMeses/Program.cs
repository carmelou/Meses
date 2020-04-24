using System;
namespace Tareameses
{
	class Program
	{
		static void Main(string[] args)
		{
			string dato, otro;
			Console.WriteLine("Escribir	numero	para	cambiarlo	a	mes	(solo	numeros):");
			dato = Console.ReadLine();
			string[] meses = new string[13];
			meses[1] = "Enero	";
			meses[2] = "Febrero	";
			meses[3] = "Marzo	";
			meses[4] = "Abril	";
			meses[5] = "Mayo	";
			meses[6] = "Junio	";
			meses[7] = "Julio	";
			meses[8] = "Agosto	";
			meses[9] = "Septiembre	";
			meses[10] = "Octubre	";
			meses[11] = "Noviembre	";
			meses[12] = "Diciembre	";
			otro = "No	es	mes,	los	meses	posibles	son:	Enero,	Febrero, Marzo,	Abril,	Mayo,	Junio,	Juilo,	Agosto,	Septiembre,	Octubre,	Noviembre,	Diciembre";
			if (Convert.ToInt32(dato) >= 1 && Convert.ToInt32(dato) <= 12)
			{
			Console.WriteLine("Su	mes	es:" +meses[Convert.ToInt32(dato)]);
			Console.ReadKey();
			}
			else
			{
			Console.WriteLine(otro);
			Console.ReadKey();
			}
		}
	}
}
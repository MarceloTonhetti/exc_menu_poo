using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc_POO_01
{
	class Veiculo
	{
		//Cadastre um VEICULO (RENAVAN, CHASSIS, PLACA, MARCA, MODELO, COR , ANO) 

		public string Renavan { get; set; }

		public string Chassis { get; set; }

		public string Placa { get; set; }

		public string Marca { get; set; }

		public string Modelo { get; set; }

		public string Cor { get; set; }

		public int Ano { get; set; }

		public void LerDados()
		{
			Console.WriteLine("Informe os dados do veículo");
			Console.Write("Renavan: ");
			Renavan = Console.ReadLine();
			Console.Write("Chassis: ");
			Chassis = Console.ReadLine();
			Console.Write("Placa: ");
			Placa = Console.ReadLine();
			Console.Write("Marca: ");
			Marca = Console.ReadLine();
			Console.Write("Modelo: ");
			Modelo = Console.ReadLine();
			Console.Write("Cor: ");
			Cor = Console.ReadLine();
			Console.Write("Ano: ");
			Ano = int.Parse(Console.ReadLine());
		}

		public override string ToString()
		{
			return ("Renavan: " +Renavan+ "\nChassis: " +Chassis+ "\nPlaca: " +Placa+ "\nMarca" +Marca+ "\nModelo: " +Modelo+ "\nCor: " +Cor+ "\nAno: " +Ano);
		}
	}
}

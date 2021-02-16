using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc_POO_01
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
				Elabore um programa que:
				Cadastre um VEICULO (RENAVAN, CHASSIS, PLACA, MARCA, MODELO, COR , ANO) - OK
				Também cadastre o PROPRIETARIO PESSOA FISICA do Veiculo (CPF, NOME, ENDEREÇO, DATA NASCIMENTO, DATA_COMPRA) -OK

				O usuário poderá escolher em um menu principal se deseja:

				1) informar todos os dados -OK
				2) imprimir os dados que possui -OK
				3) Finalizar o programa -OK
			*/

			int escolhaMenu;

			Pessoa p = new Pessoa();
			Veiculo v = new Veiculo();

			do
			{
				Console.Clear();
				Console.WriteLine("Menu");
				Console.WriteLine("1) Informar todos os dados");
				Console.WriteLine("2) Imprimir os dados que possui");
				Console.WriteLine("3) Finalizar o programa");

				Console.Write("Digite a opção do menu desejada: ");
				escolhaMenu = int.Parse(Console.ReadLine());
				Console.WriteLine("");

				switch (escolhaMenu)
				{
					case 1:
						LerDados(p, v);
						escolhaMenu = 0;
						break;
					case 2:
						ImprimirDados(p, v);
						escolhaMenu = 0;
						break;
				}
			} while (escolhaMenu != 3);

			Console.ReadKey();
		}

		static void LerDados(Pessoa p,Veiculo v)
		{
			p.LerDados();
			v.LerDados();
		}
		static void ImprimirDados(Pessoa p, Veiculo v) 
		{
			Console.WriteLine(p.ToString());
			Console.WriteLine(v.ToString());
			Console.WriteLine("\n\nPrecione qualquer tecla para voltar ao menu...");
			Console.ReadKey();
		}
	}
}

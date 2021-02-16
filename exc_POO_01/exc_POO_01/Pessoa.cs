using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc_POO_01
{
	class Pessoa
	{
		//PROPRIETARIO PESSOA FISICA do Veiculo (CPF, NOME, ENDEREÇO, DATA NASCIMENTO, DATA_COMPRA)

		public string Cpf { get; set; }

		public string Nome { get; set; }

		public string DataNascimento { get; set; }

		public string DataCompra { get; set; }

		public Endereco endereco;


		public void LerDados()
		{
			Console.WriteLine("Informe os dados da pessoa");
			Console.Write("Cpf: ");
			Cpf = Console.ReadLine();
			Console.Write("Nome: ");
			Nome = Console.ReadLine();
			Console.Write("Data de Nasciemnto: ");
			DataNascimento = Console.ReadLine();
			Console.Write("Data de compra do veículo: ");
			DataCompra = Console.ReadLine();
			Console.Write("Endereço: \n");
			endereco = new Endereco();
			endereco.LerDados();
		}

		public override string ToString()
		{
			return ("CPF: " +Cpf+ "\nNome: " +Nome+ "\nEndereço: \n" +endereco.ToString()+  "\nData de nascimento: " +DataNascimento+ "\n Data da compra do veiculo: " +DataCompra);
		}
	}
}

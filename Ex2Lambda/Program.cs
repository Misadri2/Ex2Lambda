using System;
using Ex2Lambda.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Ex2Lambda
{
	class Program
	{
		static void Main(string[] args)
		{
			string arquivo = @"C:\Users\MAON\Projetos\Exercicios Udemy\ExLambda\Ex2Lambda\Ex2Lambda\Funcionarios.txt";

			List<Funcionarios> list = new List<Funcionarios>();

			//! Código usado para ler e listar o arquivo

			using (StreamReader leitorArquivo = File.OpenText(arquivo))
			{
				while (!leitorArquivo.EndOfStream)
				{
					string[] fields = leitorArquivo.ReadLine().Split(',');
					string nome = fields[0];
					string email = fields[1];
					double salario = double.Parse(fields[2], CultureInfo.InvariantCulture);
					list.Add(new Funcionarios(nome, email, salario));
				}
			}

			//Mostrar nome dos funcionários em ordem alfabética cujo salário seja superior a 4k

			var func = list.Where(x => x.Salario >= 4000).OrderBy(x => x.Nome);


			//Mostrar soma do salários dos funcionários que começam com a letra 'M'

			var sum = list.Where(n => n.Nome[0] == 'M').Sum(s => s.Salario);


				foreach (var nome in func)
			{
				Console.WriteLine(nome.Nome + " ganha mais que 4k");
			}

			Console.WriteLine("Soma do salário das pessoas que começam com a letra 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

		}
	}
}

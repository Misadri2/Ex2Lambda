using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2Lambda.Entities
{
	class Funcionarios
	{
		public Funcionarios(string nome, string email, double salario)
		{
			Nome = nome;
			Email = email;
			Salario = salario;
		}

		public string Nome { get; set; }
		public string Email { get; set; }
		public double  Salario { get; set; }

	}
}

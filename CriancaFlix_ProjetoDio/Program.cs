using System;

namespace CriancaFlix
{
	class Program
	{

		static FilmeRepositorio RepositorioFilme = new FilmeRepositorio();
		static void Main(string[] args)
		{

			string SelecionarOpcao = SelecioneOpcao();
			while (SelecionarOpcao.ToUpper() != "0")
			{

				switch (SelecionarOpcao)
				{
					case "1":
						SelListaFilme();
						break;
					case "2":
						SelInserirFilme();
						break;
					case "3":
						SelAtualizarFilme();
						break;
					case "4":
						SelExcluirFilme();
						break;
					case "5":
						SelVisualizarFilme();
						break;
					case "6":
						Console.Clear();
						SelecioneOpcao();
						Console.ReadLine();
						break;

					default:						
						throw new ArgumentOutOfRangeException();
					
				}

				SelecionarOpcao = SelecioneOpcao();
			}

			Console.WriteLine("CriancaFlix agradece seu acesso.");
			Console.ReadLine();
		}
				
		private static string SelecioneOpcao()
		{
			Console.WriteLine("CriançaFlix - Filme Para faixa etária da Criança");
			Console.WriteLine("Selecione opção desejada:");
			Console.WriteLine();
			Console.WriteLine("1- Listar filme");
			Console.WriteLine("2- Inserir novo filme");
			Console.WriteLine("3- Atualizar filme");
			Console.WriteLine("4- Excluir filme");
			Console.WriteLine("5- Verificar dados do filme");
			Console.WriteLine("6- Limpar tela");
			Console.WriteLine("0- Fechar tela");
			Console.WriteLine();

			string SelOpcao = Console.ReadLine();
			return SelOpcao;

		}

		public static void SelListaFilme()
		{
			Console.WriteLine("Listar Filmes");
			var listaF = RepositorioFilme.Lista();

			if (listaF.Count == 0)
			{
				Console.WriteLine("Nenhuma Filme foi encontrado.");
				Console.WriteLine();
				return;
			}
			foreach (var filme in listaF)
			{
				Console.WriteLine("#ID {0}: - {1}", filme.retornaId(), filme.retornaNome());
			}
		}

		public static void SelInserirFilme()
		{

			Console.Write("Digite o Nome do Filme: ");
			string RecebeNome = Console.ReadLine();

		 //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
		 //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1 
            foreach (int i in Enum.GetValues(typeof(Idade)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Idade), i));
            }            

			Console.Write("Digite Idade de Classificação informado acima: ");
			int RecebeIdade = int.Parse(Console.ReadLine());
						
			Console.Write("Digite o Ano de lançamento do Filme: ");
			int RecebeAno = int.Parse(Console.ReadLine());

			Filme Novofilme = new Filme(id: RepositorioFilme.ProximoId(),
										  nome: RecebeNome,
										 idade: RecebeIdade,
										   ano: RecebeAno);

			RepositorioFilme.Insere(Novofilme);
			Console.WriteLine();
		}

		public static void SelAtualizarFilme()
		{

			Console.Write("Digite o id do filme: ");
			int indFilme = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Filme: ");
			string RecebeNome = Console.ReadLine();

			//https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			//https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1 
			foreach (int i in Enum.GetValues(typeof(Idade)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Idade), i));
			}

			Console.Write("Digite Idade de Classificação informado acima: ");
			int RecebeIdade = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de lançamento do Filme: ");
			int RecebeAno = int.Parse(Console.ReadLine());
					
			Filme Atualizafilme = new Filme(id: indFilme,
										  nome: RecebeNome,
										 idade: RecebeIdade,
										   ano: RecebeAno);

			RepositorioFilme.Atualiza(indFilme, Atualizafilme);
			Console.WriteLine();
		}
					
		public static void SelExcluirFilme()
		{

			Console.Write("Digite o id do filme para excluir: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			RepositorioFilme.ExcluiFilme(indiceFilme);
			Console.WriteLine();
		}

		public static void SelVisualizarFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var VisFilme = RepositorioFilme.RetornaPorId(indiceFilme);

			Console.WriteLine(VisFilme);
			Console.WriteLine();
		}		

	}
}

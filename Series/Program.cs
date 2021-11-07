using System;

namespace Series
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
                        //VisualizarSerie();
						break;
					case "4":
                        //AtualizarSerie();
						break;
					case "5":
						//ExcluirSerie();
						break;
					case "6":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = obterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }
        private static void ListarSeries(){
            Console.WriteLine("Listar Séries");
            var lista  = repositorioSerie.Lista();
            if(lista.Count == 0){
                Console.WriteLine("Não há series cadastradas");
                return;
            }
            foreach(var serie in lista){
                Console.WriteLine ("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
            
        }
        private static void InserirSerie(){
            Console.WriteLine ("Inserir nova serie");
            //varre e imprime todos os valores do enum genero 
            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();
            //varre e imprime todos os valores do enum desenvolvedora 
            foreach (int i in Enum.GetValues(typeof(Desenvolvedora)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Desenvolvedora), i));
			}
            Console.Write("Digite a Desenvolvedora entre as opções acima: ");
			int entradaDesenvolvedora = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
										genero: (Genero)entradaGenero,
                                        desenvolvedora: (Desenvolvedora)entradaDesenvolvedora,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);
            repositorioSerie.Insere(novaSerie);
			
        }
        private static string obterOpcaoUsuario(){
            Console.WriteLine("");
            Console.WriteLine("=================");
            Console.WriteLine("Bem a SitSeries");

            Console.WriteLine("1 - Listar Série");
            Console.WriteLine("2 -Inserir Uma nova Série");
            Console.WriteLine("3 -Visualizar Série");
            Console.WriteLine("4 -Atualizar Série");
            Console.WriteLine("5 -Excluir Série");
            Console.WriteLine("6 limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("=================");
            Console.WriteLine("");

            string escolhaUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return escolhaUsuario;
        }
    }
}

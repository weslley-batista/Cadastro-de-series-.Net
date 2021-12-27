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
                        VisualizarSerie();
						break;
					case "4":
                        AtualizarSerie();
						break;
					case "5":
						ExcluirSerie();
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
        private static void VisualizarSerie(){
            Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorioSerie.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
        }
        private static void ExcluirSerie(){
            Console.Write("Digite o id da série a ser removida: ");
			int indiceSerie = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja mesmo excluir a serie indicada");
            Console.WriteLine ("1 - Sim | 2 - Não");
            int respostaConfirmacaoExclusao = int.Parse(Console.ReadLine());
            if(respostaConfirmacaoExclusao == 1){
                repositorioSerie.Exclui(indiceSerie);
                Console.WriteLine("Série excluida com sucesso");
            }else{
                Console.WriteLine(" A série não excluida");
            }            
        }
        private static void AtualizarSerie(){

            ListarSeries(); // imprime todas as series
            Console.Write("Digite o id da série que você deseja atualizar: ");
			int indiceSerie = int.Parse(Console.ReadLine());
            //listar generos
            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());
            //listar desenvolvedoras
            foreach (int i in Enum.GetValues(typeof(Desenvolvedora)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Desenvolvedora), i));
			}
            Console.Write("Digite a Desenvolvedora entre as opções acima: ");
			int entradaDesenvolvedora = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
                                        desenvolvedora: (Desenvolvedora)entradaGenero,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ListarSeries(){
            Console.WriteLine("Listar Séries");
            var lista  = repositorioSerie.Lista();
            if(lista.Count == 0){
                Console.WriteLine("Não há series cadastradas");
                return;
            }
            foreach(var serie in lista){
                var excluido = serie.retoraExcluido();

                Console.WriteLine ("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo(),(excluido ? "|Excluído|" : ""));
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

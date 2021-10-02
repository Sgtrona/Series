using System;
//Autor: Luiz Felipe Lopes da Silva

namespace Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();


        static void Main(string[] args)
        {
            String opcaoUsuario = ObterOpcaoUsuario();

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
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();      

                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("Obrigado por utilizar nossos Serviços");
            Console.ReadLine();

        }


        public static void ListarSeries()
        {
            Console.WriteLine("Listar Series!!");
            var Lista = repositorio.Lista();

            if (Lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Serie foi encontrada!!");
                return;
            }

            foreach(var serie in Lista){
                var excluido = serie.RetornaExcluido();

                if(excluido == false)
                {

                }

                Console.WriteLine("#ID {0}: - {1} - {2}", serie.RetornaId(), serie.RetornaTitulo(), (excluido ? "*Excluido*": ""));
            }


        }



        public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova Serie!!");
           

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da Serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série:");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero) entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao) ;

            repositorio.Insere(novaSerie);
        }




        public static void AtualizarSerie()
        {
            Console.WriteLine("Atualizar Serie!!");
            Console.WriteLine();
            Console.WriteLine("Digite o id da serie:");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Série:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da Serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série:");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

















        public static void ExcluirSerie()
        {
            Console.WriteLine("Digite o ID da serie a ser excluida");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);

        }


        public static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID da serie a ser exibida");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaId(indiceSerie);

            Console.WriteLine(serie);

           
        }




















        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series ao seu dispor!!");
            Console.WriteLine("INFORME A OPÇÃO DESEJADA!!");
            Console.WriteLine("");
            Console.WriteLine("1-listar Series ");
            Console.WriteLine("2-inserir nova Serie ");
            Console.WriteLine("3-Atualizar Serie ");
            Console.WriteLine("4-Excluir Serie ");
            Console.WriteLine("5-Visualizar Serie  ");
            Console.WriteLine("C-Limpar Tela ");
            Console.WriteLine("X-Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }







    }
}

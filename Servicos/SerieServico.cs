using System;
using DIO.Series.Enumeradores;
using DIO.Series.Modelos;
using DIO.Series.Repositorios;

namespace DIO.Series.Servicos
{
    public class SerieServico
    {
        SerieRepositorio _repositorio;

        public SerieServico()
        {
            _repositorio = new SerieRepositorio();
            Inicializa();
        }

        /**
        * Insere dados fictícios ao iniciar o projeto
        * Fonte: https://www.revistabula.com/42751-10-melhores-series-da-netflix-em-2021-ate-agora/
        */
        private void Inicializa()
        {
            InserirSerie(0, "A Cozinheira de Castamar (2021)", 2021, "Ambientado em Madri, no século 18, a série conta a história de Diego e Clara, um casal que por muitas razões não podem ficar juntos. Primeiro, pelo estigma social de uma pessoa de classe alta se relacionar com uma cozinheira. Viúvo, Diego vê em Clara diversas semelhanças com sua falecida esposa. Uma delas é o fato de Clara usar lírios em seus pratos. A flor costumava ser uma forma de Diego demonstrar seu amor por sua mulher.");
            InserirSerie(1, "Ginny e Georgia", 2021, "Georgia é uma mãe na casa dos 30, que teve a filha Ginny quando ainda era adolescente. Hoje, a moça já tem 15 anos, é séria e centrada, enquanto sua mãe é extrovertida e charmosa. Georgia teve uma vida difícil durante a infância e adolescência, e se muda para Nova Inglaterra, onde tentará reconstruir seu lar e dar aos filhos a estabilidade que nunca teve. Contudo, o passado irá retornar para ameaçar o projeto de normalidade para sua família.");
            InserirSerie(2, "Katla", 2021, "Katla se passa em uma pequena cidade nórdica isolada chamada Vik. Quase fantasmagórico, o local é gradualmente abandonado por seus habitantes, que se veem ameaçados por um vulcão subglacial que entrou em erupção há um ano. O cotidiano de quem optou por ficar na cidade vira de cabeça para baixo quando uma jovem, coberta de cinzas, surge do nada. À medida que as perguntas se multiplicam, outras pessoas estranhas começam a aparecer na cidade. De onde eles vêm?");
            InserirSerie(3, "Lupin", 2021, "O pai de Assane Diop era um imigrante senegalês na França que, após ser acusado de roubar seu patrão, se enforca de vergonha. Vinte e cinco anos mais tarde, Assane se tornou um ladrão de elite, disposto a usar de suas habilidades para o roubo e seu carisma para se vingar de Hubert, o ex- patrão de seu pai.");
            InserirSerie(4, "Navillera", 2021, "Navillera conta a história de um ex-carteiro de 70 anos chamado Duk Chool, que sempre quis dançar balé. Na escola de dança, ele conhece Chae Rok, um bailarino de 23 anos, que passa por dificuldades financeiras e pensa em desistir de seus sonhos. A bela amizade entre eles nos mostra que, por mais clichê que possa parecer, vivemos apenas uma vez.");
            InserirSerie(5, "Por Trás de Seus Olhos", 2021, "Louise é uma mãe solteira que trabalha como secretária em um escritório psiquiátrico. Ela começa a ter um caso com seu chefe, mas também inicia uma amizade improvável com a esposa traída. Estranhamente, essa esposa parece saber tudo que acontece. Aos poucos, Louise percebe que está presa em uma rede de mentiras e que ninguém é confiável.");
            InserirSerie(6, "Sombra e Ossos", 2021, "Alina Starkov é uma cartógrafa que leva uma vida normal até que descobre ser Grisha, uma espécie de ser mágico que possui poderes sobre elementos da natureza. Ela é separada para ser treinada junto a um exército de elite com aptidões fantásticas. A tropa está sendo preparada para lutar contra o iminente avanço da Dobra das Sombras, uma faixa de escuridão que transforma o reino em sombra e ossos.");
            InserirSerie(7, "Somos", 2021, "Em março de 2011, a cidade de Allende sofreu um massacre por um dos cartéis mais perigosos do México, em resposta a uma infiltração da DEA, a polícia antidrogas norte-americana. A série se inspira na investigação do ProPublica, que inclui numerosos depoimentos escritos e orais de testemunhas, residentes de Allende e membros das autoridades locais, da DEA e do cartel Zetas. A investigação revelou o erro da polícia que desencadeou o massacre.");
            InserirSerie(8, "Sweet Tooth", 2021, "Um vírus chamado Flagelo dizimou grande parte da humanidade e, por alguma razão, fez com que todos os novos bebês nascessem como híbridos, metade humano e metade animal. Com medo do que essas criaturas sejam ou possam causar, os humanos as perseguem e matam. Gus, um menino-cervo, foi protegido e criado em segredo por seu pai no Parque Nacional de Yosemite. Após a morte do pai, os caminhos do menino se cruzam com o do ex-astro do futebol Tommy Jepperd, que se torna seu grande amigo e protetor. Juntos eles partem em uma jornada para tentar encontrar a mãe de Gus.");
            InserirSerie(9, "Young Royals", 2021, "Príncipe Wilhelm se envolve em um escândalo e é enviado para um internato. Estudar no prestigioso instituto de Hillerska dará ao príncipe a oportunidade de explorar seu verdadeiro eu. O sonho de Wilhelm de um futuro cheio de liberdade e amor incondicional, longe das obrigações reais, no entanto, prova ser mais desafiador do que o previsto quando ele se torna o próximo na linha de sucessão do trono sueco. Ele deve fazer uma escolha entre o amor e o dever.");
        }

        public void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            if (!IndiceValido(indiceSerie)) return;

            _repositorio.Exclui(indiceSerie);
        }

        public void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = _repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        public void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            if (!IndiceValido(indiceSerie)) return;

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            if (!GeneroValido(entradaGenero)) return;

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            if (!AnoValido(entradaAno)) return;

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            _repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        public void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = _repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine(serie.ToString());
            }
        }

        public void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            if (!GeneroValido(entradaGenero)) return;

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            if (!AnoValido(entradaAno)) return;

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: _repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            _repositorio.Insere(novaSerie);
        }

        public void InserirSerie(int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao)
        {
            Serie novaSerie = new Serie(id: _repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            _repositorio.Insere(novaSerie);
        }

        public string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private bool IndiceValido(int indiceSerie)
        {
            if (indiceSerie < 0 || indiceSerie > _repositorio.ProximoId())
            {
                Console.WriteLine("\nId inválido, por favor repita a operação");
                return false;
            }
            return true;
        }

        private bool GeneroValido(int entradaGenero)
        {
            if (entradaGenero > Enum.GetValues(typeof(Genero)).Length)
            {
                Console.WriteLine("\nGênero inválido, por favor repita a operação");
                return false;
            }
            return true;
        }

        private bool AnoValido(int entradaAno)
        {
            if (entradaAno < 0 || entradaAno > int.Parse(DateTime.Now.ToString("yyyy")))
            {
                Console.WriteLine("\nAno inválido, por favor repita a operação");
                return false;
            }
            return true;
        }
    }
}
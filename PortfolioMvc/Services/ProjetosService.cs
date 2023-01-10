using PortfolioMvc.Models;

namespace PortfolioMvc.Services
{
    public class ProjetosService : IProjetosService
    {
        public List<Projeto> GetProjetos()
        {
            return new List<Projeto>() {
                new Projeto
                {
                    Titulo = "Blog Mais Saúde",
                    Descricao = "Blog desenvolvido para a disciplina Projeto Integrador 1, na faculdade de Sistemas de Informação e postado na AWS.",
                    Link = "https://github.com/progjaoo/BlogMaisSaude",
                    ImagemURL = "/imagens/blogsaudeportf.png"
                },
                    new Projeto
                {
                    Titulo = "Site para Venda de Lanches",
                    Descricao = "Site desenvolvido em um dos cursos que realizei, onde foi abordado diversos conhecimentos da plataforma ASP .NET Core.",
                    Link = "https://github.com/progjaoo/SiteDeVendaDeLanches",
                    ImagemURL = "/imagens/vendadelanchesportf.png"

                },
                    new Projeto
                {
                    Titulo = "Assistente Virtual simples",
                    Descricao = "Assistente Virtual, criada em c# WindowsForms, com Microsoft Synthesis, e funções simples.",
                    Link = "https://github.com/progjaoo/AssistenteVirtual",
                    ImagemURL = "/imagens/assistenteportf.png"
                },
                    new Projeto
                {
                    Titulo = "Projeto Livraria CRUD",
                    Descricao = "Primeiro projeto que desenvolvi, aplicação Desktop, em WindowsForms + Sql Server no inicio da faculdade, um controle básico para uma livraria",
                    Link = "https://github.com/progjaoo/LivrariaAEDB",
                    ImagemURL = "/imagens/Crud.png"
                },
                    new Projeto
                {
                    Titulo = "Landing Page SpaceX",
                    Descricao = "Landing Page desenvolvida com base na página da SpaceX usando SaaS, bootstrap e CSS para fixação de conhecimentos.",
                    Link = "https://github.com/progjaoo/LandingPageSpaceX",
                    ImagemURL = "/imagens/spcX.gif"
                },
                    new Projeto
                {
                    Titulo = "Chat para o Blog Mais Saúde",
                    Descricao = "Chat desenvolvido com SignalR, na parte do servidor, e o Front desenvolvido com Angular, bem simples",
                    Link = "https://github.com/progjaoo/ChatAngularSignalR",
                    ImagemURL = "/imagens/chatAngular.png"
                },
                    new Projeto
                {
                    Titulo = "Bateria Online",
                    Descricao = "Simulador de bateria online, desenvolvido em Javascript, bem simples porém bem aplicável os conhecimentos.",
                    Link = "https://github.com/progjaoo/BateriaOnline",
                    ImagemURL = "/imagens/bateriaportf.png"
                },
                    new Projeto
                {
                    Titulo = "Calculadora de IMC resposiva e interativa",
                    Descricao = "Realiza os cálculos base e entrega qual circunstância de saúde você está, aplicável para estudos e conhecimentos gerais da linguagem",
                    Link = "https://github.com/progjaoo/CalculoDeIMC",
                    ImagemURL = "/imagens/calculoimc.png"
                },
                    new Projeto
                {
                    Titulo = "Mini Player Online",
                    Descricao = "Para aplicação de conhecimentos, fiz este player para tocar músicas genéricas do Youtube Music.",
                    Link = "https://github.com/progjaoo/MiniPlayer",
                    ImagemURL = "/imagens/minip.png"
                },
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppGuiaDev.Models;

namespace AppGuiaDev.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Instrumental",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira - inglês, utilizando o vocabulário " +
                                                   "e a terminologia da área.   ",

                    ValoresAtitudes = "Respeitar as manifestações culturais de outros povos. º Estimular a comunicação nas " +
                                      "relações interpessoais. º Socializar os saberes.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens " +
                                                   "de programação e ambientes de desenvolvimento de acordo com as especificidades do " +
                                                   "projeto. º Codificar e depurar programas. ",

                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. º Incentivar ações " +
                                      "que promovem a cooperação. º Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II",

                    AtribuicoesResponsabilidades = "Implementar Banco de Dados. ",
                                                  

                    ValoresAtitudes = "Incentivar a criatividade. º Desenvolver a criticidade. º Fortalecer a persistência e o " +
                                      "interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Internet e Protocolos",

                    AtribuicoesResponsabilidades = "Utilizar protocolos de redes e internet para comunicação de dados.   " +                                  
                                                   "elaborar registros e planilhas de acompanhamentto e controle de atividades",

                    ValoresAtitudes = "Incentivar comportamentos éticos. º Promover ações que considerem o respeito às normas " +
                                      "estabelecidas. º Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. " ,
                    ValoresAtitudes = "Incentivar a criatividade. º Responsabilizar-se pela produção, utilização e " +
                                      "divulgação de informações. º Estimular a organização. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de ionformações. " +
                                      " º Fortalecer a persistência e o interesse na resolução de situações-problemna. " +
                                      "º Incentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Planejamento do Trabalho de Conslusão de Curso (TCC) em Desenvolvimento de Sistemas ",

                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas computacionais ",

                    ValoresAtitudes = "Comunicar-se com a equipe com clareza e objetividade. º Organizar procedimentos de " +
                                      "maneira diversa, visando melhor eficiência "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
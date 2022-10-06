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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação  ",

                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação. ",

                    ValoresAtitudes = "Estimular atitudes respeitosas. º Incentivar comportamentos éticos. º Desenvolver a criticidade.  "

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
                    Nome = "Banco de Dados III  ",

                    AtribuicoesResponsabilidades = "Realizar gestão de bancos de dados. ",

                    ValoresAtitudes = "Incentivar a criatividade. º Desenvolver a criticidade. º Fortalecer a persistência " +
                                      "e o interesse na resolução de situações-problema. "

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
                    Nome = "Sistemas Embarcados  ",

                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados. ",

                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. " +
                                      "º Estimular a organização. º Incentivar a criatividade. "

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
                    Nome = "Programação de Aplicativos Mobile II  ",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e diuvulgação de informações. " +
                                      "º Incentivar a criatividade. º Estimular a organização "

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
                    Nome = "Programação Web III  ",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web. ",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. " +
                                      "º Fortalecer a persistência e o interesse na resolução de situações-problema. º Incentivar a criatividade. "

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
                    Nome = "Qualidade e Teste de Software  ",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas. ",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. º Estimular " +
                                      "a produtividade. º Desenvolver criticidade. º Incentivar comportamentos éticos. "

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
                    Nome = "Ética e Cidadania Organizacional  ",

                    AtribuicoesResponsabilidades = "Atuar de acordo com princípios éticos nas relações de trabalho. ",

                    ValoresAtitudes = "Estimular atitudes respeitosas. º Incentivar comportamentos éticos. º Comprometer-se " +
                                      "com a igualdade de direitos. "

                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");

            }
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas   ",

                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.  ",

                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. º Demonstrar " +
                                      "comprometimento com equipe e o trabalho.  "

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
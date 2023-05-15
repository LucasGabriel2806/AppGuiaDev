using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppGuiaDev.Views;

namespace AppGuiaDev
{
    [DesignTimeVisible(false)]

    //Aqui mudamos a herança da classe mainpage, agora ela herdara
    //da MasterDetailPage, não mais da ContentPage.
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            /**
             * Propriedade onde é exibido a página que eu carregar apartir do
             * clique do menu.
             * Navigation Page: usamos esse objeto pra criar navegação entre 
             * as páginas no xamarin. Eu estou instanciando ele aqui, porque eu 
             * estou assumindo que, lá dentro da minha página Inicial, eu posso ter
             * botôes que eu vou clicar e ir pra outro lugar, posso ter menus.
             * Eu vou precisar ter navegação no meu app, todos os Detail estão como
             * NavigationPage.
             * Activator é um "fazedor de instancias", ele vai verificar se o tipo da
             * Inicial é uma página e vai criar uma instancia dessa página.
             */
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private async void Open_Inicial(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Primeiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesPrimeiro)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Segundo(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesSegundo)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Terceiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesTerceiro)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Vestibulinho(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Open_Contato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    }
}

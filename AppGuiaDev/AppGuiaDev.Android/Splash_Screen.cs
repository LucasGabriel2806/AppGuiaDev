using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGuiaDev.Droid
{
    /**
     * O estilo dela vai ser exatamente aquele tema que editei
     * no styles.xml.
     * Eu não fiz isso no MainActivity, porque se não ia valer pro 
     * aplicativo inteiro, e eu não queria, eu queria que esse
     * tema só se aplicasse a splash screen.
     * NoHistory: Se o usuário apertar pra voltar, ele volta pra
     * "area de trabalho do celular".
     * Label é o nome do app na "area de trabalho"
     * 
     * Na primeira vez que vc editar td isso da splash screen e for 
     * testar a splash_screen, talves não funcione, porque vc ta 
     * num ambiente de emulação, ten cache e várias coisas envolvidas.
     * O ideal é fechar os apps, desinstalar, ir no menu compilação,
     * e vai mandar recompilar o projeto.Android. É importante recompilar
     * sempre pra ele se desfazer dos arquivos de cache, pegar as novas definições
     * que vc fez e fazer elas valerem. Ai ele vai recompilar todos os 
     * bytecodes e coisas do Android, fazendo funcionar.
     */
    [Activity(Theme = "@style/MyTheme.Splash",
              MainLauncher = true,
              NoHistory = true,            
              Label = "Guia DS ")]
    public class Splash_Screen : Activity
    {
        /**
         * Quando dispara meu método eu mando startar a MainActivity,
         * que é a activity que da vida ao meu app, que vai instanciar
         * todas as coisas, que vai abrir o app de fato.
         */
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
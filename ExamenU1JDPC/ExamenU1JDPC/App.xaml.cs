using ExamenU1JDPC.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenU1JDPC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new examenVista();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

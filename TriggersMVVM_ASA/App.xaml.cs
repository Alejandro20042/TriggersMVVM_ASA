using System;
using TriggersMVVM_ASA.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_ASA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Categoria();
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

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingTicket
{
    public partial class App : Application
    {

        private static AtividadeDao database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }


        internal static AtividadeDao Database
        {
            get
            {
                if (database == null)
                {
                    AtividadeDao atividadeDao = new AtividadeDao(DependencyService.Get<IFileHelper>()
                                            .GetLocalFilePath("AtividadeSQLite.db3"));
                    database = atividadeDao;
                }

                return database;
            }
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

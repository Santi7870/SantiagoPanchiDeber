using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SantiagoPanchi.ViewModels
{
    internal class SPAboutViewModel
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://www.linkedin.com/in/santiago-panchi-3627ab33b/";
        public string Message => "¡Hola! Soy Santiago Panchi, un apasionado desarrollador de Ecuador. Me especializo en la creación de aplicaciones móviles y soluciones de software. Mi objetivo es crear aplicaciones que mejoren la vida de las personas y hagan que la tecnología sea más accesible.";
        public ICommand ShowMoreInfoCommand { get; }

        public SPAboutViewModel()
        {
            ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
        }

        async Task ShowMoreInfo() =>
            await Launcher.Default.OpenAsync(MoreInfoUrl);
    }
}

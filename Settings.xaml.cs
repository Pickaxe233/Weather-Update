using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Weather_Upate
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }
        private async void Github_Click(object sender, RoutedEventArgs e)
        {
            var Github = new Uri(@"https://github.com/Pickaxe233/Weather-Update");
            await Windows.System.Launcher.LaunchUriAsync(Github);
        }

        private async void Report(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var MyGithub = new Uri(@"https://github.com/Pickaxe233");
            await Windows.System.Launcher.LaunchUriAsync(MyGithub);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Book_movie_tickets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void DN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Main_Tabbed());
        }

        private void DK_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DK());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Book_movie_tickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListFilm : ContentPage
    {
        public ListFilm(Model.RapChieu rapchieu)
        {
            InitializeComponent();

        }
    }
}
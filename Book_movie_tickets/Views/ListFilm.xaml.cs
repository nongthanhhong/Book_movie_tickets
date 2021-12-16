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
            create_collec_movie();
            this.BindingContext = rapchieu;
        }

        List<Model.Movies> movieList = new List<Model.Movies>();
        void create_collec_movie()
        {
            movieList.Add(new Model.Movies { Title = "Fast & Furious 9", Poster = "FastFurious9.jfif", });
            movieList.Add(new Model.Movies { Title = "NOBITA VÀ MẶT TRĂNG PHIÊU LƯU KÝ", Poster = "Doremon.jpg" });
            movieList.Add(new Model.Movies { Title = "Mission Impossible 6", Poster = "MissionImpossible6.jpg" });
            Coll_film.ItemsSource = movieList;
        }

        private void Coll_film_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}